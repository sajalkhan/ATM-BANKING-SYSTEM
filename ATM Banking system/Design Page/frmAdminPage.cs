using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Banking_system
{
    public partial class frmAdminPage : Form
    {
        public string Name;
        public frmAdminPage()
        {
            InitializeComponent();
        }

        private void login_page_english_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2,"Logout");

            DAL.User user = new DAL.User();
            cmbView_account_info.DataSource = user.Select().Tables[0];
            cmbView_account_info.DisplayMember = "id";
            cmbView_account_info.ValueMember = "id";
            cmbView_account_info.SelectedValue = -1;


            txtName.Text += Name;
            Show_Gridview();
        }

        public void Show_Gridview()
        {
            DAL.User user = new DAL.User();
            var ds = user.Select();
            if (ds == null) return;

            dataGridView1.DataSource = user.Select().Tables[0];
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            new frmAdminPageOpenAccount(this.Show_Gridview).Show();
            //open.Myparent = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("R u Sure?", "Delete confermation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.No || dr==DialogResult.Cancel) return;

            DAL.User user = new DAL.User();
            DAL.Info info = new DAL.Info();

            int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            user.Id = Id;
            info.Id = Id;

            if(info.Delete() && user.Delete())
            {
                Show_Gridview();
            }
            else
            {
                MessageBox.Show(user.Error+info.Error);
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;

            frmAdmin_EditAccount edit = new frmAdmin_EditAccount(this.Show_Gridview);

            edit.Id = (Int32)dataGridView1.SelectedRows[0].Cells["id"].Value;
            edit.Name = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
            edit.Phonenumber = dataGridView1.SelectedRows[0].Cells["phoneNumber"].Value.ToString();
            edit.Address = dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();
            edit.Balance = (double)dataGridView1.SelectedRows[0].Cells["balance"].Value;
            edit.Show();
        }
    }
}