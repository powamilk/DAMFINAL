using DAMFINAL.BUS.Implement;
using DAMFINAL.BUS.Interface;
using DAMFINAL.BUS.Utils;
using DAMFINAL.BUS.Utils.Status;
using DAMFINAL.BUS.ViewModel.BuoiTroGiangVM;
using DAMFINAL.BUS.ViewModel.GiangVienVM;
using DAMFINAL.BUS.ViewModel.MonHocVM;
using DAMFINAL.BUS.ViewModel.ThongKeVM;
using DAMFINAL.BUS.ViewModel.TroGiangVM;
using DAMFINAL.DAL.Entities;

namespace DAMFINAL.PL
{
    public partial class Form1 : Form
    {
        List<GiangVienVM> _giangViens;
        List<MonHocVM> _monHocs;
        List<TroGiangVM> _troGiangs;
        List<BuoiTroGiangVM> _buoiTroGiangs;
        List<GiangVienThongKeVM> _thongKeGiangs;
        List<MonHocThongKeVM> _thongKeMons;
        List<TroGiangThongKeVM > _thongKeTroGiangs;
        List<ThongKeTheoTrangThaiVM> _thongKeTrangThai;
        IThongKeService _thongKeService;
        IBuoiTroGiangService _buoiTroGiangService;
        ITroGiangService _troGiangService;
        IMonHocService _monHocService;
        IGiangVienService _giangVienService;
        string _maGiangVienChon;
        string _maMonHocChon;
        string _maTroGiangChon;
        string _maBuoiTroGiangChon;
        public Form1()
        {
            _giangVienService = new GiangVienService();
            _monHocService = new MonHocService();
            _troGiangService = new TroGiangService();
            _buoiTroGiangService = new BuoiTroGiangService();
            _thongKeService = new ThongKeService();


            InitializeComponent();
            LoadFormDataMonHoc();
            LoadFormDataGiangVien();
            LoadFormDataTroGiang();
            LoadFormDataBuoiTroGiang();
            LoadGridDataGiangVien();
            LoadGridDataMonHoc();
            LoadGridDataTroGiang();
            LoadGridDataBuoiTroGiang();
            LoadThongKeMonHoc();
            LoadThongKeGiangVien();
            LoadThongKeTroGiang();
            //LoadThongKeBuoiTroGiang();
        }

        //private void LoadThongKeBuoiTroGiang()
        //{
        //    dgv_thongkebuoitrogiang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dgv_thongkebuoitrogiang.Columns.Clear();
        //    dgv_thongkebuoitrogiang.Columns.Add("clm1", "STT");
        //    dgv_thongkebuoitrogiang.Columns.Add("clm2", "Mã Buổi Trợ Giảng");
        //    dgv_thongkebuoitrogiang.Columns.Add("clm3", "Trạng Thái");

        //    var thongKeBuoiTroGiang = _thongKeService.GetThongKeBuoiTroGiang();
        //    dgv_thongkebuoitrogiang.Rows.Clear();

        //    foreach (var item in thongKeBuoiTroGiang)
        //    {
        //        dgv_thongkebuoitrogiang.Rows.Add(
        //            thongKeBuoiTroGiang.IndexOf(item) + 1,
        //            item.Mabtg,
        //            GetStatusNameBuoiTroGiang(item.Trangthai)
        //        );
        //    }
        //}


