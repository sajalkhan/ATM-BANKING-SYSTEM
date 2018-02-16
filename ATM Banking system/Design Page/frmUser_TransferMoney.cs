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
    public partial class frmUser_TransferMoney : Form
    {
        public double Money;
        public string password;
        public int User_Id;
        public string Name;

        DAL.User user = new DAL.User();
        ErrorProvider ep = new ErrorProvider();

        public frmUser_TransferMoney(double m,string p,int id,string n)
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

            
            cmbAccountNumber.DataSource = user.Select().Tables[0];
            cmbAccountNumber.DisplayMember = "id";
            cmbAccountNumber.ValueMember = "id";
            cmbAccountNumber.SelectedValue = -1;
            
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
            int er = 0;
            ep.Clear();

            if(txtAmount.Text=="")
            {
                txtAmount.Focus();
                return;
            }
            if(cmbAccountNumber.SelectedValue==null || cmbAccountNumber.SelectedValue.ToString()=="")
            {
                er++;
                ep.SetError(cmbAccountNumber,"Required");
            }

            if (er > 0) return;

            int Amount = Convert.ToInt32(txtAmount.Text);
            txtAmount.Text = "";
            if(Amount>(Int32)Money)
            {
                txtAmount.Text = "";
                txtInfo.Text = "Insufficient Balance!";
            }
            if(Amount<100)
            {
                txtAmount.Text = "";
                txtInfo.Text = "Transaction isn't possible!";
            }
            if(Amount<=(Int32)Money && Amount>=100)
            {
                DAL.User user = new DAL.User();
                DAL.User u = new DAL.User();

                user.Id = Convert.ToInt32(cmbAccountNumber.SelectedValue);
                user.Select_Balance();
                user.Balance += Amount;

                Amount = (Int32)Money - Amount;

                u.Id = User_Id;
                u.Balance = Amount;

                if(user.Update() && u.Update())
                {
                    MessageBox.Show("Money Transfer Successfully!");
                }
                else
                {
                    MessageBox.Show(u.Error+user.Error);
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
