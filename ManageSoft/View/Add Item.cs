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
    public partial class Add_Item : Form
    {
        public Add_Item()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            if ((!textBoxX1.Text.Equals(""))&& (!textBoxX2.Text.Equals("")) && (!textBoxX3.Text.Equals(""))) {
                ItemModel item = new ItemModel();
                item i = new Entity.item();
                i.item_name = textBoxX1.Text;
                i.name_type = textBoxX2.Text;
                i.planet_type = textBoxX3.Text;
                item.InsertItem(i);
                this.Close();
            }
            else
            {
                MessageBox.Show("Có gì đó sai sai ở đây!");
            }
        }
    }
}
