namespace QuanLyQuanCafe_NguyenQuangLinh_21103101372
{
    partial class fAdmin
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
            tpTable = new TabPage();
            panel11 = new Panel();
            panel21 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel13 = new Panel();
            txbTableName = new TextBox();
            label5 = new Label();
            panel14 = new Panel();
            txbTableID = new TextBox();
            label6 = new Label();
            panel19 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            panel20 = new Panel();
            dtgvTable = new DataGridView();
            tbFoodCategory = new TabPage();
            panel12 = new Panel();
            panel15 = new Panel();
            textBox2 = new TextBox();
            label7 = new Label();
            panel16 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            panel17 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            panel18 = new Panel();
            dtgvCategory = new DataGridView();
            tpFood = new TabPage();
            panel5 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel6 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tpBill = new TabPage();
            panel2 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel1 = new Panel();
            dtgvBill = new DataGridView();
            tcAdmin = new TabControl();
            tpAccount = new TabPage();
            panel23 = new Panel();
            btnResetPassword = new Button();
            panel25 = new Panel();
            cbAccountType = new ComboBox();
            label10 = new Label();
            panel26 = new Panel();
            txbDisplayName = new TextBox();
            label11 = new Label();
            panel27 = new Panel();
            txbUserName = new TextBox();
            label12 = new Label();
            panel28 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            panel29 = new Panel();
            dtgvAccount = new DataGridView();
            tpTable.SuspendLayout();
            panel11.SuspendLayout();
            panel21.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            tbFoodCategory.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            tpFood.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tcAdmin.SuspendLayout();
            tpAccount.SuspendLayout();
            panel23.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel28.SuspendLayout();
            panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel11);
            tpTable.Controls.Add(panel19);
            tpTable.Controls.Add(panel20);
            tpTable.Location = new Point(4, 24);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(746, 570);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            tpTable.Click += tpTable_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel21);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel14);
            panel11.Location = new Point(384, 85);
            panel11.Name = "panel11";
            panel11.Size = new Size(354, 478);
            panel11.TabIndex = 9;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(10, 113);
            panel21.Name = "panel21";
            panel21.Size = new Size(338, 49);
            panel21.TabIndex = 4;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(177, 13);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(150, 23);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 12);
            label9.Name = "label9";
            label9.Size = new Size(124, 24);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái :";
            // 
            // panel13
            // 
            panel13.Controls.Add(txbTableName);
            panel13.Controls.Add(label5);
            panel13.Location = new Point(10, 58);
            panel13.Name = "panel13";
            panel13.Size = new Size(338, 49);
            panel13.TabIndex = 3;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(177, 13);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(150, 23);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(105, 24);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn :";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbTableID);
            panel14.Controls.Add(label6);
            panel14.Location = new Point(10, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(338, 49);
            panel14.TabIndex = 2;
            // 
            // txbTableID
            // 
            txbTableID.Location = new Point(177, 13);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(150, 23);
            txbTableID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(49, 24);
            label6.TabIndex = 0;
            label6.Text = "ID : ";
            // 
            // panel19
            // 
            panel19.Controls.Add(btnShowTable);
            panel19.Controls.Add(btnEditTable);
            panel19.Controls.Add(btnDeleteTable);
            panel19.Controls.Add(btnAddTable);
            panel19.Location = new Point(9, 8);
            panel19.Name = "panel19";
            panel19.Size = new Size(361, 71);
            panel19.TabIndex = 8;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(255, 11);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(75, 48);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(174, 11);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(75, 48);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(93, 11);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(75, 48);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xoá";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(12, 11);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(75, 48);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            panel20.Controls.Add(dtgvTable);
            panel20.Location = new Point(9, 85);
            panel20.Name = "panel20";
            panel20.Size = new Size(361, 478);
            panel20.TabIndex = 7;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(6, 10);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.Size = new Size(355, 478);
            dtgvTable.TabIndex = 0;
            // 
            // tbFoodCategory
            // 
            tbFoodCategory.Controls.Add(panel12);
            tbFoodCategory.Controls.Add(panel17);
            tbFoodCategory.Controls.Add(panel18);
            tbFoodCategory.Location = new Point(4, 24);
            tbFoodCategory.Name = "tbFoodCategory";
            tbFoodCategory.Padding = new Padding(3);
            tbFoodCategory.Size = new Size(746, 570);
            tbFoodCategory.TabIndex = 2;
            tbFoodCategory.Text = "Danh mục";
            tbFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel16);
            panel12.Location = new Point(384, 95);
            panel12.Name = "panel12";
            panel12.Size = new Size(354, 468);
            panel12.TabIndex = 6;
            // 
            // panel15
            // 
            panel15.Controls.Add(textBox2);
            panel15.Controls.Add(label7);
            panel15.Location = new Point(10, 58);
            panel15.Name = "panel15";
            panel15.Size = new Size(338, 49);
            panel15.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(168, 24);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục :";
            // 
            // panel16
            // 
            panel16.Controls.Add(txbCategoryID);
            panel16.Controls.Add(label8);
            panel16.Location = new Point(10, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(338, 49);
            panel16.TabIndex = 2;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(177, 13);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(150, 23);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 13);
            label8.Name = "label8";
            label8.Size = new Size(49, 24);
            label8.TabIndex = 0;
            label8.Text = "ID : ";
            // 
            // panel17
            // 
            panel17.Controls.Add(btnShowCategory);
            panel17.Controls.Add(btnEditCategory);
            panel17.Controls.Add(btnDeleteCategory);
            panel17.Controls.Add(btnAddCategory);
            panel17.Location = new Point(9, 8);
            panel17.Name = "panel17";
            panel17.Size = new Size(361, 71);
            panel17.TabIndex = 5;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(255, 11);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(75, 48);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(174, 11);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(75, 48);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(93, 11);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(75, 48);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Xoá";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(12, 11);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 48);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            panel18.Controls.Add(dtgvCategory);
            panel18.Location = new Point(9, 85);
            panel18.Name = "panel18";
            panel18.Size = new Size(361, 478);
            panel18.TabIndex = 4;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(6, 10);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.Size = new Size(355, 478);
            dtgvCategory.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 24);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(746, 570);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbSearchFoodName);
            panel5.Controls.Add(btnSearchFood);
            panel5.Location = new Point(389, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(351, 71);
            panel5.TabIndex = 3;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(10, 25);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(257, 23);
            txbSearchFoodName.TabIndex = 3;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(273, 11);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(75, 48);
            btnSearchFood.TabIndex = 2;
            btnSearchFood.Text = "Tìm";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(389, 86);
            panel6.Name = "panel6";
            panel6.Size = new Size(354, 478);
            panel6.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(10, 168);
            panel10.Name = "panel10";
            panel10.Size = new Size(338, 49);
            panel10.TabIndex = 5;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(136, 12);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(189, 23);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(56, 24);
            label4.TabIndex = 0;
            label4.Text = "Giá :";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(10, 113);
            panel9.Name = "panel9";
            panel9.Size = new Size(338, 49);
            panel9.TabIndex = 4;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(136, 16);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(191, 23);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(132, 24);
            label3.TabIndex = 0;
            label3.Text = "Danh mục : ";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(10, 58);
            panel8.Name = "panel8";
            panel8.Size = new Size(338, 49);
            panel8.TabIndex = 3;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(137, 13);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(190, 23);
            txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên món :";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(10, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(338, 49);
            panel7.TabIndex = 2;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(137, 13);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(190, 23);
            txbFoodID.TabIndex = 1;
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(49, 24);
            label1.TabIndex = 0;
            label1.Text = "ID : ";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(14, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 71);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(255, 11);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(75, 48);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(174, 11);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(75, 48);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(93, 11);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(75, 48);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xoá";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(12, 11);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 48);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(14, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 478);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(6, 10);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.Size = new Size(355, 478);
            dtgvFood.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 24);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(746, 570);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh Thu";
            tpBill.UseVisualStyleBackColor = true;
            tpBill.Click += tabPage1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewBill);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(6, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(723, 44);
            panel2.TabIndex = 3;
            // 
            // btnViewBill
            // 
            btnViewBill.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewBill.Location = new Point(318, 6);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(92, 29);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(459, 12);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(200, 23);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(61, 12);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(200, 23);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(6, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 509);
            panel1.TabIndex = 2;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.Size = new Size(717, 506);
            dtgvBill.TabIndex = 0;
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tbFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Location = new Point(26, 23);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(754, 598);
            tcAdmin.TabIndex = 0;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel23);
            tpAccount.Controls.Add(panel28);
            tpAccount.Controls.Add(panel29);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(746, 570);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnResetPassword);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel26);
            panel23.Controls.Add(panel27);
            panel23.Location = new Point(384, 85);
            panel23.Name = "panel23";
            panel23.Size = new Size(354, 478);
            panel23.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(133, 168);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(104, 48);
            btnResetPassword.TabIndex = 5;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel25
            // 
            panel25.Controls.Add(cbAccountType);
            panel25.Controls.Add(label10);
            panel25.Location = new Point(10, 113);
            panel25.Name = "panel25";
            panel25.Size = new Size(338, 49);
            panel25.TabIndex = 4;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(162, 16);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(165, 23);
            cbAccountType.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 12);
            label10.Name = "label10";
            label10.Size = new Size(165, 24);
            label10.TabIndex = 0;
            label10.Text = "Loại tài khoản :";
            // 
            // panel26
            // 
            panel26.Controls.Add(txbDisplayName);
            panel26.Controls.Add(label11);
            panel26.Location = new Point(10, 58);
            panel26.Name = "panel26";
            panel26.Size = new Size(338, 49);
            panel26.TabIndex = 3;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(162, 13);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(165, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 12);
            label11.Name = "label11";
            label11.Size = new Size(141, 24);
            label11.TabIndex = 0;
            label11.Text = "Tên hiển thị :";
            // 
            // panel27
            // 
            panel27.Controls.Add(txbUserName);
            panel27.Controls.Add(label12);
            panel27.Location = new Point(10, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(338, 49);
            panel27.TabIndex = 2;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(162, 13);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(165, 23);
            txbUserName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 13);
            label12.Name = "label12";
            label12.Size = new Size(160, 24);
            label12.TabIndex = 0;
            label12.Text = "Tên tài khoản :";
            // 
            // panel28
            // 
            panel28.Controls.Add(btnShowAccount);
            panel28.Controls.Add(btnEditAccount);
            panel28.Controls.Add(btnDeleteAccount);
            panel28.Controls.Add(btnAddAccount);
            panel28.Location = new Point(9, 8);
            panel28.Name = "panel28";
            panel28.Size = new Size(361, 71);
            panel28.TabIndex = 5;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(255, 11);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(75, 48);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(174, 11);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(75, 48);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(93, 11);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(75, 48);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xoá";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(12, 11);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(75, 48);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // panel29
            // 
            panel29.Controls.Add(dtgvAccount);
            panel29.Location = new Point(9, 85);
            panel29.Name = "panel29";
            panel29.Size = new Size(361, 478);
            panel29.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(6, 10);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.Size = new Size(355, 478);
            dtgvAccount.TabIndex = 0;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 646);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            Text = "Admin";
            Load += fAdmin_Load;
            tpTable.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            tbFoodCategory.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            tpFood.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tcAdmin.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel28.ResumeLayout(false);
            panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpTable;
        private TabPage tbFoodCategory;
        private TabPage tpFood;
        private TabPage tpBill;
        private Panel panel2;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel1;
        private DataGridView dtgvBill;
        private TabControl tcAdmin;
        private TabPage tpAccount;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel3;
        private DataGridView dtgvFood;
        private Button btnSearchFood;
        private Button btnShowFood;
        private TextBox txbSearchFoodName;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label1;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel9;
        private ComboBox cbFoodCategory;
        private Label label3;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel12;
        private Panel panel15;
        private TextBox textBox2;
        private Label label7;
        private Panel panel16;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel17;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel18;
        private DataGridView dtgvCategory;
        private TextBox textBox4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel23;
        private Panel panel25;
        private ComboBox cbAccountType;
        private Label label10;
        private Panel panel26;
        private TextBox txbDisplayName;
        private Label label11;
        private Panel panel27;
        private TextBox txbUserName;
        private Label label12;
        private Panel panel28;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Panel panel29;
        private DataGridView dtgvAccount;
        private Button btnResetPassword;
        private Panel panel11;
        private Panel panel21;
        private ComboBox cbTableStatus;
        private Label label9;
        private Panel panel13;
        private TextBox txbTableName;
        private Label label5;
        private Panel panel14;
        private TextBox txbTableID;
        private Label label6;
        private Panel panel19;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Panel panel20;
        private DataGridView dtgvTable;
    }
}