using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
#region #usings
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.iCalendar;
#endregion #usings

namespace iCalendarImport {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            schedulerControl1.DayView.TopRowTime = TimeSpan.FromHours(8);
        }

        private void btnImport_Click(object sender, EventArgs e) {
            byte[] buffer = System.Text.Encoding.ASCII.GetBytes(txtVCalendar.Text);
            using (MemoryStream fs = new MemoryStream(buffer)) {
                ImportAppointments(fs);
            }

        }

        void ImportAppointments(Stream stream) {
            if (stream == null || stream == Stream.Null || stream.Length == 0)
                return;
            iCalendarImporter importer = new iCalendarImporter(schedulerStorage1);
            importer.OnException += new ExchangeExceptionEventHandler(importer_OnException);
            importer.Import(stream);
        }

        #region #onexception
        void importer_OnException(object sender, ExchangeExceptionEventArgs e) {
            iCalendarParseExceptionEventArgs args = e as iCalendarParseExceptionEventArgs;
            if (args != null) {
                if (ckhBreakOnError.Checked) {
                    iCalendarImporter importer = (iCalendarImporter)sender;
                    importer.Terminate();
                }
                ShowErrorMessage(String.Format("Cannot parse line {0} with text '{1}'",
                    args.LineIndex, args.LineText));
            }
            else
                ShowErrorMessage(e.OriginalException.Message);

            e.Handled = true; // prevent this exception from throwing
        }
        #endregion #onexception

        void ShowErrorMessage(string text) {
            XtraMessageBox.Show(text, Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}