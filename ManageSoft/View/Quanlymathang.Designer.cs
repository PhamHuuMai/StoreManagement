namespace ManageSoft.View
{
    partial class Quanlymathang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnhuy = new DevComponents.DotNetBar.ButtonX();
            this.btnluu = new DevComponents.DotNetBar.ButtonX();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.dgvmathang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtcachxep = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtloaihang = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmathang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhuy
            // 
            this.btnhuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnhuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnhuy.Enabled = false;
            this.btnhuy.Location = new System.Drawing.Point(129, 167);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(125, 23);
            this.btnhuy.TabIndex = 23;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(266, 169);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(116, 23);
            this.btnluu.TabIndex = 22;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoa.Location = new System.Drawing.Point(329, 140);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(116, 23);
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsua.Location = new System.Drawing.Point(197, 138);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(119, 23);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthem.Location = new System.Drawing.Point(72, 138);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(115, 23);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvmathang
            // 
            this.dgvmathang.AllowUserToAddRows = false;
            this.dgvmathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmathang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmathang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvmathang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvmathang.Location = new System.Drawing.Point(0, 209);
            this.dgvmathang.Name = "dgvmathang";
            this.dgvmathang.Size = new System.Drawing.Size(485, 263);
            this.dgvmathang.TabIndex = 18;
            this.dgvmathang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmathang_CellClick);
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Location = new System.Drawing.Point(168, 39);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(190, 20);
            this.txtTen.TabIndex = 27;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(105, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 26;
            this.labelX2.Text = "Tên :";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(168, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(190, 20);
            this.txtID.TabIndex = 25;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(105, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "ID :";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(105, 67);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 23);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "Loại Hàng:";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(65, 91);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(97, 23);
            this.labelX4.TabIndex = 26;
            this.labelX4.Text = "Cách Xếp Hàng:";
            // 
            // txtcachxep
            // 
            // 
            // 
            // 
            this.txtcachxep.Border.Class = "TextBoxBorder";
            this.txtcachxep.Location = new System.Drawing.Point(168, 94);
            this.txtcachxep.Name = "txtcachxep";
            this.txtcachxep.Size = new System.Drawing.Size(192, 20);
            this.txtcachxep.TabIndex = 27;
            // 
            // txtloaihang
            // 
            // 
            // 
            // 
            this.txtloaihang.Border.Class = "TextBoxBorder";
            this.txtloaihang.Location = new System.Drawing.Point(168, 68);
            this.txtloaihang.Name = "txtloaihang";
            this.txtloaihang.Size = new System.Drawing.Size(192, 20);
            this.txtloaihang.TabIndex = 27;
            // 
            // Quanlymathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 472);
            this.Controls.Add(this.txtloaihang);
            this.Controls.Add(this.txtcachxep);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvmathang);
            this.Name = "Quanlymathang";
            this.Text = "Quản Lý Mặt Hàng";
            this.Load += new System.EventHandler(this.Quanlymathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmathang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnhuy;
        private DevComponents.DotNetBar.ButtonX btnluu;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvmathang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcachxep;
        private DevComponents.DotNetBar.Controls.TextBoxX txtloaihang;
    }
}