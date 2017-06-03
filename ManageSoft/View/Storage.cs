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
using ManageSoft.Entity;
namespace ManageSoft.View
{
    public partial class Storage : UserControl
    {
        public ShipmentModel sm;
        public Storage()
        {
            InitializeComponent();
            sm = new ShipmentModel();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = sm.SelectShipment();
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            shipment s = new shipment();
            s.id_shipment =(int)dataGridViewX1.CurrentRow.Cells[0].Value;
            s.posion= dataGridViewX1.CurrentRow.Cells[9].Value.ToString() ;
            s.unit= dataGridViewX1.CurrentRow.Cells[8].Value.ToString();
            s.number= (int)dataGridViewX1.CurrentRow.Cells[7].Value;
            s.ex_unit_price=(double)dataGridViewX1.CurrentRow.Cells[4].Value;
            s.man_date=(DateTime) dataGridViewX1.CurrentRow.Cells[5].Value;
            s.exp_date=(DateTime) dataGridViewX1.CurrentRow.Cells[6].Value;
            s.id_item=(int)dataGridViewX1.CurrentRow.Cells[1].Value;
            ExportModule.I_Sender(s);
        }
    }
}
