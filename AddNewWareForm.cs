using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHS
{
    public partial class AddNewWareForm : Form
    {
        public AddNewWareForm()
        {
            InitializeComponent();
        }

        private void ButtonEndAddWare_Click(object sender, EventArgs e)
        {
            int ans = -1;
            bool succes = int.TryParse(textBox_Price.Text, out ans);
            if (!succes || ans < 0)
            {
                MessageBox.Show("Wrong price");
            }
            else
            {
                Ware ware = new Ware(
                    name: textBox_name.Text,
                    price: ans,
                    receiptDate: (DateTime?)Convert.ToDateTime(ReceiptDateTimePicker.Text),
                    shippingDate: (DateTime)Convert.ToDateTime(ShippingDateTimePicker.Text),
                    disposalDate: (DateTime)Convert.ToDateTime(DisposalDateTimePicker.Text));
                MainForm.WH.AddWare(ware);
                this.Close();
            }
        }
    }
}
