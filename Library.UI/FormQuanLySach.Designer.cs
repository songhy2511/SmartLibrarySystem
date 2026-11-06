namespace Library.UI
{
    partial class FormQuanLySach
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.lblViTri = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            this.nudTongSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnCapNhatKho = new System.Windows.Forms.Button();
            this.btnDeXuatThanhLy = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();

            // pnlInput
            this.pnlInput.Controls.Add(this.lblTenSach);
            this.pnlInput.Controls.Add(this.txtTenSach);
            this.pnlInput.Controls.Add(this.lblTacGia);
            this.pnlInput.Controls.Add(this.txtTacGia);
            this.pnlInput.Controls.Add(this.lblTheLoai);
            this.pnlInput.Controls.Add(this.txtTheLoai);
            this.pnlInput.Controls.Add(this.lblViTri);
            this.pnlInput.Controls.Add(this.txtViTri);
            this.pnlInput.Controls.Add(this.lblTongSoLuong);
            this.pnlInput.Controls.Add(this.nudTongSoLuong);
            this.pnlInput.Controls.Add(this.lblTimKiem);
            this.pnlInput.Controls.Add(this.txtTimKiem);
            this.pnlInput.Controls.Add(this.btnTimKiem);
            this.pnlInput.Controls.Add(this.btnThemSach);
            this.pnlInput.Controls.Add(this.btnCapNhatKho);
            this.pnlInput.Controls.Add(this.btnDeXuatThanhLy);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(960, 160);
            this.pnlInput.TabIndex = 0;

            // lblTenSach
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(20, 18);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(55, 15);
            this.lblTenSach.Text = "Tên sách:";

            // txtTenSach
            this.txtTenSach.Location = new System.Drawing.Point(85, 15);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(220, 23);

            // lblTacGia
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(325, 18);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(46, 15);
            this.lblTacGia.Text = "Tác giả:";

            // txtTacGia
            this.txtTacGia.Location = new System.Drawing.Point(380, 15);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(180, 23);

            // lblTheLoai
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(580, 18);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(51, 15);
            this.lblTheLoai.Text = "Thể loại:";

            // txtTheLoai
            this.txtTheLoai.Location = new System.Drawing.Point(640, 15);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(180, 23);

            // lblViTri
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(20, 53);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(34, 15);
            this.lblViTri.Text = "Vị trí:";

            // txtViTri
            this.txtViTri.Location = new System.Drawing.Point(85, 50);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(220, 23);

            // lblTongSoLuong
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Location = new System.Drawing.Point(325, 53);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(57, 15);
            this.lblTongSoLuong.Text = "Số lượng:";

            // nudTongSoLuong
            this.nudTongSoLuong.Location = new System.Drawing.Point(380, 50);
            this.nudTongSoLuong.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudTongSoLuong.Name = "nudTongSoLuong";
            this.nudTongSoLuong.Size = new System.Drawing.Size(120, 23);

            // lblTimKiem
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 88);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(59, 15);
            this.lblTimKiem.Text = "Tìm kiếm:";

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(85, 85);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(415, 23);

            // btnTimKiem
            this.btnTimKiem.Location = new System.Drawing.Point(510, 84);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 25);
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            // btnThemSach
            this.btnThemSach.Location = new System.Drawing.Point(85, 120);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(130, 30);
            this.btnThemSach.Text = "Thêm Sách Mới";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);

            // btnCapNhatKho
            this.btnCapNhatKho.Location = new System.Drawing.Point(225, 120);
            this.btnCapNhatKho.Name = "btnCapNhatKho";
            this.btnCapNhatKho.Size = new System.Drawing.Size(130, 30);
            this.btnCapNhatKho.Text = "Cập Nhật Kho";
            this.btnCapNhatKho.UseVisualStyleBackColor = true;
            this.btnCapNhatKho.Click += new System.EventHandler(this.btnCapNhatKho_Click);

            // btnDeXuatThanhLy
            this.btnDeXuatThanhLy.Location = new System.Drawing.Point(365, 120);
            this.btnDeXuatThanhLy.Name = "btnDeXuatThanhLy";
            this.btnDeXuatThanhLy.Size = new System.Drawing.Size(135, 30);
            this.btnDeXuatThanhLy.Text = "Đề Xuất Thanh Lý";
            this.btnDeXuatThanhLy.UseVisualStyleBackColor = true;
            this.btnDeXuatThanhLy.Click += new System.EventHandler(this.btnDeXuatThanhLy_Click);

            // dgvSach
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 160);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(960, 440);
            this.dgvSach.TabIndex = 1;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);

            // FormQuanLySach
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.pnlInput);
            this.Name = "FormQuanLySach";
            this.Text = "Quản Lý Kho Sách";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            // Trong InitializeComponent():
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnXoaSach.Location = new System.Drawing.Point(510, 120);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(120, 30);
            this.btnXoaSach.Text = "Xóa Sách";
            this.btnXoaSach.BackColor = System.Drawing.Color.FromArgb(225, 29, 72); // UITheme.Danger
            this.btnXoaSach.ForeColor = System.Drawing.Color.White;
            this.btnXoaSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            this.pnlInput.Controls.Add(this.btnXoaSach);
        }

        #endregion

        // Thêm khai báo này vào danh sách các private control ở cuối file:
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.NumericUpDown nudTongSoLuong;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnCapNhatKho;
        private System.Windows.Forms.Button btnDeXuatThanhLy;
        private System.Windows.Forms.DataGridView dgvSach;
    }
}