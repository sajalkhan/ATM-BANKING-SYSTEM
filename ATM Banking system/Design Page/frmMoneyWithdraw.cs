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
    public partial class frmMoneyWithdraw : Form
    {
        public double Money;
        public string password;
        public int User_Id;
        public string Name;
        public frmMoneyWithdraw(double m,string p,int id,string n)
        {
            InitializeComponent();
            Money = m;
            password=p;
            User_Id = id;
            Name = n;
            txtInfo.Text = "";

            ToolTip T = new ToolTip();
            T.SetToolTip(picBackButton,"Back");
        }
       
        private void login_page_english_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            MyControls.Helper.Numeric(txtAmount);
        }

        //Number key 
        private void btn_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtInfo.Text != "") txtInfo.Text = "";
            if (txtAmount.Text.Length < 5)
            {
                txtAmount.Text += b.Text;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtInfo.Text = "";
            txtAmount.Focus();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmUser(password,Name).Show();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text=="")
            {
                txtAmount.Focus();
                return;
            }
            int Amount = Convert.ToInt32(txtAmount.Text);
            txtAmount.Text = "";

            if (Amount>(Int32)Money)
            {
                txtAmount.Text = "";
                txtInfo.Text = "Insufficient Balance!";
            }
            if(Amount<500)
            {
                txtAmount.Text = "";
                txtInfo.Text = "Transaction isn't possible!";
            }
            if(Amount<=(Int32)Money && Amount>=500)
            {
                DAL.User u = new DAL.User();
                Amount = (Int32)Money - Amount;

                u.Id = User_Id;
                u.Balance = Amount;
                if(u.Update())
                {
                    MessageBox.Show("Data Updated!");
                }
                else
                {
                    MessageBox.Show(u.Error);
                }
            }
        }

        private void picBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmUser(password, Name).Show();
        }
    }
}