        private void LoadThongKeMonHoc()
        {
            dgv_thongkemonhoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_thongkemonhoc.Columns.Clear();
            dgv_thongkemonhoc.Columns.Add("clm1", "STT");
            dgv_thongkemonhoc.Columns.Add("clm2", "Mã Môn Học");
            dgv_thongkemonhoc.Columns.Add("clm3", "Tên Môn Học");
            dgv_thongkemonhoc.Columns.Add("clm4", "Giảng Viên Phụ Trách");
            dgv_thongkemonhoc.Columns.Add("clm5", "Số Lượng Buổi Trợ Giảng");

            var thongKeMonHoc = _thongKeService.GetThongKeMonHoc();
            dgv_thongkemonhoc.Rows.Clear();

            foreach (var item in thongKeMonHoc)
            {
                dgv_thongkemonhoc.Rows.Add(
                    thongKeMonHoc.IndexOf(item) + 1,
                    item.Mamh,
                    item.Tenmh,
                    item.GiangVienPhuTrach,
                    item.SoLuongBuoiTroGiang
                );
            }
        }
        private void LoadThongKeTroGiang()
        {
            dgv_thongketrogiang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_thongketrogiang.Columns.Clear();
            dgv_thongketrogiang.Columns.Add("clm1", "STT");
            dgv_thongketrogiang.Columns.Add("clm2", "Mã Trợ Giảng");
            dgv_thongketrogiang.Columns.Add("clm3", "Tên Trợ Giảng");
            dgv_thongketrogiang.Columns.Add("clm4", "Số Lượng Buổi Trợ Giảng");
            dgv_thongketrogiang.Columns.Add("clm5", "Số Lượng Buổi Trợ Giảng Đang Tham Gia");

            var thongKeTroGiang = _thongKeService.GetThongKeTroGiang();
            dgv_thongketrogiang.Rows.Clear();

            foreach (var item in thongKeTroGiang)
            {
                dgv_thongketrogiang.Rows.Add(
                    thongKeTroGiang.IndexOf(item) + 1,
                    item.Matg,
                    item.Tentg,
                    item.SoLuongBuoiTroGiang,
                    item.SoLuongBuoiTroGiangDangThamGia
                );
            }
        }


        private void LoadThongKeGiangVien()
        {
            dgv_thongkegiangvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_thongkegiangvien.Columns.Clear();
            dgv_thongkegiangvien.Columns.Add("clm1", "STT");
            dgv_thongkegiangvien.Columns.Add("clm2", "Mã Giảng Viên");
            dgv_thongkegiangvien.Columns.Add("clm3", "Tên Giảng Viên");
            dgv_thongkegiangvien.Columns.Add("clm4", "Số Lượng Môn Học");
            dgv_thongkegiangvien.Columns.Add("clm5", "Tổng Số Tín Chỉ");

            var thongKeGiangVien = _thongKeService.GetThongKeGiangVien();
            dgv_thongkegiangvien.Rows.Clear();

            foreach (var item in thongKeGiangVien)
            {
                dgv_thongkegiangvien.Rows.Add(
                    thongKeGiangVien.IndexOf(item) + 1,
                    item.Magv,
                    item.Tengv,
                    item.SoLuongMonHoc,
                    item.TongSoTinChi
                );
            }
        }


        private void LoadFormDataMonHoc()
        {
            dgv_monhoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_monhoc.Columns.Clear();
            dgv_monhoc.Columns.Add("clm1", "STT");
            dgv_monhoc.Columns.Add("clm2", "Mã Môn Học");
            dgv_monhoc.Columns.Add("clm3", "Tên Môn Học");
            dgv_monhoc.Columns.Add("clm4", "Số Tín Chỉ");
            dgv_monhoc.Columns.Add("clm5", "Trạng Thái");
            dgv_monhoc.Columns.Add("clm6", "Giảng Viên Phụ Trách");

            cb_sotinchi.Items.Clear();
            cb_sotinchi.Items.Add("1");
            cb_sotinchi.Items.Add("2");
            cb_sotinchi.Items.Add("3");
            cb_sotinchi.Items.Add("4");

            cb_trangthai.Items.Clear();
            cb_trangthai.Items.Add(StatusEnumMonHoc.DangGiangDay.GetStatusNameMonHoc());
            cb_trangthai.Items.Add(StatusEnumMonHoc.TamNgungGiangDay.GetStatusNameMonHoc());
            cb_trangthai.Items.Add(StatusEnumMonHoc.KhongConGiangDay.GetStatusNameMonHoc());

            LoadGiangVienComboBox();
        }

