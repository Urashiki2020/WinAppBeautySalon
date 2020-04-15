using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppBeautySalon
{
    public partial class FormManufacturers : Form
    {
        public FormManufacturers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Отображение формы в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.masterDataSet.Manufacturer);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            manufacturerTableAdapter.Update(masterDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.ShowDialog();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            MessageBox.Show("Запись удалена из базы данных");
        }
    }
}
