namespace QuanLyQuanCafe_NguyenQuangLinh_21103101372
{
    partial class fAccountProfile
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
            panel1 = new Panel();
            btnExit = new Button();
            btnUpdate = new Button();
            panel6 = new Panel();
            txbReEnterPass = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbNewPass = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbPassWord = new TextBox();
            txtPassWord = new Label();
            panel3 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(21, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 411);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(266, 332);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(171, 52);
            btnExit.TabIndex = 7;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(40, 332);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 52);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbReEnterPass);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(17, 260);
            panel6.Name = "panel6";
            panel6.Size = new Size(451, 55);
            panel6.TabIndex = 5;
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.Location = new Point(214, 22);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(218, 23);
            txbReEnterPass.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 21);
            label4.Name = "label4";
            label4.Size = new Size(103, 24);
            label4.TabIndex = 0;
            label4.Text = "Nhập lại :";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbNewPass);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(17, 199);
            panel5.Name = "panel5";
            panel5.Size = new Size(451, 55);
            panel5.TabIndex = 4;
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(214, 22);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(218, 23);
            txbNewPass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 21);
            label3.Name = "label3";
            label3.Size = new Size(160, 24);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu mới :";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbPassWord);
            panel4.Controls.Add(txtPassWord);
            panel4.Location = new Point(17, 138);
            panel4.Name = "panel4";
            panel4.Size = new Size(451, 55);
            panel4.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(214, 22);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(218, 23);
            txbPassWord.TabIndex = 1;
            // 
            // txtPassWord
            // 
            txtPassWord.AutoSize = true;
            txtPassWord.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassWord.Location = new Point(19, 21);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(115, 24);
            txtPassWord.TabIndex = 0;
            txtPassWord.Text = "Mật khẩu :";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbDisplayName);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(17, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 55);
            panel3.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(214, 22);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(218, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 21);
            label2.Name = "label2";
            label2.Size = new Size(141, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị :";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(17, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 55);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(214, 22);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(218, 23);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(175, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập :";
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(526, 450);
            Controls.Add(panel1);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel2;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel6;
        private TextBox txbReEnterPass;
        private Label label4;
        private Panel panel5;
        private TextBox txbNewPass;
        private Label label3;
        private Panel panel4;
        private TextBox txbPassWord;
        private Label txtPassWord;
        private Button btnExit;
        private Button btnUpdate;
    }
}