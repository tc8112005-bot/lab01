using System;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm khoa vào ComboBox
            cboKhoa.Items.Add("QTKD");
            cboKhoa.Items.Add("CNTT");
            cboKhoa.Items.Add("NNA");

            cboKhoa.SelectedIndex = 0; // mặc định QTKD
            radNu.Checked = true;      // mặc định Nữ

            txtTongNam.Text = "0";
            txtTongNu.Text = "0";

            // Tạo cột cho DataGridView
            dgvSinhVien.Columns.Add("MSSV", "MSSV");
            dgvSinhVien.Columns.Add("HoTen", "Họ Tên");
            dgvSinhVien.Columns.Add("GioiTinh", "Giới Tính");
            dgvSinhVien.Columns.Add("DiemTB", "ĐTB");
            dgvSinhVien.Columns.Add("Khoa", "Khoa");
        }

        // Nút Thêm/Sửa
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string diem = txtDiemTB.Text.Trim();
            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            string khoa = cboKhoa.SelectedItem.ToString();

            if (mssv == "" || hoten == "" || diem == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!double.TryParse(diem, out double dtb))
            {
                MessageBox.Show("Điểm trung bình phải là số!");
                return;
            }

            // Kiểm tra MSSV có chưa
            int index = -1;
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells["MSSV"].Value != null && row.Cells["MSSV"].Value.ToString() == mssv)
                {
                    index = row.Index;
                    break;
                }
            }

            if (index == -1)
            {
                dgvSinhVien.Rows.Add(mssv, hoten, gioitinh, dtb, khoa);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else
            {
                dgvSinhVien.Rows[index].Cells["HoTen"].Value = hoten;
                dgvSinhVien.Rows[index].Cells["GioiTinh"].Value = gioitinh;
                dgvSinhVien.Rows[index].Cells["DiemTB"].Value = dtb;
                dgvSinhVien.Rows[index].Cells["Khoa"].Value = khoa;
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }

            TinhTong();
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if (mssv == "")
            {
                MessageBox.Show("Vui lòng nhập MSSV cần xóa!");
                return;
            }

            int index = -1;
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells["MSSV"].Value != null && row.Cells["MSSV"].Value.ToString() == mssv)
                {
                    index = row.Index;
                    break;
                }
            }

            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvSinhVien.Rows.RemoveAt(index);
                    MessageBox.Show("Xóa sinh viên thành công!");
                    TinhTong();
                }
            }
        }

        // Khi click chọn 1 dòng trên DataGridView
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells["MSSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtDiemTB.Text = row.Cells["DiemTB"].Value.ToString();
                cboKhoa.SelectedItem = row.Cells["Khoa"].Value.ToString();

                if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
            }
        }

        // Hàm tính tổng số Nam/Nữ
        private void TinhTong()
        {
            int nam = 0, nu = 0;
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells["GioiTinh"].Value != null)
                {
                    if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                        nam++;
                    else
                        nu++;
                }
            }
            txtTongNam.Text = nam.ToString();
            txtTongNu.Text = nu.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
