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
    public partial class UpdateForm : Form
    {
        List<Ware> allWare = MainForm.WH.AllWare;
        public UpdateForm()
        {
            InitializeComponent();
            for (int i = 0; i < allWare.Count; i++)
            {
                id_comboBox.Items.Add(allWare[i].Id);
            }
        }

        private void id_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            int.TryParse(id_comboBox.SelectedItem.ToString(), out id);
            Ware curWare = MainForm.WH.FindById(id);
            if (curWare != null)
            {
                name_textBox.Text = curWare.Name;
                price_textBox.Text = curWare.Price.ToString();
                //!
                var el = curWare.ReceiptDate.Value.Date.ToString();
                ShippingDateTimePicker.Text = curWare.ShippingDate.Value.Date.ToString();
                DisposalDateTimePicker.Text = curWare.ShippingDate.Value.Date.ToString();
            }
            else
            {
                MessageBox.Show("Not find id" + id_comboBox.SelectedIndex);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(id_comboBox.Text, out id);
            Ware curWare = MainForm.WH.FindById((int)id);

            if (curWare == null)
            {
                MessageBox.Show("Такого id не существует");
            }
            else
            {
                double price = -1;
                double.TryParse(price_textBox.Text, out price);
                
                MainForm.WH.UpdateName(id, name_textBox.Text);                
                MainForm.WH.UpdatePrice(id, price);
                MainForm.WH.UpdateReceiptDate(id, ReceiptdateTimePicker.Value);
                MainForm.WH.UpdateShippingDate(id, ShippingDateTimePicker.Value);
                MainForm.WH.UpdateDisposalDate(id, DisposalDateTimePicker.Value);

                this.Close();
            }
        }
    }
}