        private void LoadFormDataGiangVien()
        {
            dgv_giangvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_giangvien.Columns.Clear();
            dgv_giangvien.Columns.Add("clm1", "STT");
            dgv_giangvien.Columns.Add("clm2", "Mã Giảng Viên");
            dgv_giangvien.Columns.Add("clm3", "Tên Giảng Viên");
            dgv_giangvien.Columns.Add("clm4", "Ngày Sinh");
            dgv_giangvien.Columns.Add("clm5", "Địa Chỉ");
            dgv_giangvien.Columns.Add("clm6", "Trạng Thái");

            cb_trangthaigiangvien.Items.Clear();
            cb_trangthaigiangvien.Items.Add(StatusEnumGiangVien.NghiHuu.GetStatusNameGiangVien());
            cb_trangthaigiangvien.Items.Add(StatusEnumGiangVien.DangLamViec.GetStatusNameGiangVien());
            cb_trangthaigiangvien.Items.Add(StatusEnumGiangVien.DangNghiPhep.GetStatusNameGiangVien());
        }

        private void LoadFormDataTroGiang()
        {
            dgv_trogiang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_trogiang.Columns.Clear();
            dgv_trogiang.Columns.Add("clm1", "STT");
            dgv_trogiang.Columns.Add("clm2", "Mã Trợ Giảng");
            dgv_trogiang.Columns.Add("clm3", "Tên Trợ Giảng");
            dgv_trogiang.Columns.Add("clm6", "Ngày sinh");
            dgv_trogiang.Columns.Add("clm4", "Địa Chỉ");
            dgv_trogiang.Columns.Add("clm5", "Trạng Thái");

            cb_trangthaitrogiang.Items.Clear();
            cb_trangthaitrogiang.Items.Add(StatusEnumTroGiang.DangLamViec.GetStatusNameTroGiang());
            cb_trangthaitrogiang.Items.Add(StatusEnumTroGiang.DangNghiPhep.GetStatusNameTroGiang());
            cb_trangthaitrogiang.Items.Add(StatusEnumTroGiang.NghỉViec.GetStatusNameTroGiang());
        }

        private void LoadFormDataBuoiTroGiang()
        {
            dgv_buoitrogiang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_buoitrogiang.Columns.Clear();
            dgv_buoitrogiang.Columns.Add("clm1", "STT");
            dgv_buoitrogiang.Columns.Add("clm2", "Mã Buổi trợ giảng");
            dgv_buoitrogiang.Columns.Add("clm3", "Số thứ tự");
            dgv_buoitrogiang.Columns.Add("clm4", "Trạng Thái");
            dgv_buoitrogiang.Columns.Add("clm5", "Mã Môn Học");
            dgv_buoitrogiang.Columns.Add("clm6", "Mã Trợ Giảng");

            cb_stt.Items.Clear();
            cb_stt.Items.Add("1");
            cb_stt.Items.Add("2");
            cb_stt.Items.Add("3");
            cb_stt.SelectedIndex = 0;

            cb_trangthaibuoitrogiang.Items.Clear();
            cb_trangthaibuoitrogiang.Items.Add(StatusEnumBuoiTroGiang.DaHuy.GetStatusName());
            cb_trangthaibuoitrogiang.Items.Add(StatusEnumBuoiTroGiang.DaDienRa.GetStatusName());
            cb_trangthaibuoitrogiang.Items.Add(StatusEnumBuoiTroGiang.DangDienRa.GetStatusName());
            cb_trangthaibuoitrogiang.SelectedIndex = 0;

            LoadMonHocComboBox();
            LoadTroGiangComboBox();

        }


        #region Giảng Viên
        private void LoadGridDataGiangVien()
        {
            _giangViens = _giangVienService.GetList();
            dgv_giangvien.Rows.Clear();
            foreach (var gv in _giangViens)
            {
                string trangThai = GetStatusName(gv.Trangthai ?? 0);
                DateOnly? ngaysinh = gv.Ngaysinh.HasValue ? gv.Ngaysinh.Value : (DateOnly?)null;
                string ngaysinhString = ngaysinh.HasValue ? ngaysinh.Value.ToString("dd/MM/yyyy") : "Không có dữ liệu";

                dgv_giangvien.Rows.Add(
                    (_giangViens.IndexOf(gv) + 1),
                    gv.Magv,
                    gv.Tengv,
                    ngaysinhString,
                    gv.Diachi,
                    trangThai
                );
            }
        }

