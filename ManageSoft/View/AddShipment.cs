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
    public partial class AddShipment : Form
    {

        public AddShipment()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            ItemModel im = new ItemModel();
            dataGridViewX1.DataSource = im.SeachItem(textBoxX1.Text);
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            item item = new item();
            item.id_item = (int)dataGridViewX1.CurrentRow.Cells[0].Value;
            item.item_name = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            ImportModule.senderItem(item);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Add_Item add = new Add_Item();
            add.ShowDialog();
        }
    }
}
