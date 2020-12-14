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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Wachtwoord_txt = new System.Windows.Forms.TextBox();
            this.Wacht_vergeten_Link_Label = new System.Windows.Forms.LinkLabel();
            this.Login_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(350, 353);
            this.label1.MinimumSize = new System.Drawing.Size(300, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 15;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.panel3.Controls.Add(this.Email_txt);
            this.panel3.Location = new System.Drawing.Point(310, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.MaximumSize = new System.Drawing.Size(380, 39);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(380, 39);
            this.panel3.TabIndex = 13;
            // 
            // Email_txt
            // 
            this.Email_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_txt.BackColor = System.Drawing.Color.White;
            this.Email_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Email_txt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Email_txt.Location = new System.Drawing.Point(3, 4);
            this.Email_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Email_txt.MaxLength = 40;
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(373, 30);
            this.Email_txt.TabIndex = 4;
            this.Email_txt.Text = "Email...";
            this.Email_txt.Enter += new System.EventHandler(this.EmailRemovePlaceHolder);
            this.Email_txt.Leave += new System.EventHandler(this.EmailAddPlaceHolder);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.Wachtwoord_txt);
            this.panel2.Location = new System.Drawing.Point(310, 195);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.MaximumSize = new System.Drawing.Size(380, 39);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(380, 39);
            this.panel2.TabIndex = 14;
            // 
            // Wachtwoord_txt
            // 
            this.Wachtwoord_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wachtwoord_txt.BackColor = System.Drawing.Color.White;
            this.Wachtwoord_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wachtwoord_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Wachtwoord_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Wachtwoord_txt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Wachtwoord_txt.Location = new System.Drawing.Point(3, 4);
            this.Wachtwoord_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Wachtwoord_txt.Name = "Wachtwoord_txt";
            this.Wachtwoord_txt.Size = new System.Drawing.Size(373, 30);
            this.Wachtwoord_txt.TabIndex = 4;
            this.Wachtwoord_txt.Text = "Wachtwoord...";
            this.Wachtwoord_txt.Enter += new System.EventHandler(this.WachtwoordRemovePlaceHolder);
            this.Wachtwoord_txt.Leave += new System.EventHandler(this.WachtwoordAddPlaceHolder);
            // 
            // Wacht_vergeten_Link_Label
            // 
            this.Wacht_vergeten_Link_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Wacht_vergeten_Link_Label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.Wacht_vergeten_Link_Label.Location = new System.Drawing.Point(310, 250);
            this.Wacht_vergeten_Link_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wacht_vergeten_Link_Label.Name = "Wacht_vergeten_Link_Label";
            this.Wacht_vergeten_Link_Label.Size = new System.Drawing.Size(380, 24);
            this.Wacht_vergeten_Link_Label.TabIndex = 12;
            this.Wacht_vergeten_Link_Label.TabStop = true;
            this.Wacht_vergeten_Link_Label.Text = "Wachtwoord vergeten?";
            this.Wacht_vergeten_Link_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Wacht_vergeten_Link_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Wacht_vergeten_Link_Label_LinkClicked);
            // 
            // Login_btn
            // 
            this.Login_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Login_btn.FlatAppearance.BorderSize = 3;
            this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(130)))), ((int)(((byte)(90)))));
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(310, 280);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Login_btn.MinimumSize = new System.Drawing.Size(0, 47);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(380, 47);
            this.Login_btn.TabIndex = 11;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.panel1.Location = new System.Drawing.Point(-15, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 68);
            this.panel1.TabIndex = 16;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Wacht_vergeten_Link_Label);
            this.Controls.Add(this.Login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 450);
            this.Name = "Login";
            this.Text = "Login";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Wachtwoord_txt;
        private System.Windows.Forms.LinkLabel Wacht_vergeten_Link_Label;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Panel panel1;
    }
}