        private string GetStatusName(int trangThai)
        {
            switch (trangThai)
            {
                case 0:
                    return "Nghỉ Hưu";
                case 1:
                    return "Đang Làm Việc";
                case 2:
                    return "Đang Nghỉ Phép";
                default:
                    return "Không Xác Định";
            }
        }

        private string TaoMaGiangVien()
        {
            var giangViens = _giangVienService.GetList();
            var lastGiangVien = giangViens
                .Select(gv => gv.Magv)
                .OrderByDescending(ma => ma)
                .FirstOrDefault();
            if (string.IsNullOrEmpty(lastGiangVien))
            {
                return "GV001";
            }
            int lastNumber = int.Parse(lastGiangVien.Substring(2));
            int newNumber = lastNumber + 1;
            string newMaGiangVien = "GV" + newNumber.ToString("D3");
            return newMaGiangVien;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_themgiangvien_Click(object sender, EventArgs e)
        {
            bool isTrangThaiValid = int.TryParse(cb_trangthaigiangvien.Text, out int trangThai);
            DateOnly ngaysinh;

            if (!DateOnly.TryParseExact(txt_ngaysinhgiangvien.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaysinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newMaGiangVien = TaoMaGiangVien();
            var gvCreate = new GiangVienCreateVM
            {
                Magv = newMaGiangVien,
                Tengv = txt_tengiangvien.Text,
                Ngaysinh = ngaysinh,
                Diachi = txt_diachigiangvien.Text,
                Trangthai = trangThai,
            };

            var result = _giangVienService.Create(gvCreate);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataGiangVien();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_maGiangVienChon == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isTrangThaiValid = int.TryParse(cb_trangthaigiangvien.Text, out int trangThai);
            DateOnly ngaysinh;

            if (!DateOnly.TryParseExact(txt_ngaysinhgiangvien.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaysinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var gvUpdate = new GiangVienUpdateVM
            {
                Magv = _maGiangVienChon.ToString(),
                Tengv = txt_tengiangvien.Text,
                Ngaysinh = ngaysinh,
                Diachi = txt_diachigiangvien.Text,
                Trangthai = trangThai,
            };

            var result = _giangVienService.Update(gvUpdate);
            string msg = result ? "Chỉnh sửa thành công" : "Chỉnh sửa thất bại";
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataGiangVien();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_maGiangVienChon == null)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _giangVienService.Delete(_maGiangVienChon);
                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridDataGiangVien();
            }
        }

        private void dgv_giangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _giangViens.Count)
            {
                _maGiangVienChon = null;
                return;
            }
            var giangVienChon = _giangViens.ElementAt(index);
            _maGiangVienChon = giangVienChon.Magv;

            txt_tengiangvien.Text = giangVienChon.Tengv;
            txt_ngaysinhgiangvien.Text = giangVienChon.Ngaysinh?.ToString("dd/MM/yyyy") ?? "";
            txt_diachigiangvien.Text = giangVienChon.Diachi;
            cb_trangthaigiangvien.SelectedItem = GetStatusName(giangVienChon.Trangthai ?? 0);
        }

        #endregion


        #region Môn Học

        private void LoadGiangVienComboBox()
        {
            var giangViens = _giangVienService.GetList();

            cb_giangvienphutrach.Items.Clear();
            foreach (var gv in giangViens)
            {
                cb_giangvienphutrach.Items.Add($"{gv.Magv} - {gv.Tengv}");
            }
            cb_giangvienphutrach.SelectedIndex = 0;
        }

        private void LoadGridDataMonHoc()
        {
            _monHocs = _monHocService.GetList();
            dgv_monhoc.Rows.Clear();

            foreach (var mh in _monHocs)
            {
                int trangThai = mh.Trangthai;
                string trangThaiString = GetStatusNameMonHoc(trangThai);
                string giangVienPhuTrach = GetGiangVienName(mh.Magv);

                dgv_monhoc.Rows.Add(
                    (_monHocs.IndexOf(mh) + 1),
                    mh.Mamh,
                    mh.Tenmh,
                    mh.Sotinchi,
                    trangThaiString,
                    giangVienPhuTrach
                );
            }
        }
        private string GetGiangVienName(string giangVienId)
        {
            var giangVien = _giangVienService.GetList().FirstOrDefault(gv => gv.Magv == giangVienId);
            return giangVien != null ? $"{giangVien.Magv} - {giangVien.Tengv}" : "Không xác định";
        }
        private string GetSelectedGiangVienId()
        {
            if (cb_giangvienphutrach.SelectedItem == null)
            {
                return null;
            }
            var selectedText = cb_giangvienphutrach.SelectedItem.ToString();
            var giangVienId = selectedText.Split(' ')[0];

            return giangVienId;
        }

        private string GetStatusNameMonHoc(int trangThai)
        {
            return trangThai switch
            {
                0 => "Đang Giảng Dạy",
                1 => "Tạm Ngừng",
                2 => "Không Còn Giảng Dạy",
                _ => "Không Xác Định"
            };
        }
        private void dgv_monhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _monHocs.Count)
            {
                _maMonHocChon = null;
                return;
            }

