namespace Apotheek_application
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Wachtwoord_txt = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wacht_vergeten_Link_Label = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Wacht_vergeten_Link_Label);
            this.panel1.Controls.Add(this.Login_btn);
            this.panel1.Controls.Add(this.Wachtwoord_txt);
            this.panel1.Controls.Add(this.Email_txt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(210, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 468);
            this.panel1.TabIndex = 1;
            // 
            // Email_txt
            // 
            this.Email_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_txt.BackColor = System.Drawing.SystemColors.Window;
            this.Email_txt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Email_txt.Location = new System.Drawing.Point(47, 171);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(100, 20);
            this.Email_txt.TabIndex = 3;
            this.Email_txt.Text = "E-mail address...";
            // 
            // Wachtwoord_txt
            // 
            this.Wachtwoord_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wachtwoord_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wachtwoord_txt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Wachtwoord_txt.Location = new System.Drawing.Point(47, 208);
            this.Wachtwoord_txt.Name = "Wachtwoord_txt";
            this.Wachtwoord_txt.Size = new System.Drawing.Size(100, 20);
            this.Wachtwoord_txt.TabIndex = 4;
            this.Wachtwoord_txt.Text = "Wachtwoord...";
            // 
            // Login_btn
            // 
            this.Login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_btn.Location = new System.Drawing.Point(60, 277);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Wacht_vergeten_Link_Label
            // 
            this.Wacht_vergeten_Link_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wacht_vergeten_Link_Label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.Wacht_vergeten_Link_Label.Location = new System.Drawing.Point(44, 242);
            this.Wacht_vergeten_Link_Label.Name = "Wacht_vergeten_Link_Label";
            this.Wacht_vergeten_Link_Label.Size = new System.Drawing.Size(119, 13);
            this.Wacht_vergeten_Link_Label.TabIndex = 7;
            this.Wacht_vergeten_Link_Label.TabStop = true;
            this.Wacht_vergeten_Link_Label.Text = "Wachtwoord vergeten?";
            this.Wacht_vergeten_Link_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Wacht_vergeten_Link_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(194, 429);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(210, 468);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox Wachtwoord_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Wacht_vergeten_Link_Label;
    }
}