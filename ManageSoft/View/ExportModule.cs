using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSoft.Entity;
using ManageSoft.Model;
namespace ManageSoft.View
{
    public partial class ExportModule : UserControl
    {
        public ExportModule()
        {
            InitializeComponent();
            F_Sender = SetFactory;
            this.textBoxUITypeEditor2.Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUITypeEditor2_MouseClick);
            this.textBoxUITypeEditor1.Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUITypeEditor1_MouseClick);
            this.textBoxUITypeEditor3.Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUITypeEditor3_MouseClick);
            this.textBoxUITypeEditor4.Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUITypeEditor4_MouseClick);
            this.textBoxUITypeEditor5.Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUITypeEditor5_MouseClic);
            this.textBoxUITypeEditor5.TextBox.Enabled = false;
            this.textBoxUITypeEditor4.TextBox.Enabled = false;
            this.textBoxUITypeEditor3.TextBox.Enabled = false;
            this.textBoxUITypeEditor2.TextBox.Enabled = false;
            this.textBoxUITypeEditor1.TextBox.Enabled = false;
            item = new ItemModel();
            I_Sender = AddItem;
            ex = new ExportTicketModel();
        }
        public ItemModel item;
        private ExportTicketModel ex;
        public delegate void SendFactory(distributor dis);
        public delegate void SendEmployee(employee em);
        public delegate void SendItem(shipment sh);
        public static SendFactory F_Sender;
        public static SendEmployee E_Sender;
        public static SendItem I_Sender;
        private void SetFactory(distributor d)
        {
            textBoxUITypeEditor5.TextBox.Text = ""+d.id_distributor;
            textBoxX2.Text = d.name_distributor;
            textBoxX3.Text = d._address;
        }
        private void SetEmployee1(employee e)
        {
            textBoxUITypeEditor1.TextBox.Text = e.name_employee;
            textBoxUITypeEditor1.Tag = e.id_employee;
        }
        private void SetEmployee2(employee e)
        {
            textBoxUITypeEditor2.TextBox.Text = e.name_employee;
            textBoxUITypeEditor2.Tag = e.id_employee;
        }
        private void SetEmployee3(employee e)
        {
            textBoxUITypeEditor3.TextBox.Text = e.name_employee;
            textBoxUITypeEditor3.Tag = e.id_employee;
        }
        private void SetEmployee4(employee e)
        {
            textBoxUITypeEditor4.TextBox.Text = e.name_employee;
            textBoxUITypeEditor4.Tag = e.id_employee;
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl ff = (DevComponents.DotNetBar.TabControl)this.Parent.Parent;
            ff.Tabs.RemoveAt(ff.SelectedTabIndex);
        }
        private void AddItem(shipment s)
        {
            if (Check(s.id_shipment))
            {
                int i = dataGridViewX1.Rows.Add();
                dataGridViewX1.Rows[i].Cells[0].Value = s.id_shipment;
                dataGridViewX1.Rows[i].Cells[1].Value = item.GetNameItem(s.id_item.Value);
                dataGridViewX1.Rows[i].Cells[2].Value = s.man_date;
                dataGridViewX1.Rows[i].Cells[3].Value = s.exp_date;
                dataGridViewX1.Rows[i].Cells[4].Value = s.number;
                dataGridViewX1.Rows[i].Cells[5].Value = 0;
                dataGridViewX1.Rows[i].Cells[6].Value = s.ex_unit_price;
                dataGridViewX1.Rows[i].Cells[7].Value = s.unit;
                dataGridViewX1.Rows[i].Cells[8].Value = s.posion;
            }      
        }
        private bool Check(int idShipment)
        {
            bool f = true;
            foreach (DataGridViewRow row in dataGridViewX1.Rows)
            {
                if (row.Cells[0].Value.Equals(idShipment))
                    f = false;
            }
            return f;
        } 
        private void textBoxUITypeEditor5_MouseClic(object sender, MouseEventArgs e)
        {
            SelectFactory sf = new SelectFactory();
            sf.ShowDialog();

        }

        private void textBoxUITypeEditor1_MouseClick(object sender, MouseEventArgs e)
        {
            E_Sender = SetEmployee1;
            SelectEmployee se = new SelectEmployee();
            se.Tag = 1;
            se.ShowDialog();
           
        }

        private void textBoxUITypeEditor2_MouseClick(object sender, MouseEventArgs e)
        {
            E_Sender = SetEmployee2;
            SelectEmployee se = new SelectEmployee();
            se.Tag = 1;
            se.ShowDialog();
           
        }

        private void textBoxUITypeEditor3_MouseClick(object sender, MouseEventArgs e)
        {
            E_Sender = SetEmployee3;
            SelectEmployee se = new SelectEmployee();
            se.Tag=1;
            se.ShowDialog();
            
        }

        private void textBoxUITypeEditor4_MouseClick(object sender, MouseEventArgs e)
        {
            E_Sender = SetEmployee4;
            SelectEmployee se = new SelectEmployee();
            se.Tag = 1;
            se.ShowDialog();
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            StorageItem si = new StorageItem();
            si.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if(!"".Equals(textBoxUITypeEditor1.TextBox.Text)
                &&! "".Equals(textBoxUITypeEditor2.TextBox.Text)
                 &&! "".Equals(textBoxUITypeEditor3.TextBox.Text)
                  &&! "".Equals(textBoxUITypeEditor4.TextBox.Text)
                   &&! "".Equals(textBoxUITypeEditor5.TextBox.Text))
             {
                ex_ticket exTicket = new ex_ticket();
                exTicket.date_ex= dateTimeInput1.Value;
                exTicket.id_distributor = Convert.ToInt32(textBoxUITypeEditor5.TextBox.Text);
                exTicket.id_accountant =(int) textBoxUITypeEditor4.Tag;
                exTicket.id_shipper= (int)textBoxUITypeEditor1.Tag;
                exTicket.id_storager= (int)textBoxUITypeEditor3.Tag;
                exTicket.id_write= (int)textBoxUITypeEditor2.Tag;
                int id=ex.Insert(exTicket);
                List<ex_ticket_detail> list= CheckData(id);
                if (list != null)
                {
                    ex.Insert(list);
                    DevComponents.DotNetBar.TabControl ff = (DevComponents.DotNetBar.TabControl)this.Parent.Parent;
                    ff.Tabs.RemoveAt(ff.SelectedTabIndex);
                }
                else
                    MessageBox.Show("sss");
            }
        }
        private List<ex_ticket_detail> CheckData(int id)
        {
            List<ex_ticket_detail> list = new List<ex_ticket_detail>();
            foreach (DataGridViewRow row in dataGridViewX1.Rows)
            {
                try
                {
                    ex_ticket_detail detail = new ex_ticket_detail();
                    detail.id_ex_ticket = id;
                    detail.id_shipment = Convert.ToInt32(row.Cells[0].Value);
                    detail.number = Convert.ToInt32(row.Cells[5].Value);
                    list.Add(detail);
                }
                catch
                {
                    return null;
                }
            }
            return list;
        }
    }
}
