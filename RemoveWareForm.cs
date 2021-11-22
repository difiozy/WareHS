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
    public partial class RemoveWareForm : Form
    {
        public RemoveWareForm()
        {
            InitializeComponent();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            int id;
            bool succes = int.TryParse(idremove_textBox.Text, out id);
            if (succes && MainForm.WH.FindById(id)!=null)
            {
                MainForm.WH.RemoveById(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong id");
            }
        }
    }
}
