namespace DAMFINAL.PL
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
            tabControl1 = new TabControl();
            tabThongKe = new TabPage();
            dgv_thongkemonhoc = new DataGridView();
            dgv_thongkebuoitrogiang = new DataGridView();
            dgv_thongketrogiang = new DataGridView();
            dgv_thongkegiangvien = new DataGridView();
            tabGiangVien = new TabPage();
            txt_ngaysinhgiangvien = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cb_trangthaigiangvien = new ComboBox();
            txt_diachigiangvien = new TextBox();
            txt_tengiangvien = new TextBox();
            label1 = new Label();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_themgiangvien = new Button();
            dgv_giangvien = new DataGridView();
            tabTroGiang = new TabPage();
            txt_ngaysinhtrogiang = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cb_trangthaitrogiang = new ComboBox();
            txt_diachitrogiang = new TextBox();
            txt_tentrogiang = new TextBox();
            label8 = new Label();
            btn_xoatrogiang = new Button();
            btn_suatrogiang = new Button();
            btn_themtrogiang = new Button();
            dgv_trogiang = new DataGridView();
            tabMonHoc = new TabPage();
            cb_giangvienphutrach = new ComboBox();
            cb_sotinchi = new ComboBox();
            cb_trangthai = new ComboBox();
            btn_xoamonhoc = new Button();
            btn_suamonhoc = new Button();
            btn_themmonhoc = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txt_tenmonhoc = new TextBox();
            label12 = new Label();
            dgv_monhoc = new DataGridView();
            tabBuoiTroGiang = new TabPage();
            cb_stt = new ComboBox();
            cb_trangthaibuoitrogiang = new ComboBox();
            cb_trogiangmonhoc = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            cb_monhoctrogiang = new ComboBox();
            label16 = new Label();
            btn_xoabuoitrogiang = new Button();
            btn_suabuoitrogiang = new Button();
            btn_thembuoitrogiang = new Button();
            dgv_buoitrogiang = new DataGridView();
            tabControl1.SuspendLayout();
            tabThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_thongkemonhoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_thongkebuoitrogiang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_thongketrogiang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_thongkegiangvien).BeginInit();
            tabGiangVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_giangvien).BeginInit();
            tabTroGiang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_trogiang).BeginInit();
            tabMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_monhoc).BeginInit();
            tabBuoiTroGiang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_buoitrogiang).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabThongKe);
            tabControl1.Controls.Add(tabGiangVien);
            tabControl1.Controls.Add(tabTroGiang);
            tabControl1.Controls.Add(tabMonHoc);
            tabControl1.Controls.Add(tabBuoiTroGiang);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1066, 524);
            tabControl1.TabIndex = 0;
            // 
            // tabThongKe
            // 
            tabThongKe.Controls.Add(dgv_thongkemonhoc);
            tabThongKe.Controls.Add(dgv_thongkebuoitrogiang);
            tabThongKe.Controls.Add(dgv_thongketrogiang);
            tabThongKe.Controls.Add(dgv_thongkegiangvien);
            tabThongKe.Location = new Point(4, 24);
            tabThongKe.Name = "tabThongKe";
            tabThongKe.Padding = new Padding(3);
            tabThongKe.Size = new Size(1058, 496);
            tabThongKe.TabIndex = 0;
            tabThongKe.Text = "Thống Kê";
            tabThongKe.UseVisualStyleBackColor = true;
            // 
            // dgv_thongkemonhoc
            // 
            dgv_thongkemonhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thongkemonhoc.Location = new Point(540, 279);
            dgv_thongkemonhoc.Name = "dgv_thongkemonhoc";
            dgv_thongkemonhoc.Size = new Size(512, 211);
            dgv_thongkemonhoc.TabIndex = 3;
            // 
            // dgv_thongkebuoitrogiang
            // 
            dgv_thongkebuoitrogiang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thongkebuoitrogiang.Location = new Point(22, 279);
            dgv_thongkebuoitrogiang.Name = "dgv_thongkebuoitrogiang";
            dgv_thongkebuoitrogiang.Size = new Size(512, 211);
            dgv_thongkebuoitrogiang.TabIndex = 2;
            // 
            // dgv_thongketrogiang
            // 
            dgv_thongketrogiang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thongketrogiang.Location = new Point(540, 29);
            dgv_thongketrogiang.Name = "dgv_thongketrogiang";
            dgv_thongketrogiang.Size = new Size(512, 211);
            dgv_thongketrogiang.TabIndex = 1;
            // 
            // dgv_thongkegiangvien
            // 
            dgv_thongkegiangvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thongkegiangvien.Location = new Point(22, 29);
            dgv_thongkegiangvien.Name = "dgv_thongkegiangvien";
            dgv_thongkegiangvien.Size = new Size(512, 211);
            dgv_thongkegiangvien.TabIndex = 0;
            // 
            // tabGiangVien
            // 
            tabGiangVien.Controls.Add(txt_ngaysinhgiangvien);
            tabGiangVien.Controls.Add(label4);
            tabGiangVien.Controls.Add(label3);
            tabGiangVien.Controls.Add(label2);
            tabGiangVien.Controls.Add(cb_trangthaigiangvien);
            tabGiangVien.Controls.Add(txt_diachigiangvien);
            tabGiangVien.Controls.Add(txt_tengiangvien);
            tabGiangVien.Controls.Add(label1);
            tabGiangVien.Controls.Add(btn_xoa);
            tabGiangVien.Controls.Add(btn_sua);
            tabGiangVien.Controls.Add(btn_themgiangvien);
            tabGiangVien.Controls.Add(dgv_giangvien);
            tabGiangVien.Location = new Point(4, 24);
            tabGiangVien.Name = "tabGiangVien";
            tabGiangVien.Padding = new Padding(3);
            tabGiangVien.Size = new Size(1058, 496);
            tabGiangVien.TabIndex = 1;
            tabGiangVien.Text = "Giảng Viên";
            tabGiangVien.UseVisualStyleBackColor = true;
            // 
            // txt_ngaysinhgiangvien
            // 
            txt_ngaysinhgiangvien.Location = new Point(118, 119);
            txt_ngaysinhgiangvien.Name = "txt_ngaysinhgiangvien";
            txt_ngaysinhgiangvien.Size = new Size(318, 23);
            txt_ngaysinhgiangvien.TabIndex = 12;
            txt_ngaysinhgiangvien.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 165);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 11;
            label4.Text = "Trạng Thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 84);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 10;
            label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 122);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Ngày Sinh";
            // 
            // cb_trangthaigiangvien
            // 
            cb_trangthaigiangvien.FormattingEnabled = true;
            cb_trangthaigiangvien.Location = new Point(118, 162);
            cb_trangthaigiangvien.Name = "cb_trangthaigiangvien";
            cb_trangthaigiangvien.Size = new Size(317, 23);
            cb_trangthaigiangvien.TabIndex = 8;
            // 
            // txt_diachigiangvien
            // 
            txt_diachigiangvien.Location = new Point(117, 81);
            txt_diachigiangvien.Name = "txt_diachigiangvien";
            txt_diachigiangvien.Size = new Size(318, 23);
            txt_diachigiangvien.TabIndex = 6;
            // 
            // txt_tengiangvien
            // 
            txt_tengiangvien.Location = new Point(115, 34);
            txt_tengiangvien.Name = "txt_tengiangvien";
            txt_tengiangvien.Size = new Size(318, 23);
            txt_tengiangvien.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 4;
            label1.Text = "Tên Giảng Viên";
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(770, 128);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(141, 41);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(770, 81);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(141, 41);
            btn_sua.TabIndex = 2;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_themgiangvien
            // 
            btn_themgiangvien.Location = new Point(770, 34);
            btn_themgiangvien.Name = "btn_themgiangvien";
            btn_themgiangvien.Size = new Size(141, 41);
            btn_themgiangvien.TabIndex = 1;
            btn_themgiangvien.Text = "Thêm";
            btn_themgiangvien.UseVisualStyleBackColor = true;
            btn_themgiangvien.Click += btn_themgiangvien_Click;
            // 
            // dgv_giangvien
            // 
            dgv_giangvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_giangvien.Location = new Point(6, 218);
            dgv_giangvien.Name = "dgv_giangvien";
            dgv_giangvien.Size = new Size(1046, 272);
            dgv_giangvien.TabIndex = 0;
            dgv_giangvien.CellClick += dgv_giangvien_CellClick;
            // 
            // tabTroGiang
            // 
            tabTroGiang.Controls.Add(txt_ngaysinhtrogiang);
            tabTroGiang.Controls.Add(label5);
            tabTroGiang.Controls.Add(label6);
            tabTroGiang.Controls.Add(label7);
            tabTroGiang.Controls.Add(cb_trangthaitrogiang);
            tabTroGiang.Controls.Add(txt_diachitrogiang);
            tabTroGiang.Controls.Add(txt_tentrogiang);
            tabTroGiang.Controls.Add(label8);
            tabTroGiang.Controls.Add(btn_xoatrogiang);
            tabTroGiang.Controls.Add(btn_suatrogiang);
            tabTroGiang.Controls.Add(btn_themtrogiang);
            tabTroGiang.Controls.Add(dgv_trogiang);
            tabTroGiang.Location = new Point(4, 24);
            tabTroGiang.Name = "tabTroGiang";
            tabTroGiang.Padding = new Padding(3);
            tabTroGiang.Size = new Size(1058, 496);
            tabTroGiang.TabIndex = 2;
            tabTroGiang.Text = "Trợ Giảng";
            tabTroGiang.UseVisualStyleBackColor = true;
            // 
            // txt_ngaysinhtrogiang
            // 
            txt_ngaysinhtrogiang.Location = new Point(146, 120);
            txt_ngaysinhtrogiang.Name = "txt_ngaysinhtrogiang";
            txt_ngaysinhtrogiang.Size = new Size(318, 23);
            txt_ngaysinhtrogiang.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 166);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 19;
            label5.Text = "Trạng Thái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 85);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 18;
            label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 123);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 17;
            label7.Text = "Ngày Sinh";
            // 
            // cb_trangthaitrogiang
            // 
            cb_trangthaitrogiang.FormattingEnabled = true;
            cb_trangthaitrogiang.Location = new Point(146, 163);
            cb_trangthaitrogiang.Name = "cb_trangthaitrogiang";
            cb_trangthaitrogiang.Size = new Size(317, 23);
            cb_trangthaitrogiang.TabIndex = 16;
            // 
            // txt_diachitrogiang
            // 
            txt_diachitrogiang.Location = new Point(145, 82);
            txt_diachitrogiang.Name = "txt_diachitrogiang";
            txt_diachitrogiang.Size = new Size(318, 23);
            txt_diachitrogiang.TabIndex = 15;
            // 
            // txt_tentrogiang
            // 
            txt_tentrogiang.Location = new Point(143, 35);
            txt_tentrogiang.Name = "txt_tentrogiang";
            txt_tentrogiang.Size = new Size(318, 23);
            txt_tentrogiang.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 38);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 13;
            label8.Text = "Tên Trợ Giảng";
            // 
            // btn_xoatrogiang
            // 
            btn_xoatrogiang.Location = new Point(837, 129);
            btn_xoatrogiang.Name = "btn_xoatrogiang";
            btn_xoatrogiang.Size = new Size(141, 41);
            btn_xoatrogiang.TabIndex = 6;
            btn_xoatrogiang.Text = "Xóa";
            btn_xoatrogiang.UseVisualStyleBackColor = true;
            btn_xoatrogiang.Click += btn_xoatrogiang_Click;
            // 
            // btn_suatrogiang
            // 
            btn_suatrogiang.Location = new Point(837, 82);
            btn_suatrogiang.Name = "btn_suatrogiang";
            btn_suatrogiang.Size = new Size(141, 41);
            btn_suatrogiang.TabIndex = 5;
            btn_suatrogiang.Text = "Sửa";
            btn_suatrogiang.UseVisualStyleBackColor = true;
            btn_suatrogiang.Click += btn_suatrogiang_Click;
            // 
            // btn_themtrogiang
            // 
            btn_themtrogiang.Location = new Point(837, 35);
            btn_themtrogiang.Name = "btn_themtrogiang";
            btn_themtrogiang.Size = new Size(141, 41);
            btn_themtrogiang.TabIndex = 4;
            btn_themtrogiang.Text = "Thêm";
            btn_themtrogiang.UseVisualStyleBackColor = true;
            btn_themtrogiang.Click += btn_themtrogiang_Click;
            // 
            // dgv_trogiang
            // 
            dgv_trogiang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_trogiang.Location = new Point(6, 222);
            dgv_trogiang.Name = "dgv_trogiang";
            dgv_trogiang.Size = new Size(1046, 268);
            dgv_trogiang.TabIndex = 0;
            dgv_trogiang.CellClick += dgv_trogiang_CellClick;
            // 
            // tabMonHoc
            // 
            tabMonHoc.Controls.Add(cb_giangvienphutrach);
            tabMonHoc.Controls.Add(cb_sotinchi);
            tabMonHoc.Controls.Add(cb_trangthai);
            tabMonHoc.Controls.Add(btn_xoamonhoc);
            tabMonHoc.Controls.Add(btn_suamonhoc);
            tabMonHoc.Controls.Add(btn_themmonhoc);
            tabMonHoc.Controls.Add(label9);
            tabMonHoc.Controls.Add(label10);
            tabMonHoc.Controls.Add(label11);
            tabMonHoc.Controls.Add(txt_tenmonhoc);
            tabMonHoc.Controls.Add(label12);
            tabMonHoc.Controls.Add(dgv_monhoc);
            tabMonHoc.Location = new Point(4, 24);
            tabMonHoc.Name = "tabMonHoc";
            tabMonHoc.Padding = new Padding(3);
            tabMonHoc.Size = new Size(1058, 496);
            tabMonHoc.TabIndex = 3;
            tabMonHoc.Text = "Môn Học";
            tabMonHoc.UseVisualStyleBackColor = true;
            tabMonHoc.Click += tabMonHoc_Click;
            // 
            // cb_giangvienphutrach
            // 
            cb_giangvienphutrach.FormattingEnabled = true;
            cb_giangvienphutrach.Location = new Point(145, 173);
            cb_giangvienphutrach.Name = "cb_giangvienphutrach";
            cb_giangvienphutrach.Size = new Size(317, 23);
            cb_giangvienphutrach.TabIndex = 26;
            // 
            // cb_sotinchi
            // 
            cb_sotinchi.FormattingEnabled = true;
            cb_sotinchi.Location = new Point(145, 89);
            cb_sotinchi.Name = "cb_sotinchi";
            cb_sotinchi.Size = new Size(317, 23);
            cb_sotinchi.TabIndex = 25;
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Location = new Point(145, 127);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(317, 23);
            cb_trangthai.TabIndex = 24;
            // 
            // btn_xoamonhoc
            // 
            btn_xoamonhoc.Location = new Point(776, 136);
            btn_xoamonhoc.Name = "btn_xoamonhoc";
            btn_xoamonhoc.Size = new Size(141, 41);
            btn_xoamonhoc.TabIndex = 23;
            btn_xoamonhoc.Text = "Xóa";
            btn_xoamonhoc.UseVisualStyleBackColor = true;
            btn_xoamonhoc.Click += btn_xoamonhoc_Click;
            // 
            // btn_suamonhoc
            // 
            btn_suamonhoc.Location = new Point(776, 89);
            btn_suamonhoc.Name = "btn_suamonhoc";
            btn_suamonhoc.Size = new Size(141, 41);
            btn_suamonhoc.TabIndex = 22;
            btn_suamonhoc.Text = "Sửa";
            btn_suamonhoc.UseVisualStyleBackColor = true;
            btn_suamonhoc.Click += btn_suamonhoc_Click;
            // 
            // btn_themmonhoc
            // 
            btn_themmonhoc.Location = new Point(776, 42);
            btn_themmonhoc.Name = "btn_themmonhoc";
            btn_themmonhoc.Size = new Size(141, 41);
            btn_themmonhoc.TabIndex = 21;
            btn_themmonhoc.Text = "Thêm";
            btn_themmonhoc.UseVisualStyleBackColor = true;
            btn_themmonhoc.Click += btn_themmonhoc_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 173);
            label9.Name = "label9";
            label9.Size = new Size(119, 15);
            label9.TabIndex = 19;
            label9.Text = "Giảng Viên Phụ Trách";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 92);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 18;
            label10.Text = "Số Tín Chỉ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 130);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 17;
            label11.Text = "Trạng Thái";
            // 
            // txt_tenmonhoc
            // 
            txt_tenmonhoc.Location = new Point(142, 42);
            txt_tenmonhoc.Name = "txt_tenmonhoc";
            txt_tenmonhoc.Size = new Size(318, 23);
            txt_tenmonhoc.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 45);
            label12.Name = "label12";
            label12.Size = new Size(78, 15);
            label12.TabIndex = 13;
            label12.Text = "Tên Môn Học";
            // 
            // dgv_monhoc
            // 
            dgv_monhoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_monhoc.Location = new Point(8, 245);
            dgv_monhoc.Name = "dgv_monhoc";
            dgv_monhoc.Size = new Size(1044, 245);
            dgv_monhoc.TabIndex = 0;
            dgv_monhoc.CellClick += dgv_monhoc_CellClick;
            // 
            // tabBuoiTroGiang
            // 
            tabBuoiTroGiang.Controls.Add(cb_stt);
            tabBuoiTroGiang.Controls.Add(cb_trangthaibuoitrogiang);
            tabBuoiTroGiang.Controls.Add(cb_trogiangmonhoc);
            tabBuoiTroGiang.Controls.Add(label13);
            tabBuoiTroGiang.Controls.Add(label14);
            tabBuoiTroGiang.Controls.Add(label15);
            tabBuoiTroGiang.Controls.Add(cb_monhoctrogiang);
            tabBuoiTroGiang.Controls.Add(label16);
            tabBuoiTroGiang.Controls.Add(btn_xoabuoitrogiang);
            tabBuoiTroGiang.Controls.Add(btn_suabuoitrogiang);
            tabBuoiTroGiang.Controls.Add(btn_thembuoitrogiang);
            tabBuoiTroGiang.Controls.Add(dgv_buoitrogiang);
            tabBuoiTroGiang.Location = new Point(4, 24);
            tabBuoiTroGiang.Name = "tabBuoiTroGiang";
            tabBuoiTroGiang.Padding = new Padding(3);
            tabBuoiTroGiang.Size = new Size(1058, 496);
            tabBuoiTroGiang.TabIndex = 4;
            tabBuoiTroGiang.Text = "Buổi Trợ Giảng";
            tabBuoiTroGiang.UseVisualStyleBackColor = true;
            // 
            // cb_stt
            // 
            cb_stt.FormattingEnabled = true;
            cb_stt.Location = new Point(162, 44);
            cb_stt.Name = "cb_stt";
            cb_stt.Size = new Size(317, 23);
            cb_stt.TabIndex = 36;
            // 
            // cb_trangthaibuoitrogiang
            // 
            cb_trangthaibuoitrogiang.FormattingEnabled = true;
            cb_trangthaibuoitrogiang.Location = new Point(162, 86);
            cb_trangthaibuoitrogiang.Name = "cb_trangthaibuoitrogiang";
            cb_trangthaibuoitrogiang.Size = new Size(317, 23);
            cb_trangthaibuoitrogiang.TabIndex = 35;
            // 
            // cb_trogiangmonhoc
            // 
            cb_trogiangmonhoc.FormattingEnabled = true;
            cb_trogiangmonhoc.Location = new Point(162, 132);
            cb_trogiangmonhoc.Name = "cb_trogiangmonhoc";
            cb_trogiangmonhoc.Size = new Size(317, 23);
            cb_trogiangmonhoc.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(94, 175);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 33;
            label13.Text = "Môn Học";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(94, 94);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 32;
            label14.Text = "Trạng Thái";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(94, 132);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 31;
            label15.Text = "Trợ Giảng";
            // 
            // cb_monhoctrogiang
            // 
            cb_monhoctrogiang.FormattingEnabled = true;
            cb_monhoctrogiang.Location = new Point(162, 172);
            cb_monhoctrogiang.Name = "cb_monhoctrogiang";
            cb_monhoctrogiang.Size = new Size(317, 23);
            cb_monhoctrogiang.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(119, 47);
            label16.Name = "label16";
            label16.Size = new Size(25, 15);
            label16.TabIndex = 27;
            label16.Text = "STT";
            // 
            // btn_xoabuoitrogiang
            // 
            btn_xoabuoitrogiang.Location = new Point(784, 138);
            btn_xoabuoitrogiang.Name = "btn_xoabuoitrogiang";
            btn_xoabuoitrogiang.Size = new Size(141, 41);
            btn_xoabuoitrogiang.TabIndex = 26;
            btn_xoabuoitrogiang.Text = "Xóa";
            btn_xoabuoitrogiang.UseVisualStyleBackColor = true;
            btn_xoabuoitrogiang.Click += btn_xoabuoitrogiang_Click;
            // 
            // btn_suabuoitrogiang
            // 
            btn_suabuoitrogiang.Location = new Point(784, 91);
            btn_suabuoitrogiang.Name = "btn_suabuoitrogiang";
            btn_suabuoitrogiang.Size = new Size(141, 41);
            btn_suabuoitrogiang.TabIndex = 25;
            btn_suabuoitrogiang.Text = "Sửa";
            btn_suabuoitrogiang.UseVisualStyleBackColor = true;
            btn_suabuoitrogiang.Click += btn_suabuoitrogiang_Click;
            // 
            // btn_thembuoitrogiang
            // 
            btn_thembuoitrogiang.Location = new Point(784, 44);
            btn_thembuoitrogiang.Name = "btn_thembuoitrogiang";
            btn_thembuoitrogiang.Size = new Size(141, 41);
            btn_thembuoitrogiang.TabIndex = 24;
            btn_thembuoitrogiang.Text = "Thêm";
            btn_thembuoitrogiang.UseVisualStyleBackColor = true;
            btn_thembuoitrogiang.Click += btn_thembuoitrogiang_Click;
            // 
            // dgv_buoitrogiang
            // 
            dgv_buoitrogiang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_buoitrogiang.Location = new Point(6, 233);
            dgv_buoitrogiang.Name = "dgv_buoitrogiang";
            dgv_buoitrogiang.Size = new Size(1046, 257);
            dgv_buoitrogiang.TabIndex = 0;
            dgv_buoitrogiang.CellClick += dgv_buoitrogiang_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 548);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_thongkemonhoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_thongkebuoitrogiang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_thongketrogiang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_thongkegiangvien).EndInit();
            tabGiangVien.ResumeLayout(false);
            tabGiangVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_giangvien).EndInit();
            tabTroGiang.ResumeLayout(false);
            tabTroGiang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_trogiang).EndInit();
            tabMonHoc.ResumeLayout(false);
            tabMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_monhoc).EndInit();
            tabBuoiTroGiang.ResumeLayout(false);
            tabBuoiTroGiang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_buoitrogiang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabThongKe;
        private TabPage tabGiangVien;
        private TabPage tabTroGiang;
        private TabPage tabMonHoc;
        private TextBox txt_diachigiangvien;
        private TextBox txt_tengiangvien;
        private Label label1;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_themgiangvien;
        private DataGridView dgv_giangvien;
        private TabPage tabBuoiTroGiang;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cb_trangthaigiangvien;
        private TextBox txt_ngaysinhgiangvien;
        private Button btn_xoatrogiang;
        private Button btn_suatrogiang;
        private Button btn_themtrogiang;
        private DataGridView dgv_trogiang;
        private TextBox txt_ngaysinhtrogiang;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cb_trangthaitrogiang;
        private TextBox txt_diachitrogiang;
        private TextBox txt_tentrogiang;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBox1;
        private TextBox txt_sotinchi;
        private TextBox txt_tenmonhoc;
        private Label label12;
        private DataGridView dgv_monhoc;
        private ComboBox cb_trangthai;
        private Button btn_xoamonhoc;
        private Button btn_suamonhoc;
        private Button btn_themmonhoc;
        private DataGridView dgv_buoitrogiang;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox cb_monhoctrogiang;
        private Label label16;
        private Button btn_xoabuoitrogiang;
        private Button btn_suabuoitrogiang;
        private Button btn_thembuoitrogiang;
        private ComboBox cb_trangthaibuoitrogiang;
        private ComboBox cb_trogiangmonhoc;
        private ComboBox cb_sotinchi;
        private ComboBox cb_giangvienphutrach;
        private ComboBox cb_stt;
        private DataGridView dgv_thongkemonhoc;
        private DataGridView dgv_thongkebuoitrogiang;
        private DataGridView dgv_thongketrogiang;
        private DataGridView dgv_thongkegiangvien;
    }
}
