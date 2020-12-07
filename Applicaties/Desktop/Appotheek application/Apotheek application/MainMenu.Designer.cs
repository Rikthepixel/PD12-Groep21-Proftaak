namespace Apotheek_application
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.User_label = new System.Windows.Forms.Label();
            this.Uitloggen_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Producten_Overzicht_btn = new System.Windows.Forms.Button();
            this.Bestellen_btn = new System.Windows.Forms.Button();
            this.Help_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(-8, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(271, 190);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.Help_btn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(264, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 190);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Logo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 190);
            this.panel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.User_label);
            this.panel2.Controls.Add(this.Uitloggen_btn);
            this.panel2.Location = new System.Drawing.Point(402, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 52);
            this.panel2.TabIndex = 16;
            // 
            // User_label
            // 
            this.User_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_label.BackColor = System.Drawing.Color.White;
            this.User_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.User_label.Location = new System.Drawing.Point(-1, 1);
            this.User_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_label.Name = "User_label";
            this.User_label.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.User_label.Size = new System.Drawing.Size(147, 52);
            this.User_label.TabIndex = 5;
            this.User_label.Text = "Student Student";
            this.User_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Uitloggen_btn
            // 
            this.Uitloggen_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Uitloggen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Uitloggen_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Uitloggen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uitloggen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Uitloggen_btn.Location = new System.Drawing.Point(155, 0);
            this.Uitloggen_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Uitloggen_btn.Name = "Uitloggen_btn";
            this.Uitloggen_btn.Size = new System.Drawing.Size(132, 52);
            this.Uitloggen_btn.TabIndex = 2;
            this.Uitloggen_btn.Text = "Uitloggen";
            this.Uitloggen_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Producten_Overzicht_btn);
            this.panel1.Controls.Add(this.Bestellen_btn);
            this.panel1.Location = new System.Drawing.Point(13, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 52);
            this.panel1.TabIndex = 15;
            // 
            // Producten_Overzicht_btn
            // 
            this.Producten_Overzicht_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Producten_Overzicht_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.Producten_Overzicht_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.Producten_Overzicht_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Producten_Overzicht_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Producten_Overzicht_btn.Location = new System.Drawing.Point(-8, 0);
            this.Producten_Overzicht_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Producten_Overzicht_btn.Name = "Producten_Overzicht_btn";
            this.Producten_Overzicht_btn.Size = new System.Drawing.Size(241, 52);
            this.Producten_Overzicht_btn.TabIndex = 0;
            this.Producten_Overzicht_btn.Text = "Producten Overzicht";
            this.Producten_Overzicht_btn.UseVisualStyleBackColor = false;
            // 
            // Bestellen_btn
            // 
            this.Bestellen_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bestellen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Bestellen_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Bestellen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bestellen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Bestellen_btn.Location = new System.Drawing.Point(241, 0);
            this.Bestellen_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Bestellen_btn.Name = "Bestellen_btn";
            this.Bestellen_btn.Size = new System.Drawing.Size(132, 52);
            this.Bestellen_btn.TabIndex = 1;
            this.Bestellen_btn.Text = "Bestellen";
            this.Bestellen_btn.UseVisualStyleBackColor = false;
            // 
            // Help_btn
            // 
            this.Help_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Help_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_btn.Location = new System.Drawing.Point(557, 49);
            this.Help_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Size = new System.Drawing.Size(132, 32);
            this.Help_btn.TabIndex = 14;
            this.Help_btn.Text = "Help";
            this.Help_btn.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(966, 190);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Button Uitloggen_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Producten_Overzicht_btn;
        private System.Windows.Forms.Button Bestellen_btn;
        private System.Windows.Forms.Button Help_btn;
    }
}

