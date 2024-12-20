﻿using QuanLyQuanCafe_NguyenQuangLinh_21103101372.DAO;

namespace QuanLyQuanCafe_NguyenQuangLinh_21103101372
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
        bool Login(string userName, string passWord)
        {

            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel ) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            } 
                
        }
    }
}
