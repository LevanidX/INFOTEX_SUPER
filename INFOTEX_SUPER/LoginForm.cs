using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOTEX_SUPER
{
    public partial class LoginForm : Form
    {
        private SqlFunctions _sqlFunctions = new SqlFunctions();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(this);
            registrationForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = _sqlFunctions.ExecuteSqlCommand(
                    $"SELECT account_id, account_fullname, account_type_number " +
                    $"FROM accounts " +
                    $"WHERE account_login = '{loginTextBox.Text}' " +
                    $"AND account_password = '{passwordTextBox.Text}'");

                UserConfig.UserID = (int)dt.Rows[0][0];
                UserConfig.UserFullName = dt.Rows[0][1].ToString();
                UserConfig.UserTypeNumber = (int)dt.Rows[0][2];

                if (UserConfig.UserTypeNumber == 1)
                {
                    var clientMenu = new ClientMenu();
                    clientMenu.Show();
                    this.Hide();
                }
                else
                {
                    // тут сотрудник
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Пароль или логин неверный!");
            }
        }
    }
}
