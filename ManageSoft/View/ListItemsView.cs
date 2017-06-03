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
    public partial class ListItemsView : UserControl
    {
        private ShipmentModel shipment;
        public ListItemsView()
        {
            InitializeComponent();
            shipment = new ShipmentModel();
            dataGridViewX1.DataSource = shipment.Storage();
        }
    }
}
