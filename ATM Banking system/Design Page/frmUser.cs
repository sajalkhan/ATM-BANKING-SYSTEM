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
    public partial class frmUser : Form
    {
        DAL.User user = new DAL.User();

        private string Name;
        private string User_Password;

        public frmUser(string p,string name)
        {
            InitializeComponent();
            User_Password = p;
            Name = name;

            ToolTip T = new ToolTip();
            T.SetToolTip(pictureBox2,"Logout");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            txtName.Text = Name;
            user.Password = User_Password;

            if (user.SelectImage())
            {
                Image img = MyControls.FileImage.ImageFromByte(user.Image);
                if (img != null) user_pic.Image = img;
            }
            //else MessageBox.Show(user.Error);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmUser_Balance_Enquiry2(user.Balance.ToString()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMoneyWithdraw(user.Balance, this.User_Password, user.Id,Name).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmUser_Deposit_Money(user.Balance,User_Password,user.Id,Name).Show();
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmUser_TransferMoney(user.Balance,User_Password,user.Id,Name).Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmUser_Setting(Name, User_Password,user.Id).Show();
        }
    }
}
