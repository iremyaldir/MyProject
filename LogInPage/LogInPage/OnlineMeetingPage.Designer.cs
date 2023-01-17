namespace LogInPage
{
    partial class OnlineMeetingPage
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
            this.UrlLb = new System.Windows.Forms.Label();
            this.UrlTb = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.UrlTb2 = new System.Windows.Forms.TextBox();
            this.UrlLb2 = new System.Windows.Forms.Label();
            this.ConnectBtn2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlLb
            // 
            this.UrlLb.AutoSize = true;
            this.UrlLb.Location = new System.Drawing.Point(74, 103);
            this.UrlLb.Name = "UrlLb";
            this.UrlLb.Size = new System.Drawing.Size(32, 13);
            this.UrlLb.TabIndex = 0;
            this.UrlLb.Text = "URL:";
            // 
            // UrlTb
            // 
            this.UrlTb.Location = new System.Drawing.Point(137, 136);
            this.UrlTb.Name = "UrlTb";
            this.UrlTb.Size = new System.Drawing.Size(391, 20);
            this.UrlTb.TabIndex = 1;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(549, 136);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(152, 22);
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-2, 61);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 393);
            this.webBrowser1.TabIndex = 3;
            // 
            // UrlTb2
            // 
            this.UrlTb2.Location = new System.Drawing.Point(153, 22);
            this.UrlTb2.Name = "UrlTb2";
            this.UrlTb2.Size = new System.Drawing.Size(401, 20);
            this.UrlTb2.TabIndex = 5;
            // 
            // UrlLb2
            // 
            this.UrlLb2.AutoSize = true;
            this.UrlLb2.BackColor = System.Drawing.Color.Snow;
            this.UrlLb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrlLb2.Location = new System.Drawing.Point(86, 21);
            this.UrlLb2.Name = "UrlLb2";
            this.UrlLb2.Size = new System.Drawing.Size(42, 18);
            this.UrlLb2.TabIndex = 6;
            this.UrlLb2.Text = "URL:";
            // 
            // ConnectBtn2
            // 
            this.ConnectBtn2.BackColor = System.Drawing.Color.Snow;
            this.ConnectBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn2.Location = new System.Drawing.Point(590, 22);
            this.ConnectBtn2.Name = "ConnectBtn2";
            this.ConnectBtn2.Size = new System.Drawing.Size(123, 23);
            this.ConnectBtn2.TabIndex = 7;
            this.ConnectBtn2.Text = "CONNECT";
            this.ConnectBtn2.UseVisualStyleBackColor = false;
            this.ConnectBtn2.Click += new System.EventHandler(this.ConnectBtn2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogInPage.Properties.Resources.tasarım11;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 62);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // OnlineMeetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConnectBtn2);
            this.Controls.Add(this.UrlLb2);
            this.Controls.Add(this.UrlTb2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.UrlTb);
            this.Controls.Add(this.UrlLb);
            this.Name = "OnlineMeetingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnlineMeetingPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UrlLb;
        private System.Windows.Forms.TextBox UrlTb;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UrlTb2;
        private System.Windows.Forms.Label UrlLb2;
        private System.Windows.Forms.Button ConnectBtn2;
    }
}