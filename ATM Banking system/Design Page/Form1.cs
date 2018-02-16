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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip T = new ToolTip();
            T.SetToolTip(exit_button,"Close");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void English_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Button b = (Button)sender;
            if(b==English_Button) new frmLoginPageEnglish().ShowDialog();
            if (b == btnBangla) MessageBox.Show("Under Construction!!");
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
