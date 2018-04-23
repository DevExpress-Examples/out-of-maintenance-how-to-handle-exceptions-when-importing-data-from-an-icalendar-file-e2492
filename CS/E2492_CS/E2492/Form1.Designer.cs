namespace iCalendarImport {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtVCalendar = new System.Windows.Forms.RichTextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ckhBreakOnError = new System.Windows.Forms.CheckBox();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.lblSource = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(646, 434);
            this.schedulerControl1.Start = new System.DateTime(2010, 9, 1, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtVCalendar);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(646, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(240, 434);
            this.panelControl1.TabIndex = 1;
            // 
            // txtVCalendar
            // 
            this.txtVCalendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVCalendar.DetectUrls = false;
            this.txtVCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVCalendar.Location = new System.Drawing.Point(2, 83);
            this.txtVCalendar.Name = "txtVCalendar";
            this.txtVCalendar.Size = new System.Drawing.Size(236, 349);
            this.txtVCalendar.TabIndex = 2;
            this.txtVCalendar.Text = resources.GetString("txtVCalendar.Text");
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblSource);
            this.panelControl2.Controls.Add(this.ckhBreakOnError);
            this.panelControl2.Controls.Add(this.btnImport);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(236, 81);
            this.panelControl2.TabIndex = 3;
            // 
            // ckhBreakOnError
            // 
            this.ckhBreakOnError.AutoSize = true;
            this.ckhBreakOnError.Checked = true;
            this.ckhBreakOnError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckhBreakOnError.Location = new System.Drawing.Point(97, 16);
            this.ckhBreakOnError.Name = "ckhBreakOnError";
            this.ckhBreakOnError.Size = new System.Drawing.Size(94, 17);
            this.ckhBreakOnError.TabIndex = 4;
            this.ckhBreakOnError.Text = "Break on Error";
            this.ckhBreakOnError.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(5, 10);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(86, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblSource
            // 
            this.lblSource.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSource.Location = new System.Drawing.Point(2, 49);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(232, 30);
            this.lblSource.TabIndex = 5;
            this.lblSource.Text = "The folowing content in iCalendar format\r\n will be imported:";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 434);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "iCalendarImport";
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox txtVCalendar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.CheckBox ckhBreakOnError;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private System.Windows.Forms.Label lblSource;
    }
}

