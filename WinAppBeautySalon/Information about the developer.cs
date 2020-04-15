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
    public partial class FormInformationAboutTheDeveloper : Form
    {
        public FormInformationAboutTheDeveloper()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Отображение формы в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormInformationAboutTheDeveloper_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.ShowDialog();
            this.Hide();
        }
    }
}
