Namespace iCalendarImport
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.txtVCalendar = New System.Windows.Forms.RichTextBox()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.ckhBreakOnError = New System.Windows.Forms.CheckBox()
            Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
            Me.lblSource = New System.Windows.Forms.Label()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(646, 434)
            Me.schedulerControl1.Start = New Date(2010, 9, 1, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.txtVCalendar)
            Me.panelControl1.Controls.Add(Me.panelControl2)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelControl1.Location = New System.Drawing.Point(646, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(240, 434)
            Me.panelControl1.TabIndex = 1
            ' 
            ' txtVCalendar
            ' 
            Me.txtVCalendar.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtVCalendar.DetectUrls = False
            Me.txtVCalendar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtVCalendar.Location = New System.Drawing.Point(2, 83)
            Me.txtVCalendar.Name = "txtVCalendar"
            Me.txtVCalendar.Size = New System.Drawing.Size(236, 349)
            Me.txtVCalendar.TabIndex = 2
            Me.txtVCalendar.Text = resources.GetString("txtVCalendar.Text")
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.lblSource)
            Me.panelControl2.Controls.Add(Me.ckhBreakOnError)
            Me.panelControl2.Controls.Add(Me.btnImport)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(2, 2)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(236, 81)
            Me.panelControl2.TabIndex = 3
            ' 
            ' ckhBreakOnError
            ' 
            Me.ckhBreakOnError.AutoSize = True
            Me.ckhBreakOnError.Checked = True
            Me.ckhBreakOnError.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ckhBreakOnError.Location = New System.Drawing.Point(97, 16)
            Me.ckhBreakOnError.Name = "ckhBreakOnError"
            Me.ckhBreakOnError.Size = New System.Drawing.Size(94, 17)
            Me.ckhBreakOnError.TabIndex = 4
            Me.ckhBreakOnError.Text = "Break on Error"
            Me.ckhBreakOnError.UseVisualStyleBackColor = True
            ' 
            ' btnImport
            ' 
            Me.btnImport.Location = New System.Drawing.Point(5, 10)
            Me.btnImport.Name = "btnImport"
            Me.btnImport.Size = New System.Drawing.Size(86, 23)
            Me.btnImport.TabIndex = 0
            Me.btnImport.Text = "Import"
            ' 
            ' lblSource
            ' 
            Me.lblSource.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblSource.Location = New System.Drawing.Point(2, 49)
            Me.lblSource.Name = "lblSource"
            Me.lblSource.Size = New System.Drawing.Size(232, 30)
            Me.lblSource.TabIndex = 5
            Me.lblSource.Text = "The folowing content in iCalendar format" & ControlChars.CrLf & " will be imported:"
            Me.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(886, 434)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "iCalendarImport"
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.panelControl2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private txtVCalendar As System.Windows.Forms.RichTextBox
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private ckhBreakOnError As System.Windows.Forms.CheckBox
        Private WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
        Private lblSource As System.Windows.Forms.Label
    End Class
End Namespace

