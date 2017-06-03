using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSoft.View
{
    public partial class StorageItem : Form
    {
        public StorageItem()
        {
            InitializeComponent();
            this.Controls.Add(new Storage());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StorageItem_Load(object sender, EventArgs e)
        {

        }
    }
}
