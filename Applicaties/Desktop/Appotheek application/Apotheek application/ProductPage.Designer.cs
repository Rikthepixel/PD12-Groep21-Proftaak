namespace Apotheek_application
{
    partial class ProductPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aantalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gewichtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOntvangenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uitersteDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchBar = new System.Windows.Forms.Label();
            this.SearchBarPanel = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.Bestellen = new System.Windows.Forms.Button();
            this.EersteLevering = new System.Windows.Forms.Label();
            this.Leverancier = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Naam = new System.Windows.Forms.Label();
            this.TotaalGewicht = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SearchBarPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 7);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(292, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aantalDataGridViewTextBoxColumn,
            this.gewichtDataGridViewTextBoxColumn,
            this.datumOntvangenDataGridViewTextBoxColumn,
            this.uitersteDatumDataGridViewTextBoxColumn,
            this.ExtraInfo});
            this.dataGridView1.DataSource = this.productBindingSource;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 324);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // aantalDataGridViewTextBoxColumn
            // 
            this.aantalDataGridViewTextBoxColumn.DataPropertyName = "aantal";
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.aantalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.aantalDataGridViewTextBoxColumn.HeaderText = "aantal";
            this.aantalDataGridViewTextBoxColumn.Name = "aantalDataGridViewTextBoxColumn";
            this.aantalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gewichtDataGridViewTextBoxColumn
            // 
            this.gewichtDataGridViewTextBoxColumn.DataPropertyName = "Gewicht";
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.gewichtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle28;
            this.gewichtDataGridViewTextBoxColumn.HeaderText = "Gewicht";
            this.gewichtDataGridViewTextBoxColumn.Name = "gewichtDataGridViewTextBoxColumn";
            this.gewichtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumOntvangenDataGridViewTextBoxColumn
            // 
            this.datumOntvangenDataGridViewTextBoxColumn.DataPropertyName = "Datum_Ontvangen";
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.datumOntvangenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle29;
            this.datumOntvangenDataGridViewTextBoxColumn.HeaderText = "Datum Ontvangen";
            this.datumOntvangenDataGridViewTextBoxColumn.Name = "datumOntvangenDataGridViewTextBoxColumn";
            this.datumOntvangenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uitersteDatumDataGridViewTextBoxColumn
            // 
            this.uitersteDatumDataGridViewTextBoxColumn.DataPropertyName = "Uiterste_Datum";
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.uitersteDatumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle30;
            this.uitersteDatumDataGridViewTextBoxColumn.HeaderText = "Uiterste Datum";
            this.uitersteDatumDataGridViewTextBoxColumn.Name = "uitersteDatumDataGridViewTextBoxColumn";
            this.uitersteDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtraInfo.HeaderText = "Info";
            this.ExtraInfo.Name = "ExtraInfo";
            this.ExtraInfo.ReadOnly = true;
            this.ExtraInfo.Text = "+";
            this.ExtraInfo.UseColumnTextForButtonValue = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Appotheekcl.Product);
            // 
            // SearchBar
            // 
            this.SearchBar.AutoSize = true;
            this.SearchBar.BackColor = System.Drawing.Color.White;
            this.SearchBar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(15, 71);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(75, 16);
            this.SearchBar.TabIndex = 2;
            this.SearchBar.Text = "SearchBar";
            // 
            // SearchBarPanel
            // 
            this.SearchBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.SearchBarPanel.Controls.Add(this.textBoxSearch);
            this.SearchBarPanel.Location = new System.Drawing.Point(15, 90);
            this.SearchBarPanel.Name = "SearchBarPanel";
            this.SearchBarPanel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.SearchBarPanel.Size = new System.Drawing.Size(302, 34);
            this.SearchBarPanel.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PageForm";
            this.dataGridViewTextBoxColumn1.HeaderText = "PageForm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 318);
            this.panel2.TabIndex = 4;
            // 
            // productListBindingSource
            // 
            this.productListBindingSource.DataSource = typeof(Appotheekcl.ProductList);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.Bestellen);
            this.panel1.Controls.Add(this.EersteLevering);
            this.panel1.Controls.Add(this.Leverancier);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Naam);
            this.panel1.Controls.Add(this.TotaalGewicht);
            this.panel1.Location = new System.Drawing.Point(579, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 105);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Red;
            this.X.Location = new System.Drawing.Point(0, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(20, 20);
            this.X.TabIndex = 6;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Visible = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Bestellen
            // 
            this.Bestellen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(70)))));
            this.Bestellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Bestellen.Location = new System.Drawing.Point(212, 67);
            this.Bestellen.Name = "Bestellen";
            this.Bestellen.Size = new System.Drawing.Size(136, 23);
            this.Bestellen.TabIndex = 5;
            this.Bestellen.Text = "Bestellen";
            this.Bestellen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bestellen.UseVisualStyleBackColor = false;
            this.Bestellen.Visible = false;
            this.Bestellen.Click += new System.EventHandler(this.Bestellen_Click);
            // 
            // EersteLevering
            // 
            this.EersteLevering.AutoSize = true;
            this.EersteLevering.Location = new System.Drawing.Point(209, 48);
            this.EersteLevering.Name = "EersteLevering";
            this.EersteLevering.Size = new System.Drawing.Size(139, 13);
            this.EersteLevering.TabIndex = 4;
            this.EersteLevering.Text = "Eerste Levering: 10/8/2018";
            this.EersteLevering.Visible = false;
            // 
            // Leverancier
            // 
            this.Leverancier.AutoSize = true;
            this.Leverancier.Location = new System.Drawing.Point(209, 18);
            this.Leverancier.Name = "Leverancier";
            this.Leverancier.Size = new System.Drawing.Size(144, 13);
            this.Leverancier.TabIndex = 3;
            this.Leverancier.Text = "Leverancier: Mosadex Groep";
            this.Leverancier.Visible = false;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(21, 78);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(82, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "Type: Tabletten";
            this.Type.Visible = false;
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(21, 18);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(72, 13);
            this.Naam.TabIndex = 1;
            this.Naam.Text = "Naam: Xanac";
            this.Naam.Visible = false;
            // 
            // TotaalGewicht
            // 
            this.TotaalGewicht.AutoSize = true;
            this.TotaalGewicht.Location = new System.Drawing.Point(21, 48);
            this.TotaalGewicht.Name = "TotaalGewicht";
            this.TotaalGewicht.Size = new System.Drawing.Size(103, 13);
            this.TotaalGewicht.TabIndex = 0;
            this.TotaalGewicht.Text = "Totaal Gewicht: 540";
            this.TotaalGewicht.Visible = false;
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SearchBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductPage_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.SearchBarPanel.ResumeLayout(false);
            this.SearchBarPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SearchBar;
        private System.Windows.Forms.Panel SearchBarPanel;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aantalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gewichtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOntvangenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uitersteDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ExtraInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bestellen;
        private System.Windows.Forms.Label EersteLevering;
        private System.Windows.Forms.Label Leverancier;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label TotaalGewicht;
        private System.Windows.Forms.Button X;
    }
}