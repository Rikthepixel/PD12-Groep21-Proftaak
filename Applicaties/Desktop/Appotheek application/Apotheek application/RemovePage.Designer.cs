
namespace Apotheek_application
{
    partial class RemovePage
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
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_cb = new System.Windows.Forms.ComboBox();
            this.Order_btn = new System.Windows.Forms.Button();
            this.ID_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Aantal_Medicijnen_Verwijderen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aantal_Medicijnen_Verwijderen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BottomPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 366);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Name_cb);
            this.panel2.Controls.Add(this.Order_btn);
            this.panel2.Controls.Add(this.ID_cb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Aantal_Medicijnen_Verwijderen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 324);
            this.panel2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(348, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Name_cb
            // 
            this.Name_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Name_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Name_cb.FormattingEnabled = true;
            this.Name_cb.Location = new System.Drawing.Point(371, 23);
            this.Name_cb.MaxDropDownItems = 100;
            this.Name_cb.Name = "Name_cb";
            this.Name_cb.Size = new System.Drawing.Size(120, 21);
            this.Name_cb.TabIndex = 22;
            this.Name_cb.SelectedIndexChanged += new System.EventHandler(this.ID_cb_SelectedIndexChanged);
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
            this.Order_btn.Location = new System.Drawing.Point(188, 103);
            this.Order_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.Size = new System.Drawing.Size(364, 41);
            this.Order_btn.TabIndex = 0;
            this.Order_btn.Text = "Verwijderen";
            this.Order_btn.UseVisualStyleBackColor = false;
            this.Order_btn.Click += new System.EventHandler(this.Order_btn_Click);
            // 
            // ID_cb
            // 
            this.ID_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ID_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ID_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_cb.FormattingEnabled = true;
            this.ID_cb.Location = new System.Drawing.Point(371, 48);
            this.ID_cb.MaxDropDownItems = 100;
            this.ID_cb.Name = "ID_cb";
            this.ID_cb.Size = new System.Drawing.Size(120, 21);
            this.ID_cb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicijn name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Aantal_Medicijnen_Verwijderen
            // 
            this.Aantal_Medicijnen_Verwijderen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Aantal_Medicijnen_Verwijderen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aantal_Medicijnen_Verwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aantal_Medicijnen_Verwijderen.Location = new System.Drawing.Point(371, 73);
            this.Aantal_Medicijnen_Verwijderen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Aantal_Medicijnen_Verwijderen.Name = "Aantal_Medicijnen_Verwijderen";
            this.Aantal_Medicijnen_Verwijderen.Size = new System.Drawing.Size(120, 20);
            this.Aantal_Medicijnen_Verwijderen.TabIndex = 3;
            this.Aantal_Medicijnen_Verwijderen.ValueChanged += new System.EventHandler(this.Aantal_Medicijnen_Verwijderen_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(324, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aantal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.Location = new System.Drawing.Point(0, 319);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(750, 47);
            this.BottomPanel.TabIndex = 16;
            // 
            // RemovePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(750, 366);
            this.Name = "RemovePage";
            this.Text = "RemovePage";
            this.Load += new System.EventHandler(this.RemovePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aantal_Medicijnen_Verwijderen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Name_cb;
        private System.Windows.Forms.Button Order_btn;
        private System.Windows.Forms.ComboBox ID_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Aantal_Medicijnen_Verwijderen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BottomPanel;
    }
}