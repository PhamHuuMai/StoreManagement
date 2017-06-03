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
using ManageSoft.Until;
using ManageSoft.View;
using ManageSoft.Properties;
using System.Threading;

namespace ManageSoft
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                
                AccountModel accModel = new AccountModel();
                if (accModel.CheckAccount(textBoxX1.Text, textBoxX2.Text))
                {
                    Main mainform = new Main();
                    mainform.Show();
                    Static.userName = textBoxX1.Text;
                    if (checkBoxX1.Checked)
                        IOfile.SaveAccount(textBoxX1.Text, textBoxX2.Text);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            catch(Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            String[] s= IOfile.LoadAccount();
            textBoxX1.Text = s[0];
            textBoxX2.Text = s[1];
        }
    }
}
