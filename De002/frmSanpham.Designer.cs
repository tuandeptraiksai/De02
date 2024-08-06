using System.Drawing;
using System.Windows.Forms;

namespace De2
{
    partial class frmDanhMucSP
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
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.lvSanpham = new System.Windows.Forms.ListView();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(493, 304);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(47, 16);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã SP";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(488, 343);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(52, 16);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên SP";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(476, 383);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(73, 16);
            this.lblNgayNhap.TabIndex = 2;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Location = new System.Drawing.Point(488, 426);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(54, 16);
            this.lblLoaiSP.TabIndex = 3;
            this.lblLoaiSP.Text = "Loại SP";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(573, 298);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(150, 22);
            this.txtMaSP.TabIndex = 4;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(573, 337);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(150, 22);
            this.txtTenSP.TabIndex = 5;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Location = new System.Drawing.Point(573, 377);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dtNgayNhap.TabIndex = 6;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Location = new System.Drawing.Point(573, 423);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(150, 24);
            this.cboLoaiSP.TabIndex = 7;
            // 
            // lvSanpham
            // 
            this.lvSanpham.HideSelection = false;
            this.lvSanpham.Location = new System.Drawing.Point(20, 180);
            this.lvSanpham.Name = "lvSanpham";
            this.lvSanpham.Size = new System.Drawing.Size(438, 300);
            this.lvSanpham.TabIndex = 8;
            this.lvSanpham.UseCompatibleStateImageBehavior = false;
            this.lvSanpham.View = System.Windows.Forms.View.Details;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(20, 500);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(100, 500);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(180, 500);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(260, 500);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 12;
            this.btLuu.Text = "Lưu";
            // 
            // btKLuu
            // 
            this.btKLuu.Location = new System.Drawing.Point(340, 500);
            this.btKLuu.Name = "btKLuu";
            this.btKLuu.Size = new System.Drawing.Size(75, 23);
            this.btKLuu.TabIndex = 13;
            this.btKLuu.Text = "Không Lưu";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(420, 500);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "TÌM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 35);
            this.label1.MaximumSize = new System.Drawing.Size(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "DANH MUC SAN PHAM";
            // 
            // frmDanhMucSP
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.lvSanpham);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btKLuu);
            this.Controls.Add(this.btThoat);
            this.Name = "frmDanhMucSP";
            this.Text = "DANH MỤC SAN PHẨM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblMaSP;
        private Label lblTenSP;
        private Label lblNgayNhap;
        private Label lblLoaiSP;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private DateTimePicker dtNgayNhap;
        private ComboBox cboLoaiSP;
        private ListView lvSanpham;
        private Button btThem;
        private Button btXoa;
        private Button btSua;
        private Button btLuu;
        private Button btKLuu;
        private Button btThoat;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
    }
}
