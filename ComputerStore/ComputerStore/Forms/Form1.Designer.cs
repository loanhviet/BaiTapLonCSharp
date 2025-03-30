namespace ComputerStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPageLoaiHang = new TabPage();
            panel3 = new Panel();
            dtvgCategories = new DataGridView();
            panel4 = new Panel();
            label2 = new Label();
            txtCategoriesTen = new TextBox();
            label3 = new Label();
            txtCategoriesSearch = new TextBox();
            btnCategoriesXoa = new Button();
            btnCategoriesSua = new Button();
            btnCategoriesThem = new Button();
            panel5 = new Panel();
            label4 = new Label();
            tabPageSanPham = new TabPage();
            panel6 = new Panel();
            dtvgProduct = new DataGridView();
            panel7 = new Panel();
            cbbProduct = new ComboBox();
            label19 = new Label();
            txtProductGiaBan = new TextBox();
            label17 = new Label();
            txtProductSoLuongTon = new TextBox();
            label18 = new Label();
            txtProductTen = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtProductSearch = new TextBox();
            btnProductXoa = new Button();
            btnProductSua = new Button();
            btnProductThem = new Button();
            panel8 = new Panel();
            label7 = new Label();
            tabPageKhachHang = new TabPage();
            panel12 = new Panel();
            dtvgKhachHang = new DataGridView();
            panel13 = new Panel();
            label11 = new Label();
            txtKhachHangSoDTKH = new TextBox();
            label12 = new Label();
            txtKhachHangDiaChiKH = new TextBox();
            label20 = new Label();
            txtKhachHangTenKH = new TextBox();
            label22 = new Label();
            txtKhachHangSearch = new TextBox();
            btnKhachHangXoa = new Button();
            btnKhachHangSua = new Button();
            btnKhachHangThem = new Button();
            panel14 = new Panel();
            label13 = new Label();
            tabPageHoaDon = new TabPage();
            panel15 = new Panel();
            dataGridView5 = new DataGridView();
            panel16 = new Panel();
            label14 = new Label();
            textBox9 = new TextBox();
            label15 = new Label();
            textBox10 = new TextBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            panel17 = new Panel();
            label16 = new Label();
            tabPageChiTietHoaDon = new TabPage();
            panel9 = new Panel();
            dataGridView1 = new DataGridView();
            panel10 = new Panel();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label21 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel11 = new Panel();
            label23 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageLoaiHang.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgCategories).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tabPageSanPham.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgProduct).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            tabPageKhachHang.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvgKhachHang).BeginInit();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            tabPageHoaDon.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            tabPageChiTietHoaDon.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 24);
            label1.TabIndex = 0;
            label1.Text = "Cửa Hàng Máy Tính";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 490);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageLoaiHang);
            tabControl1.Controls.Add(tabPageSanPham);
            tabControl1.Controls.Add(tabPageKhachHang);
            tabControl1.Controls.Add(tabPageHoaDon);
            tabControl1.Controls.Add(tabPageChiTietHoaDon);
            tabControl1.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(924, 487);
            tabControl1.TabIndex = 0;
            // 
            // tabPageLoaiHang
            // 
            tabPageLoaiHang.BackColor = Color.Transparent;
            tabPageLoaiHang.Controls.Add(panel3);
            tabPageLoaiHang.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPageLoaiHang.Location = new Point(4, 30);
            tabPageLoaiHang.Name = "tabPageLoaiHang";
            tabPageLoaiHang.Padding = new Padding(3);
            tabPageLoaiHang.Size = new Size(916, 453);
            tabPageLoaiHang.TabIndex = 0;
            tabPageLoaiHang.Text = "Loại hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(dtvgCategories);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(913, 449);
            panel3.TabIndex = 2;
            // 
            // dtvgCategories
            // 
            dtvgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgCategories.Location = new Point(255, 56);
            dtvgCategories.Name = "dtvgCategories";
            dtvgCategories.ReadOnly = true;
            dtvgCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvgCategories.Size = new Size(652, 388);
            dtvgCategories.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AntiqueWhite;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtCategoriesTen);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtCategoriesSearch);
            panel4.Controls.Add(btnCategoriesXoa);
            panel4.Controls.Add(btnCategoriesSua);
            panel4.Controls.Add(btnCategoriesThem);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(249, 399);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 114);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Tên phân loại";
            // 
            // txtCategoriesTen
            // 
            txtCategoriesTen.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCategoriesTen.Location = new Point(105, 114);
            txtCategoriesTen.Name = "txtCategoriesTen";
            txtCategoriesTen.Size = new Size(118, 22);
            txtCategoriesTen.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 70);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Tìm kiếm";
            // 
            // txtCategoriesSearch
            // 
            txtCategoriesSearch.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCategoriesSearch.Location = new Point(105, 63);
            txtCategoriesSearch.Name = "txtCategoriesSearch";
            txtCategoriesSearch.Size = new Size(118, 22);
            txtCategoriesSearch.TabIndex = 3;
            // 
            // btnCategoriesXoa
            // 
            btnCategoriesXoa.Location = new Point(171, 344);
            btnCategoriesXoa.Name = "btnCategoriesXoa";
            btnCategoriesXoa.Size = new Size(75, 41);
            btnCategoriesXoa.TabIndex = 2;
            btnCategoriesXoa.Text = "Xóa";
            btnCategoriesXoa.UseVisualStyleBackColor = true;
            // 
            // btnCategoriesSua
            // 
            btnCategoriesSua.Location = new Point(90, 344);
            btnCategoriesSua.Name = "btnCategoriesSua";
            btnCategoriesSua.Size = new Size(75, 41);
            btnCategoriesSua.TabIndex = 1;
            btnCategoriesSua.Text = "Sửa";
            btnCategoriesSua.UseVisualStyleBackColor = true;
            // 
            // btnCategoriesThem
            // 
            btnCategoriesThem.BackColor = Color.Transparent;
            btnCategoriesThem.Location = new Point(1, 344);
            btnCategoriesThem.Name = "btnCategoriesThem";
            btnCategoriesThem.Size = new Size(75, 41);
            btnCategoriesThem.TabIndex = 0;
            btnCategoriesThem.Text = "Thêm";
            btnCategoriesThem.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.AntiqueWhite;
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(913, 50);
            panel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 15);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 0;
            label4.Text = "Quản lý loại hàng";
            // 
            // tabPageSanPham
            // 
            tabPageSanPham.Controls.Add(panel6);
            tabPageSanPham.Location = new Point(4, 30);
            tabPageSanPham.Name = "tabPageSanPham";
            tabPageSanPham.Padding = new Padding(3);
            tabPageSanPham.Size = new Size(916, 453);
            tabPageSanPham.TabIndex = 1;
            tabPageSanPham.Text = "Mặt hàng";
            tabPageSanPham.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(dtvgProduct);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(913, 449);
            panel6.TabIndex = 2;
            // 
            // dtvgProduct
            // 
            dtvgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgProduct.Location = new Point(255, 56);
            dtvgProduct.Name = "dtvgProduct";
            dtvgProduct.Size = new Size(652, 388);
            dtvgProduct.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.AntiqueWhite;
            panel7.Controls.Add(cbbProduct);
            panel7.Controls.Add(label19);
            panel7.Controls.Add(txtProductGiaBan);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(txtProductSoLuongTon);
            panel7.Controls.Add(label18);
            panel7.Controls.Add(txtProductTen);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(txtProductSearch);
            panel7.Controls.Add(btnProductXoa);
            panel7.Controls.Add(btnProductSua);
            panel7.Controls.Add(btnProductThem);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(249, 399);
            panel7.TabIndex = 2;
            // 
            // cbbProduct
            // 
            cbbProduct.Font = new Font("Times New Roman", 9.75F);
            cbbProduct.FormattingEnabled = true;
            cbbProduct.Location = new Point(105, 110);
            cbbProduct.Name = "cbbProduct";
            cbbProduct.Size = new Size(121, 23);
            cbbProduct.TabIndex = 13;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.Location = new Point(13, 255);
            label19.Name = "label19";
            label19.Size = new Size(51, 15);
            label19.TabIndex = 12;
            label19.Text = "Giá bán";
            // 
            // txtProductGiaBan
            // 
            txtProductGiaBan.Font = new Font("Times New Roman", 9.75F);
            txtProductGiaBan.Location = new Point(102, 252);
            txtProductGiaBan.Name = "txtProductGiaBan";
            txtProductGiaBan.Size = new Size(118, 22);
            txtProductGiaBan.TabIndex = 11;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label17.Location = new Point(13, 209);
            label17.Name = "label17";
            label17.Size = new Size(77, 15);
            label17.TabIndex = 10;
            label17.Text = "Số lượng tồn";
            // 
            // txtProductSoLuongTon
            // 
            txtProductSoLuongTon.Font = new Font("Times New Roman", 9.75F);
            txtProductSoLuongTon.Location = new Point(105, 209);
            txtProductSoLuongTon.Name = "txtProductSoLuongTon";
            txtProductSoLuongTon.Size = new Size(118, 22);
            txtProductSoLuongTon.TabIndex = 9;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.Location = new Point(13, 165);
            label18.Name = "label18";
            label18.Size = new Size(82, 15);
            label18.TabIndex = 8;
            label18.Text = "Tên sản phẩm";
            // 
            // txtProductTen
            // 
            txtProductTen.Font = new Font("Times New Roman", 9.75F);
            txtProductTen.Location = new Point(105, 158);
            txtProductTen.Name = "txtProductTen";
            txtProductTen.Size = new Size(118, 22);
            txtProductTen.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 117);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 6;
            label5.Text = "Phân loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 70);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 4;
            label6.Text = "Tìm kiếm";
            // 
            // txtProductSearch
            // 
            txtProductSearch.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtProductSearch.Location = new Point(105, 63);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(118, 20);
            txtProductSearch.TabIndex = 3;
            // 
            // btnProductXoa
            // 
            btnProductXoa.Location = new Point(171, 344);
            btnProductXoa.Name = "btnProductXoa";
            btnProductXoa.Size = new Size(75, 41);
            btnProductXoa.TabIndex = 2;
            btnProductXoa.Text = "Xóa";
            btnProductXoa.UseVisualStyleBackColor = true;
            // 
            // btnProductSua
            // 
            btnProductSua.Location = new Point(90, 344);
            btnProductSua.Name = "btnProductSua";
            btnProductSua.Size = new Size(75, 41);
            btnProductSua.TabIndex = 1;
            btnProductSua.Text = "Sửa";
            btnProductSua.UseVisualStyleBackColor = true;
            // 
            // btnProductThem
            // 
            btnProductThem.BackColor = Color.Transparent;
            btnProductThem.Location = new Point(1, 344);
            btnProductThem.Name = "btnProductThem";
            btnProductThem.Size = new Size(75, 41);
            btnProductThem.TabIndex = 0;
            btnProductThem.Text = "Thêm";
            btnProductThem.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.AntiqueWhite;
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(913, 50);
            panel8.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 15);
            label7.Name = "label7";
            label7.Size = new Size(151, 21);
            label7.TabIndex = 0;
            label7.Text = "Quản lý mặt hàng";
            // 
            // tabPageKhachHang
            // 
            tabPageKhachHang.Controls.Add(panel12);
            tabPageKhachHang.Location = new Point(4, 30);
            tabPageKhachHang.Name = "tabPageKhachHang";
            tabPageKhachHang.Padding = new Padding(3);
            tabPageKhachHang.Size = new Size(916, 453);
            tabPageKhachHang.TabIndex = 3;
            tabPageKhachHang.Text = "Khách hàng";
            tabPageKhachHang.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(dtvgKhachHang);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(panel14);
            panel12.Location = new Point(2, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(913, 449);
            panel12.TabIndex = 1;
            // 
            // dtvgKhachHang
            // 
            dtvgKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgKhachHang.Location = new Point(255, 56);
            dtvgKhachHang.Name = "dtvgKhachHang";
            dtvgKhachHang.Size = new Size(652, 388);
            dtvgKhachHang.TabIndex = 3;
            // 
            // panel13
            // 
            panel13.BackColor = Color.AntiqueWhite;
            panel13.Controls.Add(label11);
            panel13.Controls.Add(txtKhachHangSoDTKH);
            panel13.Controls.Add(label12);
            panel13.Controls.Add(txtKhachHangDiaChiKH);
            panel13.Controls.Add(label20);
            panel13.Controls.Add(txtKhachHangTenKH);
            panel13.Controls.Add(label22);
            panel13.Controls.Add(txtKhachHangSearch);
            panel13.Controls.Add(btnKhachHangXoa);
            panel13.Controls.Add(btnKhachHangSua);
            panel13.Controls.Add(btnKhachHangThem);
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(0, 50);
            panel13.Name = "panel13";
            panel13.Size = new Size(249, 399);
            panel13.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 260);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 22;
            label11.Text = "Số điện thoại";
            // 
            // txtKhachHangSoDTKH
            // 
            txtKhachHangSoDTKH.Font = new Font("Times New Roman", 9.75F);
            txtKhachHangSoDTKH.Location = new Point(107, 257);
            txtKhachHangSoDTKH.Name = "txtKhachHangSoDTKH";
            txtKhachHangSoDTKH.Size = new Size(118, 22);
            txtKhachHangSoDTKH.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 204);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 20;
            label12.Text = "Địa chỉ";
            // 
            // txtKhachHangDiaChiKH
            // 
            txtKhachHangDiaChiKH.Font = new Font("Times New Roman", 9.75F);
            txtKhachHangDiaChiKH.Location = new Point(110, 204);
            txtKhachHangDiaChiKH.Name = "txtKhachHangDiaChiKH";
            txtKhachHangDiaChiKH.Size = new Size(118, 22);
            txtKhachHangDiaChiKH.TabIndex = 19;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.Location = new Point(9, 150);
            label20.Name = "label20";
            label20.Size = new Size(95, 15);
            label20.TabIndex = 18;
            label20.Text = "Tên khách hàng";
            label20.Click += label20_Click;
            // 
            // txtKhachHangTenKH
            // 
            txtKhachHangTenKH.Font = new Font("Times New Roman", 9.75F);
            txtKhachHangTenKH.Location = new Point(110, 147);
            txtKhachHangTenKH.Name = "txtKhachHangTenKH";
            txtKhachHangTenKH.Size = new Size(118, 22);
            txtKhachHangTenKH.TabIndex = 17;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label22.Location = new Point(20, 99);
            label22.Name = "label22";
            label22.Size = new Size(56, 15);
            label22.TabIndex = 15;
            label22.Text = "Tìm kiếm";
            // 
            // txtKhachHangSearch
            // 
            txtKhachHangSearch.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtKhachHangSearch.Location = new Point(110, 94);
            txtKhachHangSearch.Name = "txtKhachHangSearch";
            txtKhachHangSearch.Size = new Size(118, 20);
            txtKhachHangSearch.TabIndex = 14;
            // 
            // btnKhachHangXoa
            // 
            btnKhachHangXoa.Location = new Point(171, 344);
            btnKhachHangXoa.Name = "btnKhachHangXoa";
            btnKhachHangXoa.Size = new Size(75, 41);
            btnKhachHangXoa.TabIndex = 2;
            btnKhachHangXoa.Text = "Xóa";
            btnKhachHangXoa.UseVisualStyleBackColor = true;
            // 
            // btnKhachHangSua
            // 
            btnKhachHangSua.Location = new Point(90, 344);
            btnKhachHangSua.Name = "btnKhachHangSua";
            btnKhachHangSua.Size = new Size(75, 41);
            btnKhachHangSua.TabIndex = 1;
            btnKhachHangSua.Text = "Sửa";
            btnKhachHangSua.UseVisualStyleBackColor = true;
            // 
            // btnKhachHangThem
            // 
            btnKhachHangThem.BackColor = Color.Transparent;
            btnKhachHangThem.Location = new Point(1, 344);
            btnKhachHangThem.Name = "btnKhachHangThem";
            btnKhachHangThem.Size = new Size(75, 41);
            btnKhachHangThem.TabIndex = 0;
            btnKhachHangThem.Text = "Thêm";
            btnKhachHangThem.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            panel14.BackColor = Color.AntiqueWhite;
            panel14.Controls.Add(label13);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(913, 50);
            panel14.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(360, 15);
            label13.Name = "label13";
            label13.Size = new Size(168, 21);
            label13.TabIndex = 0;
            label13.Text = "Quản lý khách hàng";
            // 
            // tabPageHoaDon
            // 
            tabPageHoaDon.Controls.Add(panel15);
            tabPageHoaDon.Location = new Point(4, 30);
            tabPageHoaDon.Name = "tabPageHoaDon";
            tabPageHoaDon.Padding = new Padding(3);
            tabPageHoaDon.Size = new Size(916, 453);
            tabPageHoaDon.TabIndex = 4;
            tabPageHoaDon.Text = "Hóa đơn";
            tabPageHoaDon.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            panel15.Controls.Add(dataGridView5);
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(panel17);
            panel15.Location = new Point(2, 2);
            panel15.Name = "panel15";
            panel15.Size = new Size(913, 449);
            panel15.TabIndex = 2;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(255, 56);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(652, 388);
            dataGridView5.TabIndex = 3;
            // 
            // panel16
            // 
            panel16.BackColor = Color.AntiqueWhite;
            panel16.Controls.Add(label14);
            panel16.Controls.Add(textBox9);
            panel16.Controls.Add(label15);
            panel16.Controls.Add(textBox10);
            panel16.Controls.Add(button13);
            panel16.Controls.Add(button14);
            panel16.Controls.Add(button15);
            panel16.Dock = DockStyle.Left;
            panel16.Location = new Point(0, 50);
            panel16.Name = "panel16";
            panel16.Size = new Size(249, 399);
            panel16.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 114);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 6;
            label14.Text = "Tên phân loại";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(105, 114);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(118, 22);
            textBox9.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(4, 70);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 4;
            label15.Text = "Tìm kiếm";
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(105, 63);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(118, 22);
            textBox10.TabIndex = 3;
            // 
            // button13
            // 
            button13.Location = new Point(171, 344);
            button13.Name = "button13";
            button13.Size = new Size(75, 41);
            button13.TabIndex = 2;
            button13.Text = "Xóa";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(90, 344);
            button14.Name = "button14";
            button14.Size = new Size(75, 41);
            button14.TabIndex = 1;
            button14.Text = "Sửa";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.BackColor = Color.Transparent;
            button15.Location = new Point(1, 344);
            button15.Name = "button15";
            button15.Size = new Size(75, 41);
            button15.TabIndex = 0;
            button15.Text = "Thêm";
            button15.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            panel17.BackColor = Color.AntiqueWhite;
            panel17.Controls.Add(label16);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(913, 50);
            panel17.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(360, 15);
            label16.Name = "label16";
            label16.Size = new Size(135, 21);
            label16.TabIndex = 0;
            label16.Text = "Chi tiết hóa đơn";
            // 
            // tabPageChiTietHoaDon
            // 
            tabPageChiTietHoaDon.Controls.Add(panel9);
            tabPageChiTietHoaDon.Location = new Point(4, 30);
            tabPageChiTietHoaDon.Name = "tabPageChiTietHoaDon";
            tabPageChiTietHoaDon.Padding = new Padding(3);
            tabPageChiTietHoaDon.Size = new Size(916, 453);
            tabPageChiTietHoaDon.TabIndex = 5;
            tabPageChiTietHoaDon.Text = "Chi tiết hóa đơn";
            tabPageChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(dataGridView1);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel11);
            panel9.Location = new Point(2, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(913, 449);
            panel9.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(255, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(652, 388);
            dataGridView1.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = Color.AntiqueWhite;
            panel10.Controls.Add(label8);
            panel10.Controls.Add(textBox1);
            panel10.Controls.Add(label9);
            panel10.Controls.Add(textBox2);
            panel10.Controls.Add(label10);
            panel10.Controls.Add(textBox3);
            panel10.Controls.Add(label21);
            panel10.Controls.Add(textBox4);
            panel10.Controls.Add(button1);
            panel10.Controls.Add(button2);
            panel10.Controls.Add(button3);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 50);
            panel10.Name = "panel10";
            panel10.Size = new Size(249, 399);
            panel10.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 260);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 22;
            label8.Text = "Số điện thoại";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 9.75F);
            textBox1.Location = new Point(107, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 22);
            textBox1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 204);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 20;
            label9.Text = "Địa chỉ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 9.75F);
            textBox2.Location = new Point(110, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 22);
            textBox2.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 150);
            label10.Name = "label10";
            label10.Size = new Size(95, 15);
            label10.TabIndex = 18;
            label10.Text = "Tên khách hàng";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 9.75F);
            textBox3.Location = new Point(110, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 22);
            textBox3.TabIndex = 17;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.Location = new Point(20, 99);
            label21.Name = "label21";
            label21.Size = new Size(56, 15);
            label21.TabIndex = 15;
            label21.Text = "Tìm kiếm";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBox4.Location = new Point(110, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 20);
            textBox4.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(171, 344);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 2;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(90, 344);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Location = new Point(1, 344);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 0;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.AntiqueWhite;
            panel11.Controls.Add(label23);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(913, 50);
            panel11.TabIndex = 1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(360, 15);
            label23.Name = "label23";
            label23.Size = new Size(168, 21);
            label23.TabIndex = 0;
            label23.Text = "Quản lý khách hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 550);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cửa Hàng Máy Tính";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageLoaiHang.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvgCategories).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tabPageSanPham.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvgProduct).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            tabPageKhachHang.ResumeLayout(false);
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvgKhachHang).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            tabPageHoaDon.ResumeLayout(false);
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            tabPageChiTietHoaDon.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPageLoaiHang;
        private Panel panel3;
        private DataGridView dtvgCategories;
        private Panel panel4;
        private Label label2;
        private TextBox txtCategoriesTen;
        private Label label3;
        private TextBox txtCategoriesSearch;
        private Button btnCategoriesXoa;
        private Button btnCategoriesSua;
        private Button btnCategoriesThem;
        private Panel panel5;
        private Label label4;
        private TabPage tabPageSanPham;
        private Panel panel6;
        private DataGridView dtvgProduct;
        private Panel panel7;
        private ComboBox cbbProduct;
        private Label label19;
        private TextBox txtProductGiaBan;
        private Label label17;
        private TextBox txtProductSoLuongTon;
        private Label label18;
        private TextBox txtProductTen;
        private Label label5;
        private Label label6;
        private TextBox txtProductSearch;
        private Button btnProductXoa;
        private Button btnProductSua;
        private Button btnProductThem;
        private Panel panel8;
        private Label label7;
        private TabPage tabPageKhachHang;
        private Panel panel12;
        private DataGridView dtvgKhachHang;
        private Panel panel13;
        private Label label11;
        private TextBox txtKhachHangSoDTKH;
        private Label label12;
        private TextBox txtKhachHangDiaChiKH;
        private Label label20;
        private TextBox txtKhachHangTenKH;
        private Label label22;
        private TextBox txtKhachHangSearch;
        private Button btnKhachHangXoa;
        private Button btnKhachHangSua;
        private Button btnKhachHangThem;
        private Panel panel14;
        private Label label13;
        private TabPage tabPageHoaDon;
        private Panel panel15;
        private DataGridView dataGridView5;
        private Panel panel16;
        private Label label14;
        private TextBox textBox9;
        private Label label15;
        private TextBox textBox10;
        private Button button13;
        private Button button14;
        private Button button15;
        private Panel panel17;
        private Label label16;
        private TabPage tabPageChiTietHoaDon;
        private Panel panel9;
        private DataGridView dataGridView1;
        private Panel panel10;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox3;
        private Label label21;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel11;
        private Label label23;
    }
}
