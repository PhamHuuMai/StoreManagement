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
using ManageSoft.Until;
//using DevComponents.DotNetBar;

namespace ManageSoft.View
{
    public partial class StorageMap : UserControl
    {

        public StorageMap()
        {
            InitializeComponent();
        }

   
        private void StorageMap_Load(object sender, EventArgs e)
        {
            int height=20,width=40;
            flowLayoutPanel1.Size = new Size(20 * width, 20 * height);
            for (int i = 1; i <= width; i++)
                flowLayoutPanel2.Controls.Add(createPanelTitle(i, System.Drawing.Color.Gold));
            for (int i = 1; i <= height; i++)
                flowLayoutPanel3.Controls.Add(createPanelTitle(i, System.Drawing.Color.Gold));
            ShipmentModel am = new ShipmentModel();
            IQueryable<ItemInfor> list= am.Select();
           
            for (int i = 0; i < height * width ; i++)
            {
                ItemInfor ii = null;
                try
                {
                    ii= list.SingleOrDefault(x => x.posion.Equals(Static.ConvertPosition(i)));
                }
                catch
                {

                }
                
                if (ii!=null)
                {
                    flowLayoutPanel1.Controls.Add(createPanel(0,ii));
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(createPanel(1,null));
                }
            }
        }
        private Panel createPanel(int colorCode,ItemInfor ii)
        {
            Panel pn = new Panel();
            pn.Margin = new Padding(0);
            pn.Padding = new Padding(0);
            pn.Size = new Size(20,20);
            DevComponents.DotNetBar.BalloonTip bt = new DevComponents.DotNetBar.BalloonTip();
            bt.AlertAnimationDuration = 200;
            bt.AutoClose = true;
            bt.BalloonFocus = true;
            bt.ShowCloseButton = true;
            bt.AutoCloseTimeOut = 500;
            
            string s = "";
            if (ii!=null)
              s= "Số lô:" + ii.id_shipment + " Tên hàng :" + ii.NameItem
                    + "  NSX:"+ii.man_date+"  HSD:"+ii.exp_date+"  Số lương: "+ii.number +"  Vị trí :"+ii.posion;
            bt.SetBalloonText(pn,s);
            pn.MouseClick += delegate (object sender, MouseEventArgs e)
            {
                bt.ShowBalloon(pn);
            };
            if (colorCode== 1)
             pn.BackColor= System.Drawing.Color.GreenYellow;
            else
             pn.BackColor = System.Drawing.Color.Red;
            return pn;
        }
        private Panel createPanelTitle(int lb, Color color)
        {
            Panel pn = new Panel();
            pn.Margin = new Padding(0);
            pn.Padding = new Padding(0);
            pn.Size = new Size(20, 20);
            pn.BackColor = color;
            Label label = new Label();
            label.Text = ""+lb;
            pn.Controls.Add(label);
            return pn;
        }

    }
}
