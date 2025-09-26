namespace Lab02_02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblTongNam = new System.Windows.Forms.Label();
            this.lblTongNu = new System.Windows.Forms.Label();
            this.txtTongNam = new System.Windows.Forms.TextBox();
            this.txtTongNu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(200, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMSSV);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.lblDiemTB);
            this.groupBox1.Controls.Add(this.txtDiemTB);
            this.groupBox1.Controls.Add(this.lblKhoa);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.btnThemSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // lblMSSV
            // 
            this.lblMSSV.Location = new System.Drawing.Point(10, 30);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(100, 23);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã Sinh Viên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(100, 30);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(150, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(10, 65);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 23);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 65);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(150, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(10, 100);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(100, 23);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // radNam
            // 
            this.radNam.Location = new System.Drawing.Point(116, 100);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(104, 24);
            this.radNam.TabIndex = 5;
            this.radNam.Text = "Nam";
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.Location = new System.Drawing.Point(220, 100);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(104, 24);
            this.radNu.TabIndex = 6;
            this.radNu.Text = "Nữ";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.Location = new System.Drawing.Point(10, 135);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(100, 23);
            this.lblDiemTB.TabIndex = 7;
            this.lblDiemTB.Text = "Điểm TB";
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(100, 135);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(150, 22);
            this.txtDiemTB.TabIndex = 8;
            // 
            // lblKhoa
            // 
            this.lblKhoa.Location = new System.Drawing.Point(10, 170);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(100, 23);
            this.lblKhoa.TabIndex = 9;
            this.lblKhoa.Text = "Chuyên Ngành";
            // 
            // cboKhoa
            // 
            this.cboKhoa.Location = new System.Drawing.Point(100, 170);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(150, 24);
            this.cboKhoa.TabIndex = 10;
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(30, 210);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(75, 23);
            this.btnThemSua.TabIndex = 11;
            this.btnThemSua.Text = "Thêm / Sửa";
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(150, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeight = 29;
            this.dgvSinhVien.Location = new System.Drawing.Point(391, 97);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.Size = new System.Drawing.Size(500, 220);
            this.dgvSinhVien.TabIndex = 2;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // lblTongNam
            // 
            this.lblTongNam.Location = new System.Drawing.Point(480, 343);
            this.lblTongNam.Name = "lblTongNam";
            this.lblTongNam.Size = new System.Drawing.Size(100, 23);
            this.lblTongNam.TabIndex = 3;
            this.lblTongNam.Text = "Tổng SV Nam";
            // 
            // lblTongNu
            // 
            this.lblTongNu.Location = new System.Drawing.Point(682, 347);
            this.lblTongNu.Name = "lblTongNu";
            this.lblTongNu.Size = new System.Drawing.Size(100, 23);
            this.lblTongNu.TabIndex = 5;
            this.lblTongNu.Text = "Tổng SV Nữ";
            // 
            // txtTongNam
            // 
            this.txtTongNam.Location = new System.Drawing.Point(586, 344);
            this.txtTongNam.Name = "txtTongNam";
            this.txtTongNam.Size = new System.Drawing.Size(50, 22);
            this.txtTongNam.TabIndex = 4;
            // 
            // txtTongNu
            // 
            this.txtTongNu.Location = new System.Drawing.Point(788, 348);
            this.txtTongNu.Name = "txtTongNu";
            this.txtTongNu.Size = new System.Drawing.Size(50, 22);
            this.txtTongNu.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(945, 415);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.lblTongNam);
            this.Controls.Add(this.txtTongNam);
            this.Controls.Add(this.lblTongNu);
            this.Controls.Add(this.txtTongNu);
            this.Name = "Form1";
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Khai báo controls
        private System.Windows.Forms.Label lblTitle, lblMSSV, lblHoTen, lblGioiTinh, lblDiemTB, lblKhoa, lblTongNam, lblTongNu;
        private System.Windows.Forms.TextBox txtMSSV, txtHoTen, txtDiemTB, txtTongNam, txtTongNu;
        private System.Windows.Forms.RadioButton radNam, radNu;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnThemSua, btnXoa;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
