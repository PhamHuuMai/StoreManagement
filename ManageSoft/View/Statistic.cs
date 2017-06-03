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
    public partial class Statistic : UserControl
    {
        private ShipmentModel shipment;
        public Statistic()
        {
            InitializeComponent();
            shipment = new ShipmentModel();
            UpdateChart();
        }

        private void UpdateChart()
        {
            chart1.DataSource = shipment.SelectOut();
            chart1.Series[1].XValueMember = "date";
            chart1.Series[1].YValueMembers = "money1";
            chart1.Series[0].XValueMember = "date";
            chart1.Series[0].YValueMembers = "money2";
          //  dataGridViewX1.DataSource= shipment.SelectOut();
        }
    }
}
