using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSoft.Model;
namespace ManageSoft.View
{
    public partial class ImportResuls : UserControl
    {
        private ImportTicketModel im;
        private ShipmentModel shipment;
        public ImportResuls()
        {
            InitializeComponent();
            im = new ImportTicketModel();
            shipment = new ShipmentModel();
            dataGridViewX2.DataSource = im.SelectAllImportTicket();
            dateTimeInput1.Value = DateTime.Now;
            dateTimeInput2.Value= DateTime.Now;
            dateTimeInput3.Value = DateTime.Now;
        }

        private void dateTimeInput1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewX2.DataSource = im.SelectImportTicket(dateTimeInput1.Value);
        }

        private void dateTimeInput3_TextChanged(object sender, EventArgs e)
        {
            if (dateTimeInput2.Value.CompareTo(dateTimeInput3.Value) <= 0)
            {
                dataGridViewX2.DataSource = im.SelectImportTicket(dateTimeInput2.Value, dateTimeInput3.Value);
            }
            else
            {
                MessageBox.Show("Thời gian ko hop le");
            }
        }

     
        private void integerInput1_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewX2.DataSource = im.SelectImportTicket(integerInput1.Value);
        }

        private void dataGridViewX2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1.DataSource = shipment.SelectShipment((int)dataGridViewX2.CurrentRow.Cells[0].Value);
        }
    }
}
