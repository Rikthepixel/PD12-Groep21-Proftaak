namespace Apotheek_application
{
    partial class OrderPage
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leverancier_txt = new System.Windows.Forms.TextBox();
            this.Type_medicijn_cb = new System.Windows.Forms.ComboBox();
            this.Naam_Medicijn_txt = new System.Windows.Forms.TextBox();
            this.Add_medicijn_btn = new System.Windows.Forms.Button();
            this.Aantal_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gewicht_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Order_btn = new System.Windows.Forms.Button();
            this.Medicijn_cB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Aantal_Medicijnen_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aantal_Medicijnen_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.leverancier_txt);
            this.panel7.Controls.Add(this.Type_medicijn_cb);
            this.panel7.Controls.Add(this.Naam_Medicijn_txt);
            this.panel7.Controls.Add(this.Add_medicijn_btn);
            this.panel7.Controls.Add(this.Aantal_txt);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.Gewicht_txt);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(0, 309);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1000, 142);
            this.panel7.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(491, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Type Medicijn";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(372, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Leverancier";
            // 
            // leverancier_txt
            // 
            this.leverancier_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leverancier_txt.Location = new System.Drawing.Point(375, 66);
            this.leverancier_txt.Name = "leverancier_txt";
            this.leverancier_txt.Size = new System.Drawing.Size(149, 22);
            this.leverancier_txt.TabIndex = 17;
            // 
            // Type_medicijn_cb
            // 
            this.Type_medicijn_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Type_medicijn_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Type_medicijn_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_medicijn_cb.FormattingEnabled = true;
            this.Type_medicijn_cb.Location = new System.Drawing.Point(494, 65);
            this.Type_medicijn_cb.MaxDropDownItems = 100;
            this.Type_medicijn_cb.Name = "Type_medicijn_cb";
            this.Type_medicijn_cb.Size = new System.Drawing.Size(149, 24);
            this.Type_medicijn_cb.TabIndex = 16;
            this.Type_medicijn_cb.SelectedIndexChanged += new System.EventHandler(this.Type_medicijn_cb_SelectedIndexChanged);
            // 
            // Naam_Medicijn_txt
            // 
            this.Naam_Medicijn_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Naam_Medicijn_txt.Location = new System.Drawing.Point(163, 27);
            this.Naam_Medicijn_txt.Name = "Naam_Medicijn_txt";
            this.Naam_Medicijn_txt.Size = new System.Drawing.Size(132, 22);
            this.Naam_Medicijn_txt.TabIndex = 1;
            // 
            // Add_medicijn_btn
            // 
            this.Add_medicijn_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add_medicijn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.Add_medicijn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_medicijn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_medicijn_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Add_medicijn_btn.Location = new System.Drawing.Point(284, 89);
            this.Add_medicijn_btn.Name = "Add_medicijn_btn";
            this.Add_medicijn_btn.Size = new System.Drawing.Size(247, 28);
            this.Add_medicijn_btn.TabIndex = 13;
            this.Add_medicijn_btn.Text = "Toevoegen";
            this.Add_medicijn_btn.UseVisualStyleBackColor = false;
            this.Add_medicijn_btn.Click += new System.EventHandler(this.Add_medicijn_btn_Click_1);
            // 
            // Aantal_txt
            // 
            this.Aantal_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Aantal_txt.Location = new System.Drawing.Point(163, 65);
            this.Aantal_txt.Name = "Aantal_txt";
            this.Aantal_txt.Size = new System.Drawing.Size(132, 22);
            this.Aantal_txt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(266, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gewicht (in mg)";
            // 
            // Gewicht_txt
            // 
            this.Gewicht_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Gewicht_txt.Location = new System.Drawing.Point(269, 65);
            this.Gewicht_txt.Name = "Gewicht_txt";
            this.Gewicht_txt.Size = new System.Drawing.Size(132, 22);
            this.Gewicht_txt.TabIndex = 4;
            this.Gewicht_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gewicht_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(160, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aantal";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(160, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medicijn naam";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.Order_btn);
            this.panel2.Controls.Add(this.Medicijn_cB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Aantal_Medicijnen_UpDown);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 311);
            this.panel2.TabIndex = 15;
            // 
            // Order_btn
            // 
            this.Order_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Order_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.Order_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Order_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Order_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.Order_btn.FlatAppearance.BorderSize = 2;
            this.Order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Order_btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Order_btn.Location = new System.Drawing.Point(209, 127);
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.Size = new System.Drawing.Size(485, 50);
            this.Order_btn.TabIndex = 0;
            this.Order_btn.Text = "Bestellen";
            this.Order_btn.UseVisualStyleBackColor = false;
            this.Order_btn.Click += new System.EventHandler(this.Order_btn_Click);
            // 
            // Medicijn_cB
            // 
            this.Medicijn_cB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Medicijn_cB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medicijn_cB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Medicijn_cB.FormattingEnabled = true;
            this.Medicijn_cB.Location = new System.Drawing.Point(484, 60);
            this.Medicijn_cB.MaxDropDownItems = 100;
            this.Medicijn_cB.Name = "Medicijn_cB";
            this.Medicijn_cB.Size = new System.Drawing.Size(159, 25);
            this.Medicijn_cB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicijn name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Aantal_Medicijnen_UpDown
            // 
            this.Aantal_Medicijnen_UpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Aantal_Medicijnen_UpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aantal_Medicijnen_UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aantal_Medicijnen_UpDown.Location = new System.Drawing.Point(486, 29);
            this.Aantal_Medicijnen_UpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Aantal_Medicijnen_UpDown.Name = "Aantal_Medicijnen_UpDown";
            this.Aantal_Medicijnen_UpDown.Size = new System.Drawing.Size(157, 23);
            this.Aantal_Medicijnen_UpDown.TabIndex = 3;
            this.Aantal_Medicijnen_UpDown.ValueChanged += new System.EventHandler(this.Aantal_Medicijnen_UpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(361, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 450);
            this.Name = "OrderPage";
            this.Text = "OrderPage";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aantal_Medicijnen_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox Naam_Medicijn_txt;
        private System.Windows.Forms.Button Add_medicijn_btn;
        private System.Windows.Forms.TextBox Aantal_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Gewicht_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Medicijn_cB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Aantal_Medicijnen_UpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Type_medicijn_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leverancier_txt;
        private System.Windows.Forms.Button Order_btn;
        private System.Windows.Forms.Label label7;
    }
}