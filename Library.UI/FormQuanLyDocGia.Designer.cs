namespace Library.UI
{
    partial class FormQuanLyDocGia
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
            pnlInput = new Panel();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnThemDocGia = new Button();
            btnKhoaMoKhoa = new Button();
            btnGiaHan = new Button();
            btnXoaDocGia = new Button();
            dgvDocGia = new DataGridView();
            pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            SuspendLayout();
            // 
            // pnlInput
            // 
            pnlInput.Controls.Add(lblHoTen);
            pnlInput.Controls.Add(txtHoTen);
            pnlInput.Controls.Add(lblSDT);
            pnlInput.Controls.Add(txtSDT);
            pnlInput.Controls.Add(lblEmail);
            pnlInput.Controls.Add(txtEmail);
            pnlInput.Controls.Add(lblTimKiem);
            pnlInput.Controls.Add(txtTimKiem);
            pnlInput.Controls.Add(btnThemDocGia);
            pnlInput.Controls.Add(btnKhoaMoKhoa);
            pnlInput.Controls.Add(btnGiaHan);
            pnlInput.Controls.Add(btnXoaDocGia);
            pnlInput.Dock = DockStyle.Top;
            pnlInput.Location = new Point(0, 0);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(920, 140);
            pnlInput.TabIndex = 0;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(20, 20);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 15);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(90, 17);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 23);
            txtHoTen.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(310, 20);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(79, 15);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(395, 17);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(180, 23);
            txtSDT.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(600, 20);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(650, 17);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(20, 58);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(59, 15);
            lblTimKiem.TabIndex = 6;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(90, 55);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(485, 23);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThemDocGia
            // 
            btnThemDocGia.Location = new Point(90, 92);
            btnThemDocGia.Name = "btnThemDocGia";
            btnThemDocGia.Size = new Size(130, 32);
            btnThemDocGia.TabIndex = 8;
            btnThemDocGia.Text = "Thêm Độc Giả";
            btnThemDocGia.UseVisualStyleBackColor = true;
            btnThemDocGia.Click += btnThemDocGia_Click;
            // 
            // btnKhoaMoKhoa
            // 
            btnKhoaMoKhoa.Location = new Point(235, 92);
            btnKhoaMoKhoa.Name = "btnKhoaMoKhoa";
            btnKhoaMoKhoa.Size = new Size(140, 32);
            btnKhoaMoKhoa.TabIndex = 9;
            btnKhoaMoKhoa.Text = "Khóa / Mở Khóa";
            btnKhoaMoKhoa.UseVisualStyleBackColor = true;
            btnKhoaMoKhoa.Click += btnKhoaMoKhoa_Click;
            // 
            // btnGiaHan
            // 
            btnGiaHan.Location = new Point(390, 92);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(130, 32);
            btnGiaHan.TabIndex = 10;
            btnGiaHan.Text = "Gia Hạn Thẻ";
            btnGiaHan.UseVisualStyleBackColor = true;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // btnXoaDocGia
            // 
            btnXoaDocGia.BackColor = Color.FromArgb(225, 29, 72);
            btnXoaDocGia.FlatStyle = FlatStyle.Flat;
            btnXoaDocGia.ForeColor = Color.White;
            btnXoaDocGia.Location = new Point(535, 92);
            btnXoaDocGia.Name = "btnXoaDocGia";
            btnXoaDocGia.Size = new Size(130, 32);
            btnXoaDocGia.TabIndex = 11;
            btnXoaDocGia.Text = "Xóa Độc Giả";
            btnXoaDocGia.UseVisualStyleBackColor = false;
            btnXoaDocGia.Click += btnXoaDocGia_Click;
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Dock = DockStyle.Fill;
            dgvDocGia.Location = new Point(0, 140);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.ReadOnly = true;
            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocGia.Size = new Size(920, 460);
            dgvDocGia.TabIndex = 1;
            // 
            // FormQuanLyDocGia
            // 
            ClientSize = new Size(920, 600);
            Controls.Add(dgvDocGia);
            Controls.Add(pnlInput);
            Name = "FormQuanLyDocGia";
            Text = "Quản Lý Độc Giả";
            Load += FormQuanLyDocGia_Load;
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnXoaDocGia;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.Button btnKhoaMoKhoa;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.DataGridView dgvDocGia;
    }
}