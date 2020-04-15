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
    public partial class FormProductSale : Form
    {
        public FormProductSale()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Отображение формы в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void FormProductSale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterDataSet.ProductSale". При необходимости она может быть перемещена или удалена.
            this.productSaleTableAdapter.Fill(this.masterDataSet.ProductSale);

        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            productSaleTableAdapter.Update(masterDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.ShowDialog();
            this.Hide();
        }
    }
}
