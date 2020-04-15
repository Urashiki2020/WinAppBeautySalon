namespace WinAppBeautySalon
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.pictureBoxBeautySalon3 = new System.Windows.Forms.PictureBox();
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.buttonSave1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masterDataSet = new WinAppBeautySalon.masterDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WinAppBeautySalon.masterDataSetTableAdapters.ProductTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeautySalon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBeautySalon3
            // 
            this.pictureBoxBeautySalon3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBeautySalon3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBeautySalon3.Image")));
            this.pictureBoxBeautySalon3.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBeautySalon3.Name = "pictureBoxBeautySalon3";
            this.pictureBoxBeautySalon3.Size = new System.Drawing.Size(800, 101);
            this.pictureBoxBeautySalon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBeautySalon3.TabIndex = 8;
            this.pictureBoxBeautySalon3.TabStop = false;
            // 
            // buttonBack1
            // 
            this.buttonBack1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack1.Location = new System.Drawing.Point(648, 320);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(140, 40);
            this.buttonBack1.TabIndex = 11;
            this.buttonBack1.Text = "Назад";
            this.buttonBack1.UseVisualStyleBackColor = true;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_Click);
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete1.Location = new System.Drawing.Point(576, 278);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(200, 30);
            this.buttonDelete1.TabIndex = 10;
            this.buttonDelete1.Text = "Удалить запись";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
            // 
            // buttonSave1
            // 
            this.buttonSave1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave1.Location = new System.Drawing.Point(25, 278);
            this.buttonSave1.Name = "buttonSave1";
            this.buttonSave1.Size = new System.Drawing.Size(200, 30);
            this.buttonSave1.TabIndex = 9;
            this.buttonSave1.Text = "Сохранить запись";
            this.buttonSave1.UseVisualStyleBackColor = true;
            this.buttonSave1.Click += new System.EventHandler(this.buttonSave1_Click);
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
            this.titleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.mainImagePathDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.manufacturerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 165);
            this.dataGridView1.TabIndex = 12;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.masterDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // mainImagePathDataGridViewTextBoxColumn
            // 
            this.mainImagePathDataGridViewTextBoxColumn.DataPropertyName = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.HeaderText = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mainImagePathDataGridViewTextBoxColumn.Name = "mainImagePathDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // manufacturerIDDataGridViewTextBoxColumn
            // 
            this.manufacturerIDDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.HeaderText = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerIDDataGridViewTextBoxColumn.Name = "manufacturerIDDataGridViewTextBoxColumn";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.buttonDelete1);
            this.Controls.Add(this.buttonSave1);
            this.Controls.Add(this.pictureBoxBeautySalon3);
            this.Name = "FormProducts";
            this.Text = "Продукты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeautySalon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBeautySalon3;
        private System.Windows.Forms.Button buttonBack1;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button buttonSave1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private masterDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIDDataGridViewTextBoxColumn;
    }
}