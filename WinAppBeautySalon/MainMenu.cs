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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Отображение формы в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit1_Click(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
            this.Hide();
        }

        private void buttonManufacturers_Click(object sender, EventArgs e)
        {
            FormManufacturers formManufacturers = new FormManufacturers();
            formManufacturers.ShowDialog();
            this.Hide();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.ShowDialog();
            this.Hide();
        }

        private void buttonProductSale_Click(object sender, EventArgs e)
        {
            FormProductSale formProductSale = new FormProductSale();
            formProductSale.ShowDialog();
            this.Hide();
        }

        private void buttonInformationAboutTheDeveloper_Click(object sender, EventArgs e)
        {
            FormInformationAboutTheDeveloper formInformationAboutTheDeveloper = new FormInformationAboutTheDeveloper();
            formInformationAboutTheDeveloper.ShowDialog();
            this.Hide();
        }
    }
}
