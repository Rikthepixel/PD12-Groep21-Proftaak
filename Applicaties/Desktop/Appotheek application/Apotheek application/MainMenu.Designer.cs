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
            this.Producten_Overzicht_btn = new System.Windows.Forms.Button();
            this.Bestellen_btn = new System.Windows.Forms.Button();
            this.Help_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.User_label = new System.Windows.Forms.Label();
            this.Uitloggen_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Producten_Overzicht_btn
            // 
            this.Producten_Overzicht_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Producten_Overzicht_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Producten_Overzicht_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.Producten_Overzicht_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(91)))), ((int)(((byte)(65)))));
            this.Producten_Overzicht_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Producten_Overzicht_btn.Location = new System.Drawing.Point(44, 238);
            this.Producten_Overzicht_btn.Name = "Producten_Overzicht_btn";
            this.Producten_Overzicht_btn.Size = new System.Drawing.Size(116, 25);
            this.Producten_Overzicht_btn.TabIndex = 0;
            this.Producten_Overzicht_btn.Text = "Producten Overzicht";
            this.Producten_Overzicht_btn.UseVisualStyleBackColor = false;
            this.Producten_Overzicht_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bestellen_btn
            // 
            this.Bestellen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bestellen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Bestellen_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Bestellen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bestellen_btn.Location = new System.Drawing.Point(66, 306);
            this.Bestellen_btn.Name = "Bestellen_btn";
            this.Bestellen_btn.Size = new System.Drawing.Size(62, 25);
            this.Bestellen_btn.TabIndex = 1;
            this.Bestellen_btn.Text = "Bestellen";
            this.Bestellen_btn.UseVisualStyleBackColor = false;
            this.Bestellen_btn.Click += new System.EventHandler(this.Bestellen_btn_Click);
            // 
            // Help_btn
            // 
            this.Help_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Help_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Help_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Help_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_btn.Location = new System.Drawing.Point(75, 369);
            this.Help_btn.Name = "Help_btn";
            this.Help_btn.Size = new System.Drawing.Size(53, 25);
            this.Help_btn.TabIndex = 3;
            this.Help_btn.Text = "Help";
            this.Help_btn.UseVisualStyleBackColor = false;
            this.Help_btn.Click += new System.EventHandler(this.Help_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Help_btn);
            this.panel1.Controls.Add(this.User_label);
            this.panel1.Controls.Add(this.Uitloggen_btn);
            this.panel1.Controls.Add(this.Bestellen_btn);
            this.panel1.Controls.Add(this.Producten_Overzicht_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 468);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // User_label
            // 
            this.User_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_label.BackColor = System.Drawing.Color.White;
            this.User_label.Location = new System.Drawing.Point(53, 126);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(84, 13);
            this.User_label.TabIndex = 5;
            this.User_label.Text = "Student Student";
            this.User_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Uitloggen_btn
            // 
            this.Uitloggen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Uitloggen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Uitloggen_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(99)))));
            this.Uitloggen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uitloggen_btn.Location = new System.Drawing.Point(64, 181);
            this.Uitloggen_btn.Name = "Uitloggen_btn";
            this.Uitloggen_btn.Size = new System.Drawing.Size(64, 25);
            this.Uitloggen_btn.TabIndex = 2;
            this.Uitloggen_btn.Text = "Uitloggen";
            this.Uitloggen_btn.UseVisualStyleBackColor = false;
            this.Uitloggen_btn.Click += new System.EventHandler(this.Uitloggen_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(194, 429);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(210, 468);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Producten_Overzicht_btn;
        private System.Windows.Forms.Button Bestellen_btn;
        private System.Windows.Forms.Button Help_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Uitloggen_btn;
        private System.Windows.Forms.Label User_label;
    }
}

