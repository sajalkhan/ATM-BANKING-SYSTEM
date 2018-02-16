using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Banking_system
{
    public partial class frmLoginPageEnglish : Form
    {
        frmAdminPage admin = new frmAdminPage();

        DAL.Info information = new DAL.Info();
        DAL.User u = new DAL.User();

        public frmLoginPageEnglish()
        {
            InitializeComponent();
            txtIncorrect.Text = "";
            
        }
       
        private void login_page_english_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            MyControls.Helper.Numeric(txtPassword);
        }

        //Number key 
        private void btn_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtIncorrect.Text != "") txtIncorrect.Text = "";
            if (txtPassword.Text.Length < 4)
            {
                txtPassword.Text += b.Text;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtIncorrect.Text = "";
            txtPassword.Focus();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().ShowDialog();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                return;
            }

            information.Password = txtPassword.Text;
            u.Password= txtPassword.Text;
            txtPassword.Text = "";

            if (information.SelectById())
            {
                if (information.Role == "Admin")
                {
                    if (admin.IsDisposed) admin = new frmAdminPage();
                    this.Close();
                    admin.Name = information.Name;
                    admin.Show();
                }
                else
                {
                    this.Close();
                    new frmUser(u.Password,information.Name).Show();
                }
            }
            else
            {
                txtIncorrect.Text = "Incorrect Password!";
                txtPassword.Text = "";
            }
        }
    }
}
