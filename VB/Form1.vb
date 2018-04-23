Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
#Region "#usings"
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.iCalendar
#End Region ' #usings

Namespace iCalendarImport
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            schedulerControl1.DayView.TopRowTime = TimeSpan.FromHours(8)
        End Sub

        Private Sub btnImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImport.Click
            Dim buffer() As Byte = System.Text.Encoding.ASCII.GetBytes(txtVCalendar.Text)
            Using fs As New MemoryStream(buffer)
                ImportAppointments(fs)
            End Using

        End Sub

        Private Sub ImportAppointments(ByVal stream As Stream)
            If stream Is Nothing OrElse stream Is System.IO.Stream.Null OrElse stream.Length = 0 Then
                Return
            End If
            Dim importer As New iCalendarImporter(schedulerStorage1)
            AddHandler importer.OnException, AddressOf importer_OnException
            importer.Import(stream)
        End Sub

        #Region "#onexception"
        Private Sub importer_OnException(ByVal sender As Object, ByVal e As ExchangeExceptionEventArgs)
            Dim args As iCalendarParseExceptionEventArgs = TryCast(e, iCalendarParseExceptionEventArgs)
            If args IsNot Nothing Then
                If ckhBreakOnError.Checked Then
                    Dim importer As iCalendarImporter = DirectCast(sender, iCalendarImporter)
                    importer.Terminate()
                End If
                ShowErrorMessage(String.Format("Cannot parse line {0} with text '{1}'", args.LineIndex, args.LineText))
            Else
                ShowErrorMessage(e.OriginalException.Message)
            End If

            e.Handled = True ' prevent this exception from throwing
        End Sub
        #End Region ' #onexception

        Private Sub ShowErrorMessage(ByVal text As String)
            XtraMessageBox.Show(text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
    End Class
End Namespace