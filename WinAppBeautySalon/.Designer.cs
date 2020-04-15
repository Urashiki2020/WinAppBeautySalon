namespace WinAppBeautySalon
{
    partial class FormInformationAboutTheDeveloper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformationAboutTheDeveloper));
            this.labelInformationAboutTheDeveloper = new System.Windows.Forms.Label();
            this.labelAboutTheProgram = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonBack3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInformationAboutTheDeveloper
            // 
            this.labelInformationAboutTheDeveloper.AutoSize = true;
            this.labelInformationAboutTheDeveloper.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformationAboutTheDeveloper.Location = new System.Drawing.Point(372, 12);
            this.labelInformationAboutTheDeveloper.Name = "labelInformationAboutTheDeveloper";
            this.labelInformationAboutTheDeveloper.Size = new System.Drawing.Size(389, 29);
            this.labelInformationAboutTheDeveloper.TabIndex = 0;
            this.labelInformationAboutTheDeveloper.Text = "Информация о разработчике:";
            // 
            // labelAboutTheProgram
            // 
            this.labelAboutTheProgram.AutoSize = true;
            this.labelAboutTheProgram.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutTheProgram.Location = new System.Drawing.Point(473, 236);
            this.labelAboutTheProgram.Name = "labelAboutTheProgram";
            this.labelAboutTheProgram.Size = new System.Drawing.Size(175, 29);
            this.labelAboutTheProgram.TabIndex = 1;
            this.labelAboutTheProgram.Text = "О программе";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(311, 279);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 91);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Программа предназначена для автоматизации и ведения учета работы салона красоты\"Б" +
    "ровушка\".";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(271, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(561, 136);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Автор ПО: Валеев Рустам Расульевич\r\nСпециальность: \"Прикладная информатика (по от" +
    "раслям)\"\r\nПочта разработчика: \"yungxrist1995@mail.ru\".\r\n\r\n";
            // 
            // buttonBack3
            // 
            this.buttonBack3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack3.Location = new System.Drawing.Point(692, 409);
            this.buttonBack3.Name = "buttonBack3";
            this.buttonBack3.Size = new System.Drawing.Size(140, 40);
            this.buttonBack3.TabIndex = 5;
            this.buttonBack3.Text = "Назад";
            this.buttonBack3.UseVisualStyleBackColor = true;
            this.buttonBack3.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // FormInformationAboutTheDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.buttonBack3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAboutTheProgram);
            this.Controls.Add(this.labelInformationAboutTheDeveloper);
            this.Name = "FormInformationAboutTheDeveloper";
            this.Text = "Информация о разработчике";
            this.Load += new System.EventHandler(this.FormInformationAboutTheDeveloper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformationAboutTheDeveloper;
        private System.Windows.Forms.Label labelAboutTheProgram;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonBack3;
    }
}