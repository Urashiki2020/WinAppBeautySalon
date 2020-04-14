using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace WinAppBeautySalon
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Отображение формы в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUser = textBoxLogin.Text;
                string passwordUser = textBoxPassword.Text;
                Classes.ClassIniDataBase db = new Classes.ClassIniDataBase();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandUser = new SqlCommand("SELECT * FROM [User] WHERE login = @uL AND password = @uP AND role= 'user'", db.GetConnection());
                commandUser.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandUser.Parameters.Add("@uP", SqlDbType.VarChar).Value = passwordUser;
                adapter.SelectCommand = commandUser;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    FormMainMenu formMainMenu = new FormMainMenu();
                    formMainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }


            }
            finally { }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
