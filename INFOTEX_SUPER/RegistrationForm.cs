using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOTEX_SUPER
{
    public partial class RegistrationForm : Form
    {
        private Form _loginForm;

        public RegistrationForm(Form loginForm)
        {
            InitializeComponent();

            _loginForm = loginForm;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            accountsBindingSource.AddNew();
            account_type_numberTextBox.Text = "1";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.accountsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(oOO_INFOTEXDataSet);

                this.Close();
                _loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Что-то пошло не так");
            }
        }
    }
}
