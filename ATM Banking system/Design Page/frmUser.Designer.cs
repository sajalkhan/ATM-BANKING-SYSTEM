namespace ATM_Banking_system
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransferMoney = new System.Windows.Forms.Button();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.btnBillpay = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.Label();
            this.user_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(232, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(386, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(128, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select A Transaction";
            // 
            // btnTransferMoney
            // 
            this.btnTransferMoney.BackColor = System.Drawing.Color.Navy;
            this.btnTransferMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransferMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferMoney.ForeColor = System.Drawing.Color.Turquoise;
            this.btnTransferMoney.Location = new System.Drawing.Point(24, 269);
            this.btnTransferMoney.Name = "btnTransferMoney";
            this.btnTransferMoney.Size = new System.Drawing.Size(180, 40);
            this.btnTransferMoney.TabIndex = 0;
            this.btnTransferMoney.Text = "Transfer";
            this.btnTransferMoney.UseVisualStyleBackColor = false;
            this.btnTransferMoney.Click += new System.EventHandler(this.btnTransferMoney_Click);
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.BackColor = System.Drawing.Color.Navy;
            this.btnDepositMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepositMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositMoney.ForeColor = System.Drawing.Color.Turquoise;
            this.btnDepositMoney.Location = new System.Drawing.Point(24, 324);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(180, 40);
            this.btnDepositMoney.TabIndex = 2;
            this.btnDepositMoney.Text = "Deposit Money";
            this.btnDepositMoney.UseVisualStyleBackColor = false;
            this.btnDepositMoney.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Navy;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Turquoise;
            this.btnSetting.Location = new System.Drawing.Point(24, 379);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(180, 40);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.BackColor = System.Drawing.Color.Navy;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.ForeColor = System.Drawing.Color.Turquoise;
            this.btnCheckBalance.Location = new System.Drawing.Point(229, 269);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(180, 40);
            this.btnCheckBalance.TabIndex = 1;
            this.btnCheckBalance.Text = "Balance Enquiry";
            this.btnCheckBalance.UseVisualStyleBackColor = false;
            this.btnCheckBalance.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.BackColor = System.Drawing.Color.Navy;
            this.btnWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWithdrawMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawMoney.ForeColor = System.Drawing.Color.Turquoise;
            this.btnWithdrawMoney.Location = new System.Drawing.Point(229, 324);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(180, 40);
            this.btnWithdrawMoney.TabIndex = 3;
            this.btnWithdrawMoney.Text = "Withdraw Money";
            this.btnWithdrawMoney.UseVisualStyleBackColor = false;
            this.btnWithdrawMoney.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBillpay
            // 
            this.btnBillpay.BackColor = System.Drawing.Color.Navy;
            this.btnBillpay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillpay.ForeColor = System.Drawing.Color.Turquoise;
            this.btnBillpay.Location = new System.Drawing.Point(229, 379);
            this.btnBillpay.Name = "btnBillpay";
            this.btnBillpay.Size = new System.Drawing.Size(180, 40);
            this.btnBillpay.TabIndex = 5;
            this.btnBillpay.Text = "Bill Pay";
            this.btnBillpay.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Cyan;
            this.txtName.Location = new System.Drawing.Point(209, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 20);
            this.txtName.TabIndex = 23;
            // 
            // txtAdmin
            // 
            this.txtAdmin.AutoSize = true;
            this.txtAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.ForeColor = System.Drawing.Color.Cyan;
            this.txtAdmin.Location = new System.Drawing.Point(158, 10);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(51, 20);
            this.txtAdmin.TabIndex = 22;
            this.txtAdmin.Text = "User :";
            // 
            // user_pic
            // 
            this.user_pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.user_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pic.Image = ((System.Drawing.Image)(resources.GetObject("user_pic.Image")));
            this.user_pic.Location = new System.Drawing.Point(154, 63);
            this.user_pic.Name = "user_pic";
            this.user_pic.Size = new System.Drawing.Size(128, 112);
            this.user_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pic.TabIndex = 19;
            this.user_pic.TabStop = false;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(433, 488);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.btnBillpay);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnWithdrawMoney);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnDepositMoney);
            this.Controls.Add(this.btnTransferMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_pic);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransferMoney;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.Button btnBillpay;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtAdmin;
        private System.Windows.Forms.PictureBox user_pic;
    }
}