            var monHocChon = _monHocs.ElementAt(index);
            _maMonHocChon = monHocChon.Mamh;

            txt_tenmonhoc.Text = monHocChon.Tenmh;
            cb_sotinchi.SelectedItem = monHocChon.Sotinchi.ToString();
            cb_giangvienphutrach.SelectedItem = $"{monHocChon.Magv} - {monHocChon.GiangVienName}";
            cb_trangthai.SelectedItem = GetStatusNameMonHoc(monHocChon.Trangthai);
        }

        private void btn_themmonhoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenmonhoc.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSoTinChiValid = int.TryParse(cb_sotinchi.SelectedItem.ToString(), out int soTinChi);
            if (!isSoTinChiValid || soTinChi < 1 || soTinChi > 4)
            {
                MessageBox.Show("Vui lòng chọn số tín chỉ hợp lệ từ 1 đến 4.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var giangVienPhuTrach = cb_giangvienphutrach.SelectedItem.ToString();
            var maGiangVien = giangVienPhuTrach.Split(' ')[0];

            if (cb_trangthai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int trangThai = cb_trangthai.SelectedIndex;

            var monHocCreateVM = new MonHocCreateVM
            {
                Tenmh = txt_tenmonhoc.Text.Trim(),
                Sotinchi = soTinChi,
                Magv = maGiangVien,
                Trangthai = trangThai
            };

            var result = _monHocService.Create(monHocCreateVM);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataMonHoc();
        }

        private void btn_suamonhoc_Click(object sender, EventArgs e)
        {
            if (_maMonHocChon == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSoTinChiValid = int.TryParse(cb_sotinchi.SelectedItem?.ToString(), out int soTinChi);
            if (!isSoTinChiValid || soTinChi < 1 || soTinChi > 4)
            {
                MessageBox.Show("Số tín chỉ không hợp lệ. Vui lòng chọn từ 1 đến 4.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedGiangVienId = GetSelectedGiangVienId();
            if (string.IsNullOrEmpty(selectedGiangVienId))
            {
                MessageBox.Show("Vui lòng chọn giảng viên phụ trách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isTrangThaiValid = int.TryParse(cb_trangthai.SelectedItem?.ToString(), out int trangThai);
            if (!isTrangThaiValid)
            {
                MessageBox.Show("Trạng thái không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var monHocUpdate = new MonHocUpdateVM
            {
                Mamh = _maMonHocChon,
                Tenmh = txt_tenmonhoc.Text.Trim(),
                Sotinchi = soTinChi,
                Magv = selectedGiangVienId,
                Trangthai = trangThai
            };

            var result = _monHocService.Update(monHocUpdate);
            string msg = result ? "Cập nhật thành công" : "Cập nhật thất bại";
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataMonHoc();
        }

        private void btn_xoamonhoc_Click(object sender, EventArgs e)
        {
            if (_maMonHocChon == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _monHocService.Delete(_maMonHocChon);
                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridDataMonHoc();
            }
        }
        #endregion



        private void LoadGridDataTroGiang()
        {
            _troGiangs = _troGiangService.GetList();
            dgv_trogiang.Rows.Clear();

            foreach (var tg in _troGiangs)
            {
                string trangThaiString = GetStatusNameTroGiang(tg.Trangthai);
                string ngaysinhString = tg.Ngaysinh?.ToString("dd/MM/yyyy") ?? "Không có dữ liệu";

                dgv_trogiang.Rows.Add(
                    (_troGiangs.IndexOf(tg) + 1),
                    tg.Matg,
                    tg.Tentg,
                    ngaysinhString,
                    tg.Diachi,
                    trangThaiString
                );
            }
        }

        private string GetStatusNameTroGiang(int? trangThai)
        {
            return trangThai switch
            {
                0 => "Đang Làm Việc",
                1 => "Đang Nghỉ Phép",
                2 => "Nghỉ Việc",
                _ => "Không xác định"
            };
        }
        private void btn_themtrogiang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tentrogiang.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên trợ giảng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txt_ngaysinhtrogiang.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cb_trangthaitrogiang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateOnly ngaysinh;
            if (!DateOnly.TryParseExact(txt_ngaysinhtrogiang.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaysinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var troGiangCreateVM = new TroGiangCreateVM
            {
                Tentg = txt_tentrogiang.Text.Trim(),
                Ngaysinh = ngaysinh,
                Diachi = txt_diachitrogiang.Text.Trim(),
                Trangthai = cb_trangthaitrogiang.SelectedIndex
            };

            var result = _troGiangService.Create(troGiangCreateVM);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataTroGiang();
        }

        private void btn_suatrogiang_Click(object sender, EventArgs e)
        {
            if (_maTroGiangChon == null)
            {
                MessageBox.Show("Vui lòng chọn trợ giảng cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txt_tentrogiang.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên trợ giảng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateOnly ngaysinh;
            if (!DateOnly.TryParseExact(txt_ngaysinhtrogiang.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaysinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int trangThai = cb_trangthaitrogiang.SelectedIndex;

            var troGiangUpdateVM = new TroGiangUpdateVM
            {
                Matg = _maTroGiangChon,
                Tentg = txt_tentrogiang.Text.Trim(),
                Ngaysinh = ngaysinh,
                Diachi = txt_diachitrogiang.Text.Trim(),
                Trangthai = trangThai
            };

            var result = _troGiangService.Update(troGiangUpdateVM);
            string msg = result ? "Cập nhật thành công" : "Cập nhật thất bại";
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataTroGiang();
        }

        private void btn_xoatrogiang_Click(object sender, EventArgs e)
        {
            if (_maTroGiangChon == null)
            {
                MessageBox.Show("Vui lòng chọn trợ giảng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa trợ giảng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _troGiangService.Delete(_maTroGiangChon);
                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridDataTroGiang();
            }
        }

        private void dgv_trogiang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _troGiangs.Count)
            {
                _maTroGiangChon = null;
                return;
            }

            var troGiangChon = _troGiangs.ElementAt(index);
            _maTroGiangChon = troGiangChon.Matg;

            txt_tentrogiang.Text = troGiangChon.Tentg;
            txt_ngaysinhtrogiang.Text = troGiangChon.Ngaysinh?.ToString("dd/MM/yyyy") ?? "";
            txt_diachitrogiang.Text = troGiangChon.Diachi;
            cb_trangthaitrogiang.SelectedIndex = troGiangChon.Trangthai ?? 0;
        }

        private void LoadMonHocComboBox()
        {
            var monHocs = _monHocService.GetList();
            cb_monhoctrogiang.Items.Clear();
            foreach (var mh in monHocs)
            {
                cb_monhoctrogiang.Items.Add($"{mh.Mamh} - {mh.Tenmh}");
            }
            cb_monhoctrogiang.SelectedIndex = 0;
        }

        private void LoadTroGiangComboBox()
        {
            var troGiangs = _troGiangService.GetList();
            cb_trogiangmonhoc.Items.Clear();
            foreach (var tg in troGiangs)
            {
                cb_trogiangmonhoc.Items.Add($"{tg.Matg} - {tg.Tentg}");
            }
            cb_trogiangmonhoc.SelectedIndex = 0;
        }

        private void LoadGridDataBuoiTroGiang()
        {
            _buoiTroGiangs = _buoiTroGiangService.GetList();
            dgv_buoitrogiang.Rows.Clear();

            foreach (var btg in _buoiTroGiangs)
            {
                string trangThaiString = GetStatusNameBuoiTroGiang(btg.Trangthai);
                string monHocInfo = $"{btg.Mamh} - {btg.MonHocName}";
                string troGiangInfo = $"{btg.Matg} - {btg.TroGiangName}";
                dgv_buoitrogiang.Rows.Add(
                    (_buoiTroGiangs.IndexOf(btg) + 1),
                    btg.Mabtg,
                    btg.Sothutu,
                    trangThaiString,
                    monHocInfo,
                    troGiangInfo
                );
            }
        }

        private string GetStatusNameBuoiTroGiang(int trangThai)
        {
            return trangThai switch
            {
                0 => "Đã hủy",
                1 => "Đã diễn ra",
                2 => "Đang diễn ra",
                _ => "Không xác định"
            };
        }

        private void dgv_buoitrogiang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_thembuoitrogiang_Click(object sender, EventArgs e)
        {
            int soThuTu = int.Parse(cb_stt.SelectedItem.ToString());
            string maBuoiTroGiangMoi = GenerateMaBuoiTroGiang();
            string maMonHoc = cb_monhoctrogiang.SelectedItem.ToString().Split(' ')[0];
            string maTroGiang = cb_trogiangmonhoc.SelectedItem.ToString().Split(' ')[0];

            int trangThai = cb_trangthaibuoitrogiang.SelectedIndex;

            var buoiTroGiangCreateVM = new BuoiTroGiangCreateVM
            {
                Sothutu = soThuTu,
                Mamh = maMonHoc,
                Matg = maTroGiang,
                Trangthai = trangThai
            };

            var result = _buoiTroGiangService.Create(buoiTroGiangCreateVM);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataBuoiTroGiang();
        }
        private string GenerateMaBuoiTroGiang()
        {
            var buoiTroGiangs = _buoiTroGiangService.GetList();
            var lastMaBuoiTroGiang = buoiTroGiangs
                .Select(btg => btg.Mabtg)
                .OrderByDescending(ma => ma)
                .FirstOrDefault();
            if (string.IsNullOrEmpty(lastMaBuoiTroGiang))
            {
                return "BTG001";
            }
            int lastNumber = int.Parse(lastMaBuoiTroGiang.Substring(3));
            int newNumber = lastNumber + 1;
            return "BTG" + newNumber.ToString("D3");
        }


        private void btn_suabuoitrogiang_Click(object sender, EventArgs e)
        {
            if (_maBuoiTroGiangChon == null)
            {
                MessageBox.Show("Vui lòng chọn buổi trợ giảng cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int soThuTu = int.Parse(cb_stt.SelectedItem.ToString());

            string maMonHoc = cb_monhoctrogiang.SelectedItem.ToString().Split(' ')[0];
            string maTroGiang = cb_trogiangmonhoc.SelectedItem.ToString().Split(' ')[0];

            int trangThai = cb_trangthaibuoitrogiang.SelectedIndex;

            var buoiTroGiangUpdateVM = new BuoiTroGiangUpdateVM
            {
                Mabtg = _maBuoiTroGiangChon,
                Sothutu = soThuTu,
                Mamh = maMonHoc,
                Matg = maTroGiang,
                Trangthai = trangThai
            };

            var result = _buoiTroGiangService.Update(buoiTroGiangUpdateVM);
            string msg = result ? "Cập nhật thành công" : "Cập nhật thất bại";
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataBuoiTroGiang();
        }

        private void btn_xoabuoitrogiang_Click(object sender, EventArgs e)
        {
            if (_maBuoiTroGiangChon == null)
            {
                MessageBox.Show("Vui lòng chọn buổi trợ giảng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa buổi trợ giảng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _buoiTroGiangService.Delete(_maBuoiTroGiangChon);
                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridDataBuoiTroGiang();
            }
        }
    }
}
