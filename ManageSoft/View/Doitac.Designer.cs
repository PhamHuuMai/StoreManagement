namespace ManageSoft.View
{
    partial class Doitac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtdiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnhuy = new DevComponents.DotNetBar.ButtonX();
            this.btnluu = new DevComponents.DotNetBar.ButtonX();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.dgvdoitac = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoitac)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdiachi
            // 
            // 
            // 
            // 
            this.txtdiachi.Border.Class = "TextBoxBorder";
            this.txtdiachi.Location = new System.Drawing.Point(193, 91);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(192, 20);
            this.txtdiachi.TabIndex = 39;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.Border.Class = "TextBoxBorder";
            this.txtTen.Location = new System.Drawing.Point(193, 62);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(190, 20);
            this.txtTen.TabIndex = 41;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(130, 64);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 38;
            this.labelX2.Text = "Tên :";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(193, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(190, 20);
            this.txtID.TabIndex = 36;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(106, 88);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 23);
            this.labelX3.TabIndex = 34;
            this.labelX3.Text = "Địa Chỉ:";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(130, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "ID :";
            // 
            // btnhuy
            // 
            this.btnhuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnhuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnhuy.Enabled = false;
            this.btnhuy.Location = new System.Drawing.Point(129, 161);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(125, 23);
            this.btnhuy.TabIndex = 33;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(266, 163);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(116, 23);
            this.btnluu.TabIndex = 32;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoa.Location = new System.Drawing.Point(329, 134);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(116, 23);
            this.btnxoa.TabIndex = 31;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsua.Location = new System.Drawing.Point(197, 132);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(119, 23);
            this.btnsua.TabIndex = 30;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthem.Location = new System.Drawing.Point(72, 132);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(115, 23);
            this.btnthem.TabIndex = 29;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvdoitac
            // 
            this.dgvdoitac.AllowUserToAddRows = false;
            this.dgvdoitac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdoitac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdoitac.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdoitac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdoitac.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvdoitac.Location = new System.Drawing.Point(0, 210);
            this.dgvdoitac.Name = "dgvdoitac";
            this.dgvdoitac.Size = new System.Drawing.Size(538, 308);
            this.dgvdoitac.TabIndex = 28;
            this.dgvdoitac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoitac_CellClick);
            // 
            // Doitac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 518);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvdoitac);
            this.Name = "Doitac";
            this.Text = "Doitac";
            this.Load += new System.EventHandler(this.Doitac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoitac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtdiachi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnhuy;
        private DevComponents.DotNetBar.ButtonX btnluu;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdoitac;
    }
}