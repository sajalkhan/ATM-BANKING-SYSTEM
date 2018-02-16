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
    public partial class frmAdminPageOpenAccount : Form
    {
        ErrorProvider ep = new ErrorProvider();
        private readonly Action RefreshGrid;

        //public Form Myparent { get; set; }
        public frmAdminPageOpenAccount(Action refresh)
        {
            InitializeComponent();
            RefreshGrid = refresh;

            ToolTip T = new ToolTip();
            T.SetToolTip(exit_button,"Close");
        }

        private void login_page_english_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            this.StartPosition = FormStartPosition.Manual;
            this.Top = ((Screen.PrimaryScreen.Bounds.Height - this.Height) / 2)-15;
            this.Left = ((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2)+360;

            MyControls.Helper.Numeric(txtNumber);
            MyControls.Helper.Numeric(txtPassword);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if(txtPassword.Text=="")
            {
                er++;
                ep.SetError(txtPassword,"Required");
            }
            if(txtNumber.Text=="")
            {
                er++;
                ep.SetError(txtNumber,"Required");
            }
            if(cmbRole.Text=="")
            {
                er++;
                ep.SetError(cmbRole,"Required");
            }

            if (er > 0) return;

            DAL.User user = new DAL.User();
            DAL.Info info = new DAL.Info();

            user.Name = txtName.Text;
            user.Address = txtAddress.Text;
            user.PhoneNumber = txtNumber.Text;
            user.Image = MyControls.FileImage.ImageToByte(user_pic.Image);
            user.Insert();

            info.Password = txtPassword.Text;
            info.Role = cmbRole.Text;
            user.GetMaxId();
            info.UserId =user.Id;

            if (info.Insert())
            {
                MessageBox.Show("Data Saved");

                //Button btn = (Button)(Myparent.Controls.Find("search", false).First());
                //btn.PerformClick();

                RefreshGrid();

                MyControls.Helper.Clear(this);
                user_pic.Image = null;
                txtName.Focus();
            }
            else
            {
                MessageBox.Show(user.Error+info.Error);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_pic.Image = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG|*.jpg|PNG|*.png|GIF|*.gif";
            ofd.ShowDialog();

            if (ofd.FileName == null || ofd.FileName == "") return;
            user_pic.Image = Image.FromFile(ofd.FileName);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
