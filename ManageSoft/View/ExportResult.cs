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
    public partial class ExportResult : UserControl
    {
        private ExportTicketModel ex; 

        public ExportResult()
        {
            InitializeComponent();
            ex = new ExportTicketModel();
            dataGridViewX2.DataSource = ex.SelectTicket();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void integerInput1_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewX2.DataSource = ex.SelectTicket(integerInput1.Value);
        }

        private void dateTimeInput1_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewX2.DataSource = ex.SelectTicket(dateTimeInput1.Value);
        }

        private void dateTimeInput2_ValueChanged(object sender, EventArgs e)
        {
            dateTimeInput3.Enabled = true;
        }

        private void dateTimeInput3_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeInput3.Value.CompareTo(dateTimeInput2.Value) >= 0)
            {
                dataGridViewX2.DataSource = ex.SelectTicket(dateTimeInput2.Value, dateTimeInput3.Value);
            }
            else
            {
                MessageBox.Show("Khong hop le");
            }
        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1.DataSource = ex.SelectTicketDetail((int)dataGridViewX2.CurrentRow.Cells[0].Value);
        }
    }
}
