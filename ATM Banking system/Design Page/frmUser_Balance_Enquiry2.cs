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
    public partial class frmUser_Balance_Enquiry2 : Form
    {
        public frmUser_Balance_Enquiry2(string Money)
        {
            InitializeComponent();
            txtMoney.Text = Money+".Tk";

            ToolTip T = new ToolTip();
            T.SetToolTip(picBackButton,"Back");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
           
        }

        private void picBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
