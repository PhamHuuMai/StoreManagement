using ManageSoft.Entity;
using ManageSoft.Model;
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
    public partial class Employee : Form
    {
        EmployeeModel em = new EmployeeModel();
        public Employee()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = em.SelectAllEmployee();
            comboBox2.DataSource = (new DistribuitorModel()).SelectList();
            
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dataGridViewX1.CurrentRow.Cells;
            textBoxX1.Text = cells[0].Value.ToString();
            textBoxX2.Text = cells[2].Value.ToString();
            comboBox2.Text = cells[4].Value.ToString();
            comboBox1.Text = cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)cells[1].Value;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            textBoxX1.Text = "";
            textBoxX2.Text = "";
        //    textBoxX3.Text = "";
            buttonX2.Enabled = false;
            buttonX3.Enabled = false;
            buttonX4.Enabled = true;
            buttonX5.Enabled = true;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn nhân viên");
            }
            else
            {
                buttonX1.Enabled = false;
                buttonX3.Enabled = false;
                buttonX4.Enabled = true;
                buttonX5.Enabled = true;
            }

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            buttonX1.Enabled = true;
            buttonX2.Enabled = true;
            buttonX3.Enabled = true;
            buttonX4.Enabled = false;
            buttonX5.Enabled = false;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text.Equals(""))
            {
                if(textBoxX2.Text.Equals("")&& comboBox1.Text.Equals("")&& comboBox2.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    employee ee = new employee();
                    ee.name_employee = textBoxX2.Text;
                    ee.sex = comboBox1.Text.Equals("Nam") ? 1 : 0;
                    ee.birth_date = dateTimePicker1.Value;
                    ee.id_distributor = ((distributor)comboBox2.SelectedItem).id_distributor;
                    em.InsertEmployee(ee);
                }                        
            }
            else
            {
                if (textBoxX2.Text.Equals("") && comboBox1.Text.Equals("") && comboBox2.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    employee ee = new employee();
                    ee.id_employee = Convert.ToInt32(textBoxX1.Text);
                    ee.name_employee = textBoxX2.Text;
                    ee.sex = comboBox1.Text.Equals("Nam") ? 1 : 0;
                    ee.birth_date = dateTimePicker1.Value;
                    ee.id_distributor = ((distributor)comboBox2.SelectedItem).id_distributor;
                    em.UpdateEmployee(ee);
                }
            }
            dataGridViewX1.DataSource = em.SelectAllEmployee();
            buttonX1.Enabled = true;
            buttonX2.Enabled = true;
            buttonX3.Enabled = true;
            buttonX4.Enabled = false;
            buttonX5.Enabled = false;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn nhân viên");
            }
            else
            {
                try
                {
                    em.DeleteEmployee(Convert.ToInt32(textBoxX1.Text));
                    dataGridViewX1.DataSource = em.SelectAllEmployee();
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }

        }
        
    }
}
