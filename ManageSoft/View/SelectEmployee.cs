using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSoft.Entity;
using System.Data.Linq;
namespace ManageSoft.View
{
    public partial class SelectEmployee : Form
    {
        private DataDataContext data;
        public SelectEmployee()
        {
            InitializeComponent();
            data = new DataDataContext();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            Table<employee> employees = data.GetTable<employee>();
            Table<distributor> distributor = data.GetTable<distributor>();
            var query = from em in employees
                        join dis in distributor on em.id_distributor equals dis.id_distributor
                        where em.id_employee.ToString().Contains(textBoxX1.Text) || em.name_employee.Contains(textBoxX1.Text)
                        select new { em.id_employee,em.name_employee,em.birth_date,em.sex,dis.name_distributor};
            dataGridViewX1.DataSource = query;
        }
        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewX1.CurrentRow.Cells[0].Value != null)
            {
                employee em = new employee();
                em.name_employee = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
                em.id_employee = (int)dataGridViewX1.CurrentRow.Cells[0].Value;
                if (this.Tag.Equals(2))
                    ImportModule.senderEmployee(em);
                else
                    ExportModule.E_Sender(em);

                this.Close();
            }
        }
    }
}
