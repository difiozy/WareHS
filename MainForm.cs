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
    public partial class MainForm : Form
    {
        public static WareHouse WH = new WareHouse(true);

        public MainForm()
        {
            InitializeComponent();
           
            RenderDataGridView(DataTable, WH.AllWare);
        }

        private void RenderDataGridView(DataGridView Table, List<Ware> wares)
        {
            Table.Rows.Clear();
            foreach (var ware in wares)
            {
                DataTable.Rows.Add(ware.Id, ware.Name, ware.Price,
                    ((DateTime)ware.ReceiptDate).ToShortDateString(),
                    ((DateTime)ware.ShippingDate).ToShortDateString(),
                    ((DateTime)ware.DisposalDate).ToShortDateString());

            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RenderDataGridView(DataTable, WH.AllWare);  
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddNewWareForm().Show();
            RenderDataGridView(DataTable, WH.AllWare);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            new RemoveWareForm().Show();
            RenderDataGridView(DataTable, WH.AllWare);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            WH.Serialize("WareList.json");
        }

        private void chooseDate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SearcheButton_Click(object sender, EventArgs e)
        {
            string dateType = chooseDate.SelectedItem.ToString();
            DateTime datetime = dateTimePicker1.Value;

            
            List<Ware> crrWares = WH.AllWare;
            
            
            if (dateType.CompareTo("Receipt Date") == 0)
            {
                crrWares = new List<Ware>();
                for (int i=0; i<WH.AllWare.Count; i++)
                {
                    if (WH.AllWare[i].ReceiptDate.Value.Date.ToString() == datetime.Date.ToString())
                    {
                        crrWares.Add(WH.AllWare[i]);
                    }
                }
            }
            else if (dateType.CompareTo("Shipping Date") == 0)
            {
                crrWares = new List<Ware>();
                for (int i = 0; i < WH.AllWare.Count; i++)
                {
                    if (WH.AllWare[i].ShippingDate.Value.Date.ToString() == datetime.Date.ToString())
                    {
                        crrWares.Add(WH.AllWare[i]);
                    }
                }
            }
            else if (dateType.CompareTo("Disposal Date") == 0)
            {
                crrWares = new List<Ware>();
                for (int i = 0; i < WH.AllWare.Count; i++)
                {
                    if (WH.AllWare[i].DisposalDate.Value.Date.ToString() == datetime.Date.ToString())
                    {
                        crrWares.Add(WH.AllWare[i]);
                    }
                }
            }


            RenderDataGridView(DataTable, crrWares);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            new UpdateForm().Show();
            RenderDataGridView(DataTable, WH.AllWare);
        }
    }
}
