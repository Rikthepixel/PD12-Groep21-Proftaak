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
            this.BorderColor1 = new System.Windows.Forms.Panel();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.BorderColor2 = new System.Windows.Forms.Panel();
            this.Wachtwoord_txt = new System.Windows.Forms.TextBox();
            this.Wacht_vergeten_Link_Label = new System.Windows.Forms.LinkLabel();
            this.Login_btn = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.BorderColor1.SuspendLayout();
            this.BorderColor2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(262, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MinimumSize = new System.Drawing.Size(225, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 15;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BorderColor1
            // 
            this.BorderColor1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorderColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.BorderColor1.Controls.Add(this.Email_txt);
            this.BorderColor1.Location = new System.Drawing.Point(232, 110);
            this.BorderColor1.Margin = new System.Windows.Forms.Padding(2);
            this.BorderColor1.MaximumSize = new System.Drawing.Size(285, 32);
            this.BorderColor1.MinimumSize = new System.Drawing.Size(0, 31);
            this.BorderColor1.Name = "BorderColor1";
            this.BorderColor1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BorderColor1.Size = new System.Drawing.Size(285, 32);
            this.BorderColor1.TabIndex = 13;
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
            this.Email_txt.Location = new System.Drawing.Point(2, 3);
            this.Email_txt.MaxLength = 40;
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(280, 26);
            this.Email_txt.TabIndex = 4;
            this.Email_txt.Text = "Email...";
            this.Email_txt.Enter += new System.EventHandler(this.EmailRemovePlaceHolder);
            this.Email_txt.Leave += new System.EventHandler(this.EmailAddPlaceHolder);
            // 
            // BorderColor2
            // 
            this.BorderColor2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BorderColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.BorderColor2.Controls.Add(this.Wachtwoord_txt);
            this.BorderColor2.Location = new System.Drawing.Point(232, 158);
            this.BorderColor2.Margin = new System.Windows.Forms.Padding(2);
            this.BorderColor2.MaximumSize = new System.Drawing.Size(285, 32);
            this.BorderColor2.MinimumSize = new System.Drawing.Size(0, 31);
            this.BorderColor2.Name = "BorderColor2";
            this.BorderColor2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BorderColor2.Size = new System.Drawing.Size(285, 32);
            this.BorderColor2.TabIndex = 14;
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
            this.Wachtwoord_txt.Location = new System.Drawing.Point(2, 3);
            this.Wachtwoord_txt.Name = "Wachtwoord_txt";
            this.Wachtwoord_txt.Size = new System.Drawing.Size(280, 26);
            this.Wachtwoord_txt.TabIndex = 4;
            this.Wachtwoord_txt.Text = "Wachtwoord...";
            this.Wachtwoord_txt.Enter += new System.EventHandler(this.WachtwoordRemovePlaceHolder);
            this.Wachtwoord_txt.Leave += new System.EventHandler(this.WachtwoordAddPlaceHolder);
            // 
            // Wacht_vergeten_Link_Label
            // 
            this.Wacht_vergeten_Link_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Wacht_vergeten_Link_Label.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.Wacht_vergeten_Link_Label.Location = new System.Drawing.Point(232, 203);
            this.Wacht_vergeten_Link_Label.Name = "Wacht_vergeten_Link_Label";
            this.Wacht_vergeten_Link_Label.Size = new System.Drawing.Size(285, 20);
            this.Wacht_vergeten_Link_Label.TabIndex = 12;
            this.Wacht_vergeten_Link_Label.TabStop = true;
            this.Wacht_vergeten_Link_Label.Text = "Wachtwoord vergeten?";
            this.Wacht_vergeten_Link_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Wacht_vergeten_Link_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Wacht_vergeten_Link_Label_LinkClicked);
            // 
            // Login_btn
            // 
            this.Login_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(170)))), ((int)(((byte)(120)))));
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.Login_btn.FlatAppearance.BorderSize = 3;
            this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(130)))), ((int)(((byte)(90)))));
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Login_btn.Location = new System.Drawing.Point(232, 228);
            this.Login_btn.MinimumSize = new System.Drawing.Size(0, 38);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(285, 38);
            this.Login_btn.TabIndex = 11;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.BottomPanel.Location = new System.Drawing.Point(-11, 314);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(767, 55);
            this.BottomPanel.TabIndex = 16;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 366);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BorderColor1);
            this.Controls.Add(this.BorderColor2);
            this.Controls.Add(this.Wacht_vergeten_Link_Label);
            this.Controls.Add(this.Login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(750, 366);
            this.Name = "Login";
            this.Text = "Login";
            this.BorderColor1.ResumeLayout(false);
            this.BorderColor1.PerformLayout();
            this.BorderColor2.ResumeLayout(false);
            this.BorderColor2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BorderColor1;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Panel BorderColor2;
        private System.Windows.Forms.TextBox Wachtwoord_txt;
        private System.Windows.Forms.LinkLabel Wacht_vergeten_Link_Label;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Panel BottomPanel;
    }
}