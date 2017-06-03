using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSoft.Model;
using ManageSoft.Entity;

namespace ManageSoft.View
{
    public partial class SelectFactory : Form
    {
        private DistribuitorModel disModel;
        public SelectFactory()
        {
            InitializeComponent();
            disModel = new DistribuitorModel();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
              dataGridViewX1.DataSource= disModel.SeachDistribui(textBoxX1.Text);
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            distributor dis = new distributor();
            if (dataGridViewX1.CurrentRow.Cells[0].Value!=null) { 
            dis.id_distributor = (int)dataGridViewX1.CurrentRow.Cells[0].Value;
            dis.name_distributor = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            dis._address = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
            ExportModule.F_Sender(dis);
            this.Close();
            }
        }

        private void SelectFactory_Load(object sender, EventArgs e)
        {

        }

        private void buttonMultiSelection1_Click(object sender, DevAge.Windows.Forms.SubButtonItemEventArgs e)
        {

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
