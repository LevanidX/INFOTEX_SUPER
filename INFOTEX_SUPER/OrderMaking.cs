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
    public partial class OrderMaking : Form
    {
        public OrderMaking()
        {
            InitializeComponent();
        }

        private void OrderMaking_Load(object sender, EventArgs e)
        {
            ordersBindingSource.AddNew();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "oOO_INFOTEXDataSet.device_types". При необходимости она может быть перемещена или удалена.
            this.device_typesTableAdapter.Fill(this.oOO_INFOTEXDataSet.device_types);

            order_client_numberTextBox.Text = UserConfig.UserID.ToString();
            order_status_numberTextBox.Text = "1";
            order_date_addDateTimePicker.Value = DateTime.Now;
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
