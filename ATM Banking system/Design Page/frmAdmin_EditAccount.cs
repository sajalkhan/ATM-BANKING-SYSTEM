using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Banking_system
{
    public partial class frmAdmin_EditAccount : ATM_Banking_system.frmDashBoard
    {
        public int Id;
        public string Name;
        public string Phonenumber;
        public string Address;
        public double Balance;

        ErrorProvider ep = new ErrorProvider();
        private readonly Action RefreshGrid;
        public frmAdmin_EditAccount(Action Refresh)
        {
            InitializeComponent();

            RefreshGrid = Refresh;

            ToolTip T = new ToolTip();
            T.SetToolTip(picBackButton, "Back");
        }

        private void picBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_Setting_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
            txtPhoneNumber.Text = Phonenumber;
            txtAddress.Text = Address;
            txtBalance.Text = Balance.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;
            ep.Clear();
            if(txtName.Text=="")
            {
                er++;
                ep.SetError(txtName,"Required");
            }
            if(txtAddress.Text=="")
            {
                er++;
                ep.SetError(txtAddress,"Required");
            }
            if(txtPhoneNumber.Text=="")
            {
                er++;
                ep.SetError(txtPhoneNumber,"Required");
            }
            if(txtBalance.Text=="")
            {
                er++;
                ep.SetError(txtBalance,"Required");
            }

            if (er > 0) return;

            DAL.User user = new DAL.User();
            user.Id = Id;
            user.Name = txtName.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.Address = txtAddress.Text;
            user.Balance = Convert.ToDouble(txtBalance.Text);

            if(user.Update_Admin())
            {
                RefreshGrid();
                MessageBox.Show("Information Updated!");
            }
            else
            {
                MessageBox.Show(user.Error);
            }
        }
    }
}
