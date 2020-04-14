namespace WinAppBeautySalon
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.pictureBoxBeautySalon1 = new System.Windows.Forms.PictureBox();
            this.buttonManufacturers = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonProductSale = new System.Windows.Forms.Button();
            this.buttonInformationAboutTheDeveloper = new System.Windows.Forms.Button();
            this.buttonExit1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeautySalon1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBeautySalon1
            // 
            this.pictureBoxBeautySalon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBeautySalon1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBeautySalon1.Image")));
            this.pictureBoxBeautySalon1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBeautySalon1.Name = "pictureBoxBeautySalon1";
            this.pictureBoxBeautySalon1.Size = new System.Drawing.Size(550, 101);
            this.pictureBoxBeautySalon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBeautySalon1.TabIndex = 8;
            this.pictureBoxBeautySalon1.TabStop = false;
            // 
            // buttonManufacturers
            // 
            this.buttonManufacturers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonManufacturers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManufacturers.Location = new System.Drawing.Point(173, 107);
            this.buttonManufacturers.Name = "buttonManufacturers";
            this.buttonManufacturers.Size = new System.Drawing.Size(200, 40);
            this.buttonManufacturers.TabIndex = 9;
            this.buttonManufacturers.Text = " Производители";
            this.buttonManufacturers.UseVisualStyleBackColor = true;
            // 
            // buttonProducts
            // 
            this.buttonProducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProducts.Location = new System.Drawing.Point(173, 153);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(200, 40);
            this.buttonProducts.TabIndex = 10;
            this.buttonProducts.Text = "Продукты";
            this.buttonProducts.UseVisualStyleBackColor = true;
            // 
            // buttonProductSale
            // 
            this.buttonProductSale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonProductSale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductSale.Location = new System.Drawing.Point(151, 199);
            this.buttonProductSale.Name = "buttonProductSale";
            this.buttonProductSale.Size = new System.Drawing.Size(244, 40);
            this.buttonProductSale.TabIndex = 11;
            this.buttonProductSale.Text = "Проданные продукты";
            this.buttonProductSale.UseVisualStyleBackColor = true;
            // 
            // buttonInformationAboutTheDeveloper
            // 
            this.buttonInformationAboutTheDeveloper.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonInformationAboutTheDeveloper.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInformationAboutTheDeveloper.Location = new System.Drawing.Point(12, 283);
            this.buttonInformationAboutTheDeveloper.Name = "buttonInformationAboutTheDeveloper";
            this.buttonInformationAboutTheDeveloper.Size = new System.Drawing.Size(301, 40);
            this.buttonInformationAboutTheDeveloper.TabIndex = 12;
            this.buttonInformationAboutTheDeveloper.Text = "Информация о разработчике";
            this.buttonInformationAboutTheDeveloper.UseVisualStyleBackColor = true;
            // 
            // buttonExit1
            // 
            this.buttonExit1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonExit1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit1.Location = new System.Drawing.Point(398, 283);
            this.buttonExit1.Name = "buttonExit1";
            this.buttonExit1.Size = new System.Drawing.Size(140, 40);
            this.buttonExit1.TabIndex = 13;
            this.buttonExit1.Text = "Выход";
            this.buttonExit1.UseVisualStyleBackColor = true;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 335);
            this.Controls.Add(this.buttonExit1);
            this.Controls.Add(this.buttonInformationAboutTheDeveloper);
            this.Controls.Add(this.buttonProductSale);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonManufacturers);
            this.Controls.Add(this.pictureBoxBeautySalon1);
            this.Name = "FormMainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeautySalon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBeautySalon1;
        private System.Windows.Forms.Button buttonManufacturers;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonProductSale;
        private System.Windows.Forms.Button buttonInformationAboutTheDeveloper;
        private System.Windows.Forms.Button buttonExit1;
    }
}