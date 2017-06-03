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
    public partial class Doitac : Form
    {
        DoitacModel dt = new DoitacModel();
        public Doitac()
        {
            InitializeComponent();
        }

        private void Doitac_Load(object sender, EventArgs e)
        {
            dgvdoitac.DataSource = dt.SelectAllDoitac();
        }

        private void dgvdoitac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvdoitac.CurrentRow.Cells;
            txtID.Text = cells[0].Value.ToString();
            txtTen.Text = cells[1].Value.ToString();
            txtdiachi.Text = cells[2].Value.ToString();     
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTen.Text = "";
            txtdiachi.Text = "";
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn Đối Tác");
            }
            else
            {
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnluu.Enabled = true;
                btnhuy.Enabled = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn Đối Tác");
            }
            else
            {
                try
                {
                    dt.DeleteDoitac(int.Parse(txtID.Text));
                    dgvdoitac.DataSource = dt.SelectAllDoitac();
                    
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                if (txtTen.Text.Equals("") && txtTen.Text.Equals("") && txtdiachi.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    distributor ee = new distributor();                 
                    ee.name_distributor = txtTen.Text;
                    ee._address = txtdiachi.Text;                 
                    dt.InsertDoitac(ee);
                }
            }
            else
            {
                if (txtTen.Text.Equals("") && txtTen.Text.Equals("") && txtdiachi.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    distributor ee = new distributor();
                    ee.id_distributor = int.Parse(txtID.Text);
                    ee.name_distributor = txtTen.Text;
                    ee._address = txtdiachi.Text;
                    dt.UpdateDoitac(ee);
                }
            }
            dgvdoitac.DataSource = dt.SelectAllDoitac();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
    }
}
