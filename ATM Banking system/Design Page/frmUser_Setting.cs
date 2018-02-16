using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM_Banking_system
{
    public partial class frmUser_Setting : ATM_Banking_system.frmDashBoard
    {
        public int Id;
        public string Name;
        public string Password;
        ErrorProvider ep = new ErrorProvider();
        public frmUser_Setting(string n,string p,int id)
        {
            InitializeComponent();
            Name = n;
            Password = p;
            Id = id;

            ToolTip T = new ToolTip();
            T.SetToolTip(user_pic,"Click here to Change your Profile Picture");
            T.SetToolTip(picBackButton,"Back");
        }

        private void picBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmUser(Password,Name).Show();
        }

        private void frmUser_Setting_Load(object sender, EventArgs e)
        {
            DAL.User user = new DAL.User();
            user.Password = Password;

            if(user.SelectImage())
            {
                user_pic.Image = MyControls.FileImage.ImageFromByte(user.Image);
                txtName.Text = user.Name;
                txtPhoneNumber.Text = user.PhoneNumber;
                txtAddress.Text = user.Address;
                txtPassword.Text = user.Password.ToString();
            }
            else
            {
                MessageBox.Show(user.Error);
            }
        }

        private void user_pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif";
            ofd.ShowDialog();

            if (ofd.FileName == null || ofd.FileName == "") return;
            user_pic.Image = Image.FromFile(ofd.FileName);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
            new frmUser(Password, Name).Show();
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
            if(txtPassword.Text=="")
            {
                er++;
                ep.SetError(txtPassword,"Required");
            }

            if (er > 0) return;

            DAL.User user = new DAL.User();
            user.Id = Id;
            user.Name = txtName.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.Address = txtAddress.Text;
            user.Password = txtPassword.Text;
            user.Image = MyControls.FileImage.ImageToByte(user_pic.Image);

            if(user.Update_All())
            {
                Name = user.Name;
                MessageBox.Show("Information Updated!");
            }
            else
            {
                MessageBox.Show(user.Error);
            }
        }
    }
}
