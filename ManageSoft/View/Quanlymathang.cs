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
    public partial class Quanlymathang : Form
    {
        mathangModel mh = new mathangModel();
        public Quanlymathang()
        {
            InitializeComponent();
        }

        private void Quanlymathang_Load(object sender, EventArgs e)
        {
            dgvmathang.DataSource = mh.SelectAllMatHang();     
        }

        private void dgvmathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvmathang.CurrentRow.Cells;
            txtID.Text = cells[0].Value.ToString();
            txtTen.Text = cells[1].Value.ToString();
            txtloaihang.Text = cells[2].Value.ToString();
            txtcachxep.Text = cells[3].Value.ToString();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTen.Text = "";
            txtloaihang.Text = "";
            txtcachxep.Text = "";
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn hàng hóa");
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
                MessageBox.Show("Chưa chọn Hàng Hóa");
            }
            else
            {
                try
                {
                    mh.DeleteMatHang(int.Parse(txtID.Text));
                    dgvmathang.DataSource = mh.SelectAllMatHang();
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
                if (txtTen.Text.Equals("") && txtloaihang.Text.Equals("") && txtcachxep.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    item ee = new item();
                    ee.id_item = int.Parse(txtID.Text);
                    ee.item_name = txtTen.Text;
                    ee.name_type = txtloaihang.Text;
                    ee.planet_type = txtcachxep.Text;
                    mh.InsertMatHang(ee);
                }
            }
            else
            {
                if (txtTen.Text.Equals("") && txtloaihang.Text.Equals("") && txtcachxep.Text.Equals(""))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    item ee = new item();
                    ee.id_item =int.Parse( txtID.Text);
                    ee.item_name = txtTen.Text;
                    ee.name_type = txtloaihang.Text;
                    ee.planet_type = txtcachxep.Text;
                    mh.UpdateMatHang(ee);
                }
            }
            dgvmathang.DataSource = mh.SelectAllMatHang();
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }
    }
}
