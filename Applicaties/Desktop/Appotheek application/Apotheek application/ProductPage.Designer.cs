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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.Bestellen = new System.Windows.Forms.Button();
            this.EersteLevering = new System.Windows.Forms.Label();
            this.Leverancier = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Naam = new System.Windows.Forms.Label();
            this.TotaalGewicht = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SearchBarPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxSearch.Location = new System.Drawing.Point(7, 6);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(280, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aantalDataGridViewTextBoxColumn,
            this.gewichtDataGridViewTextBoxColumn,
            this.datumOntvangenDataGridViewTextBoxColumn,
            this.uitersteDatumDataGridViewTextBoxColumn,
            this.ExtraInfo});
            this.dataGridView1.DataSource = this.productBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 318);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // aantalDataGridViewTextBoxColumn
            // 
            this.aantalDataGridViewTextBoxColumn.DataPropertyName = "aantal";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.aantalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.aantalDataGridViewTextBoxColumn.FillWeight = 119.6043F;
            this.aantalDataGridViewTextBoxColumn.HeaderText = "aantal";
            this.aantalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aantalDataGridViewTextBoxColumn.Name = "aantalDataGridViewTextBoxColumn";
            this.aantalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gewichtDataGridViewTextBoxColumn
            // 
            this.gewichtDataGridViewTextBoxColumn.DataPropertyName = "Gewicht";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.gewichtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.gewichtDataGridViewTextBoxColumn.FillWeight = 119.6043F;
            this.gewichtDataGridViewTextBoxColumn.HeaderText = "Gewicht";
            this.gewichtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gewichtDataGridViewTextBoxColumn.Name = "gewichtDataGridViewTextBoxColumn";
            this.gewichtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumOntvangenDataGridViewTextBoxColumn
            // 
            this.datumOntvangenDataGridViewTextBoxColumn.DataPropertyName = "Datum_Ontvangen";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.datumOntvangenDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.datumOntvangenDataGridViewTextBoxColumn.FillWeight = 119.6043F;
            this.datumOntvangenDataGridViewTextBoxColumn.HeaderText = "Datum Ontvangen";
            this.datumOntvangenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumOntvangenDataGridViewTextBoxColumn.Name = "datumOntvangenDataGridViewTextBoxColumn";
            this.datumOntvangenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uitersteDatumDataGridViewTextBoxColumn
            // 
            this.uitersteDatumDataGridViewTextBoxColumn.DataPropertyName = "Uiterste_Datum";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(100)))));
            this.uitersteDatumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.uitersteDatumDataGridViewTextBoxColumn.FillWeight = 119.6043F;
            this.uitersteDatumDataGridViewTextBoxColumn.HeaderText = "Uiterste Datum";
            this.uitersteDatumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uitersteDatumDataGridViewTextBoxColumn.Name = "uitersteDatumDataGridViewTextBoxColumn";
            this.uitersteDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.FillWeight = 119.6043F;
            this.ExtraInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtraInfo.HeaderText = "Info";
            this.ExtraInfo.MinimumWidth = 6;
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
            this.SearchBar.BackColor = System.Drawing.SystemColors.Control;
            this.SearchBar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(51, 71);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(75, 16);
            this.SearchBar.TabIndex = 2;
            this.SearchBar.Text = "SearchBar";
            // 
            // SearchBarPanel
            // 
            this.SearchBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.SearchBarPanel.Controls.Add(this.textBoxSearch);
            this.SearchBarPanel.Location = new System.Drawing.Point(47, 90);
            this.SearchBarPanel.Name = "SearchBarPanel";
            this.SearchBarPanel.Size = new System.Drawing.Size(295, 32);
            this.SearchBarPanel.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PageForm";
            this.dataGridViewTextBoxColumn1.HeaderText = "PageForm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.Bestellen);
            this.panel1.Controls.Add(this.EersteLevering);
            this.panel1.Controls.Add(this.Leverancier);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Naam);
            this.panel1.Controls.Add(this.TotaalGewicht);
            this.panel1.Location = new System.Drawing.Point(649, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 105);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.X.FlatAppearance.BorderSize = 0;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Location = new System.Drawing.Point(3, 3);
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
            this.Bestellen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(196)))), ((int)(((byte)(160)))));
            this.Bestellen.FlatAppearance.BorderSize = 0;
            this.Bestellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bestellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Bestellen.Location = new System.Drawing.Point(168, 74);
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
            this.EersteLevering.Location = new System.Drawing.Point(166, 48);
            this.EersteLevering.Name = "EersteLevering";
            this.EersteLevering.Size = new System.Drawing.Size(139, 13);
            this.EersteLevering.TabIndex = 4;
            this.EersteLevering.Text = "Eerste Levering: 10/8/2018";
            this.EersteLevering.Visible = false;
            // 
            // Leverancier
            // 
            this.Leverancier.AutoSize = true;
            this.Leverancier.Location = new System.Drawing.Point(166, 18);
            this.Leverancier.Name = "Leverancier";
            this.Leverancier.Size = new System.Drawing.Size(144, 13);
            this.Leverancier.TabIndex = 3;
            this.Leverancier.Text = "Leverancier: Mosadex Groep";
            this.Leverancier.Visible = false;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(29, 78);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(82, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "Type: Tabletten";
            this.Type.Visible = false;
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(29, 18);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(72, 13);
            this.Naam.TabIndex = 1;
            this.Naam.Text = "Naam: Xanac";
            this.Naam.Visible = false;
            // 
            // TotaalGewicht
            // 
            this.TotaalGewicht.AutoSize = true;
            this.TotaalGewicht.Location = new System.Drawing.Point(29, 48);
            this.TotaalGewicht.Name = "TotaalGewicht";
            this.TotaalGewicht.Size = new System.Drawing.Size(103, 13);
            this.TotaalGewicht.TabIndex = 0;
            this.TotaalGewicht.Text = "Totaal Gewicht: 540";
            this.TotaalGewicht.Visible = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(119)))), ((int)(((byte)(87)))));
            this.RefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Location = new System.Drawing.Point(12, 90);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(30, 32);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // productListBindingSource
            // 
            this.productListBindingSource.DataSource = typeof(Appotheekcl.ProductList);
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SearchBar);
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bestellen;
        private System.Windows.Forms.Label EersteLevering;
        private System.Windows.Forms.Label Leverancier;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label TotaalGewicht;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aantalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gewichtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOntvangenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uitersteDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ExtraInfo;
    }
}