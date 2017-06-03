using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSoft.View
{
    public partial class Main : Form
    {   
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {   if (!checkTab("Bảng kê nhập kho", tabControl1))
            {
                ImportResuls im = new ImportResuls();
                DevComponents.DotNetBar.TabItem t = tabControl1.CreateTab("Bảng kê nhập kho", tabControl1.Tabs.Count);
                t.AttachedControl.Controls.Add(im);
                tabControl1.SelectedTab = t;
            }
      //  tabControl1.re
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
           ImportModule im = new ImportModule();
           DevComponents.DotNetBar.TabItem t=tabControl1.CreateTab("Nhập kho",tabControl1.Tabs.Count);
           t.AttachedControl.Controls.Add(im);
           tabControl1.SelectedTab = t;
           
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            ExportModule em = new ExportModule();
            DevComponents.DotNetBar.TabItem t = tabControl1.CreateTab("Xuất kho", tabControl1.Tabs.Count);
            t.AttachedControl.Controls.Add(em);
            tabControl1.SelectedTab = t;
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            if (!checkTab("Bảng kê xuất kho", tabControl1))
            {
                ExportResult em = new ExportResult();
                DevComponents.DotNetBar.TabItem t = tabControl1.CreateTab("Bảng kê xuất kho", tabControl1.Tabs.Count);
                t.AttachedControl.Controls.Add(em);
                tabControl1.SelectedTab = t;
            }
        }
        private Boolean checkTab(String tabName, DevComponents.DotNetBar.TabControl tabControl)
        {
            IEnumerator tabs = tabControl.Tabs.GetEnumerator();
            while (tabs.MoveNext())
            {
                if (tabs.Current.ToString().Equals(tabName))
                    return true;
            }
            return false;
        }

        private void tabControl1_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            tabControl1.Tabs.Remove(tabControl1.SelectedTab);
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            if (!checkTab("Sơ đồ kho", tabControl1))
            {
                StorageMap em = new StorageMap();
                DevComponents.DotNetBar.TabItem t = tabControl1.CreateTab("Sơ đồ kho", tabControl1.Tabs.Count);
                t.AttachedControl.Controls.Add(em);
                tabControl1.SelectedTab = t;
            }
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            if (!checkTab("Danh sách hàng trong kho", tabControl1))
            {
                ListItemsView em = new ListItemsView();
                DevComponents.DotNetBar.TabItem t = tabControl1.CreateTab("Danh sách hàng trong kho", tabControl1.Tabs.Count);
                t.AttachedControl.Controls.Add(em);
                tabControl1.SelectedTab = t;
            }
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            if (!checkTab("Thống kê", tabControl1))
            {
                Statistic em = new Statistic();
                DevComponents.DotNetBar.TabItem t = tabControl1.CreateTab("Thống kê", tabControl1.Tabs.Count);
                t.AttachedControl.Controls.Add(em);
                tabControl1.SelectedTab = t;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Doitac qlmh = new Doitac();
            qlmh.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            (new Employee()).ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Quanlymathang qlmh = new Quanlymathang();
            qlmh.ShowDialog();
        }
    }
}
