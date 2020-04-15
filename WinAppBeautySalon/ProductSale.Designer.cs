namespace WinAppBeautySalon
{
    partial class FormProductSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductSale));
            this.pictureBoxBeautySalon3 = new System.Windows.Forms.PictureBox();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.buttonDelete2 = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new WinAppBeautySalon.masterDataSet();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSaleTableAdapter = new WinAppBeautySalon.masterDataSetTableAdapters.ProductSaleTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientServiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeautySalon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBeautySalon3
            // 
            this.pictureBoxBeautySalon3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBeautySalon3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBeautySalon3.Image")));
            this.pictureBoxBeautySalon3.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBeautySalon3.Name = "pictureBoxBeautySalon3";
            this.pictureBoxBeautySalon3.Size = new System.Drawing.Size(694, 101);
            this.pictureBoxBeautySalon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBeautySalon3.TabIndex = 9;
            this.pictureBoxBeautySalon3.TabStop = false;
            // 
            // buttonBack2
            // 
            this.buttonBack2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack2.Location = new System.Drawing.Point(542, 330);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(140, 40);
            this.buttonBack2.TabIndex = 12;
            this.buttonBack2.Text = "Назад";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // buttonDelete2
            // 
            this.buttonDelete2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete2.Location = new System.Drawing.Point(218, 330);
            this.buttonDelete2.Name = "buttonDelete2";
            this.buttonDelete2.Size = new System.Drawing.Size(200, 30);
            this.buttonDelete2.TabIndex = 11;
            this.buttonDelete2.Text = "Удалить запись";
            this.buttonDelete2.UseVisualStyleBackColor = true;
            this.buttonDelete2.Click += new System.EventHandler(this.buttonDelete2_Click);
            // 
            // buttonSave2
            // 
            this.buttonSave2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave2.Location = new System.Drawing.Point(12, 330);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(200, 30);
            this.buttonSave2.TabIndex = 10;
            this.buttonSave2.Text = "Сохранить запись";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.clientServiceIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productSaleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 217);
            this.dataGridView1.TabIndex = 13;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataMember = "ProductSale";
            this.productSaleBindingSource.DataSource = this.masterDataSet;
            // 
            // productSaleTableAdapter
            // 
            this.productSaleTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // clientServiceIDDataGridViewTextBoxColumn
            // 
            this.clientServiceIDDataGridViewTextBoxColumn.DataPropertyName = "ClientServiceID";
            this.clientServiceIDDataGridViewTextBoxColumn.HeaderText = "ClientServiceID";
            this.clientServiceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientServiceIDDataGridViewTextBoxColumn.Name = "clientServiceIDDataGridViewTextBoxColumn";
            // 
            // FormProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.buttonDelete2);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.pictureBoxBeautySalon3);
            this.Name = "FormProductSale";
            this.Text = "Проданные продукты";
            this.Load += new System.EventHandler(this.FormProductSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeautySalon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBeautySalon3;
        private System.Windows.Forms.Button buttonBack2;
        private System.Windows.Forms.Button buttonDelete2;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private masterDataSetTableAdapters.ProductSaleTableAdapter productSaleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientServiceIDDataGridViewTextBoxColumn;
    }
}