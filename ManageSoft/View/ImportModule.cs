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
using ManageSoft.Until;
using System.Data.Linq;
namespace ManageSoft.View
{
    public partial class ImportModule : UserControl
    {
        private ImportTicketModel im;
        private ShipmentModel shipments;
        public delegate void SendEmployee(employee em);
        public delegate void AddItem(item item);
        public static SendEmployee senderEmployee;
        public static AddItem senderItem;
        public ImportModule()
        {   
            InitializeComponent();
            im = new ImportTicketModel();
            shipments = new ShipmentModel();
            this.textBoxUITypeEditor4.Button.Click += new System.EventHandler(this.textBoxUITypeEditor4_Click);
            this.textBoxUITypeEditor3.Button.Click += new System.EventHandler(this.textBoxUITypeEditor3_Click);
            this.textBoxUITypeEditor2.Button.Click += new System.EventHandler(this.textBoxUITypeEditor2_Click);
            this.textBoxUITypeEditor1.Button.Click += new System.EventHandler(this.textBoxUITypeEditor1_Click);
            textBoxUITypeEditor1.TextBox.Enabled = false;
            textBoxUITypeEditor2.TextBox.Enabled = false;
            textBoxUITypeEditor3.TextBox.Enabled = false;
            textBoxUITypeEditor4.TextBox.Enabled = false;
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl ff = (DevComponents.DotNetBar.TabControl)this.Parent.Parent;
            ff.Tabs.RemoveAt(ff.SelectedTabIndex);
        }
        private void InputEmployee1(employee em)
        {
            textBoxUITypeEditor1.TextBox.Text = em.name_employee;
            textBoxUITypeEditor1.Tag = em.id_employee;
        }
        private void InputEmployee2(employee em)
        {
            textBoxUITypeEditor2.TextBox.Text = em.name_employee;
            textBoxUITypeEditor2.Tag = em.id_employee;
        }
        private void InputEmployee3(employee em)
        {
            textBoxUITypeEditor3.TextBox.Text = em.name_employee;
            textBoxUITypeEditor3.Tag = em.id_employee;
        }
        private void InputEmployee4(employee em)
        {
            textBoxUITypeEditor4.TextBox.Text = em.name_employee;
            textBoxUITypeEditor4.Tag = em.id_employee;
        }
        private void InputItem(item item) {
            bool flag = true;
            foreach(System.Windows.Forms.DataGridViewRow i in dataGridViewX1.Rows){
                if (i.Cells[0].Value.ToString().Equals(item.id_item.ToString()))
                    flag = false;
            }
            if (flag)
            {
                int i = dataGridViewX1.Rows.Add();
                dataGridViewX1.Rows[i].Cells[0].Value =item.id_item;
                dataGridViewX1.Rows[i].Cells[1].Value =item.item_name;
            }
        }
        private void textBoxUITypeEditor1_Click(object sender, EventArgs e)
        {
            senderEmployee = InputEmployee1;
            SelectEmployee se = new SelectEmployee();
            se.Tag = 2;
            se.ShowDialog();
        }

        private void textBoxUITypeEditor2_Click(object sender, EventArgs e)
        {
            senderEmployee = InputEmployee2;
            SelectEmployee se = new SelectEmployee();
            se.Tag = 2;
            se.ShowDialog();
        }

        private void textBoxUITypeEditor3_Click(object sender, EventArgs e)
        {
            senderEmployee = InputEmployee3;
            SelectEmployee se = new SelectEmployee();
            se.Tag = 2;
            se.ShowDialog();
        }

        private void textBoxUITypeEditor4_Click(object sender, EventArgs e)
        {
            senderEmployee = InputEmployee4;
            SelectEmployee se = new SelectEmployee();
            se.Tag = 2;
            se.ShowDialog();
        }

        private void textBoxUITypeEditor5_Click(object sender, EventArgs e)
        {
             SelectFactory sf = new SelectFactory();
             sf.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            senderItem = InputItem;
            AddShipment shipment = new AddShipment();
            shipment.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            im_ticket im_ticket = new im_ticket();
            im_ticket.date_im = (new DateTime(dateTimeInput1.Value.Year, dateTimeInput1.Value.Month, dateTimeInput1.Value.Day));
            im_ticket.id_accountant = (int)textBoxUITypeEditor4.Tag;
            im_ticket.id_write= (int)textBoxUITypeEditor2.Tag;
            im_ticket.id_shipper= (int)textBoxUITypeEditor1.Tag;
            im_ticket.id_storager= (int)textBoxUITypeEditor3.Tag;
            int idTicket= im.insertImportTicket(im_ticket);
            bool d = true;
            List<shipment> l = new List<shipment>();
            foreach (DataGridViewRow row in dataGridViewX1.Rows) {
                shipment shipment = new shipment();
                try
                {
                    shipment.id_im_ticket = idTicket;
                    shipment.id_item = (int)row.Cells[0].Value;
                    shipment.number = Convert.ToInt32(row.Cells[2].Value);
                    shipment.unit = row.Cells[3].Value.ToString();
                    shipment.ex_unit_price = Convert.ToDouble(row.Cells[5].Value);
                    shipment.im_unit_price = Convert.ToDouble(row.Cells[4].Value);
                    shipment.man_date = Convert.ToDateTime(row.Cells[6].Value);
                    shipment.exp_date = Convert.ToDateTime(row.Cells[7].Value);
                    shipment.posion = row.Cells[8].Value.ToString();
                    l.Add(shipment);
                }
                catch {
                    MessageBox.Show("Có gì đó không ổn!");
                    im.deleteImportTicket(im_ticket);
                    d = false;
                    break;
                }    
              }
            if (d) {
                MessageBox.Show("Thành công");
                shipments.InsertShipment((IEnumerable<shipment>)l);
                DevComponents.DotNetBar.TabControl ff = (DevComponents.DotNetBar.TabControl)this.Parent.Parent;
                ff.Tabs.RemoveAt(ff.SelectedTabIndex);
            }
            }
    }
}
