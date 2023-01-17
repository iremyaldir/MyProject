namespace LogInPage
{
    partial class AppointmentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Calender = new System.Windows.Forms.MonthCalendar();
            this.TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make an Appointment";
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(42, 86);
            this.Calender.Name = "Calender";
            this.Calender.TabIndex = 2;
            this.Calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calender_DateChanged);
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(42, 279);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(143, 20);
            this.TB.TabIndex = 3;
            this.TB.TextChanged += new System.EventHandler(this.TB_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.Calender);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar Calender;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Button button1;
    }
}