namespace Library.UI
{
    partial class FormBaoCaoThongKe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            dgvBaoCao = new DataGridView();
            pnlFilterCard = new Panel();
            btnInBaoCao = new Button();
            btnXuatPdf = new Button();
            btnXuatExcel = new Button();
            btnXuatFile = new Button();
            btnXem = new Button();
            dtpDenNgay = new DateTimePicker();
            lblDen = new Label();
            dtpTuNgay = new DateTimePicker();
            lblTu = new Label();
            pnlCard2 = new Panel();
            pnlIndicator2 = new Panel();
            lblValTongSoGiaoDich = new Label();
            lblTitleCard2 = new Label();
            pnlCard1 = new Panel();
            pnlIndicator1 = new Panel();
            lblValTongDoanhThu = new Label();
            lblTitleCard1 = new Label();
            pnlTopHeader = new Panel();
            lblSubTitle = new Label();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            pnlFilterCard.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlTopHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(248, 250, 252);
            pnlMain.Controls.Add(dgvBaoCao);
            pnlMain.Controls.Add(pnlFilterCard);
            pnlMain.Controls.Add(pnlCard2);
            pnlMain.Controls.Add(pnlCard1);
            pnlMain.Controls.Add(pnlTopHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(32, 37, 32, 37);
            pnlMain.Size = new Size(1533, 1108);
            pnlMain.TabIndex = 0;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToDeleteRows = false;
            dgvBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.BackgroundColor = Color.White;
            dgvBaoCao.BorderStyle = BorderStyle.None;
            dgvBaoCao.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBaoCao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBaoCao.ColumnHeadersHeight = 44;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(79, 70, 229);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.GridColor = Color.FromArgb(241, 245, 249);
            dgvBaoCao.Location = new Point(32, 446);
            dgvBaoCao.Margin = new Padding(4, 5, 4, 5);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBaoCao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBaoCao.RowHeadersVisible = false;
            dgvBaoCao.RowHeadersWidth = 51;
            dgvBaoCao.RowTemplate.Height = 40;
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.Size = new Size(1469, 615);
            dgvBaoCao.TabIndex = 4;
            // 
            // pnlFilterCard
            // 
            pnlFilterCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFilterCard.BackColor = Color.White;
            pnlFilterCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFilterCard.Controls.Add(btnInBaoCao);
            pnlFilterCard.Controls.Add(btnXuatPdf);
            pnlFilterCard.Controls.Add(btnXuatExcel);
            pnlFilterCard.Controls.Add(btnXuatFile);
            pnlFilterCard.Controls.Add(btnXem);
            pnlFilterCard.Controls.Add(dtpDenNgay);
            pnlFilterCard.Controls.Add(lblDen);
            pnlFilterCard.Controls.Add(dtpTuNgay);
            pnlFilterCard.Controls.Add(lblTu);
            pnlFilterCard.Location = new Point(32, 323);
            pnlFilterCard.Margin = new Padding(4, 5, 4, 5);
            pnlFilterCard.Name = "pnlFilterCard";
            pnlFilterCard.Size = new Size(1469, 99);
            pnlFilterCard.TabIndex = 3;
            // 
            // btnInBaoCao
            // 
            btnInBaoCao.BackColor = Color.FromArgb(2, 132, 199);
            btnInBaoCao.Cursor = Cursors.Hand;
            btnInBaoCao.FlatAppearance.BorderSize = 0;
            btnInBaoCao.FlatStyle = FlatStyle.Flat;
            btnInBaoCao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnInBaoCao.ForeColor = Color.White;
            btnInBaoCao.Location = new Point(613, 25);
            btnInBaoCao.Margin = new Padding(4, 5, 4, 5);
            btnInBaoCao.Name = "btnInBaoCao";
            btnInBaoCao.Size = new Size(153, 49);
            btnInBaoCao.TabIndex = 0;
            btnInBaoCao.Text = "🖨️ In báo cáo";
            btnInBaoCao.UseVisualStyleBackColor = false;
            btnInBaoCao.Click += btnInBaoCao_Click;
            // 
            // btnXuatPdf
            // 
            btnXuatPdf.BackColor = Color.FromArgb(225, 29, 72);
            btnXuatPdf.Cursor = Cursors.Hand;
            btnXuatPdf.FlatAppearance.BorderSize = 0;
            btnXuatPdf.FlatStyle = FlatStyle.Flat;
            btnXuatPdf.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXuatPdf.ForeColor = Color.White;
            btnXuatPdf.Location = new Point(1127, 25);
            btnXuatPdf.Margin = new Padding(4, 5, 4, 5);
            btnXuatPdf.Name = "btnXuatPdf";
            btnXuatPdf.Size = new Size(160, 49);
            btnXuatPdf.TabIndex = 1;
            btnXuatPdf.Text = "📄 Xuất File";
            btnXuatPdf.UseVisualStyleBackColor = false;
            btnXuatPdf.Click += btnXuatPdf_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(16, 185, 129);
            btnXuatExcel.Cursor = Cursors.Hand;
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(953, 25);
            btnXuatExcel.Margin = new Padding(4, 5, 4, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(160, 49);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "📊 Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.FromArgb(5, 150, 105);
            btnXuatFile.Cursor = Cursors.Hand;
            btnXuatFile.FlatAppearance.BorderSize = 0;
            btnXuatFile.FlatStyle = FlatStyle.Flat;
            btnXuatFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXuatFile.ForeColor = Color.White;
            btnXuatFile.Location = new Point(780, 25);
            btnXuatFile.Margin = new Padding(4, 5, 4, 5);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(160, 49);
            btnXuatFile.TabIndex = 3;
            btnXuatFile.Text = "📥 Xuất CSV";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.FromArgb(30, 41, 59);
            btnXem.Cursor = Cursors.Hand;
            btnXem.FlatAppearance.BorderSize = 0;
            btnXem.FlatStyle = FlatStyle.Flat;
            btnXem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXem.ForeColor = Color.White;
            btnXem.Location = new Point(493, 25);
            btnXem.Margin = new Padding(4, 5, 4, 5);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(107, 49);
            btnXem.TabIndex = 4;
            btnXem.Text = "🔍 Xem";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 9F);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(333, 31);
            dtpDenNgay.Margin = new Padding(4, 5, 4, 5);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(139, 27);
            dtpDenNgay.TabIndex = 5;
            // 
            // lblDen
            // 
            lblDen.AutoSize = true;
            lblDen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDen.ForeColor = Color.FromArgb(51, 65, 85);
            lblDen.Location = new Point(247, 35);
            lblDen.Margin = new Padding(4, 0, 4, 0);
            lblDen.Name = "lblDen";
            lblDen.Size = new Size(79, 20);
            lblDen.TabIndex = 6;
            lblDen.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 9F);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(91, 31);
            dtpTuNgay.Margin = new Padding(4, 5, 4, 5);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(139, 27);
            dtpTuNgay.TabIndex = 7;
            // 
            // lblTu
            // 
            lblTu.AutoSize = true;
            lblTu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTu.ForeColor = Color.FromArgb(51, 65, 85);
            lblTu.Location = new Point(16, 35);
            lblTu.Margin = new Padding(4, 0, 4, 0);
            lblTu.Name = "lblTu";
            lblTu.Size = new Size(68, 20);
            lblTu.TabIndex = 8;
            lblTu.Text = "Từ ngày:";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.BorderStyle = BorderStyle.FixedSingle;
            pnlCard2.Controls.Add(pnlIndicator2);
            pnlCard2.Controls.Add(lblValTongSoGiaoDich);
            pnlCard2.Controls.Add(lblTitleCard2);
            pnlCard2.Location = new Point(480, 169);
            pnlCard2.Margin = new Padding(4, 5, 4, 5);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(346, 130);
            pnlCard2.TabIndex = 2;
            // 
            // pnlIndicator2
            // 
            pnlIndicator2.BackColor = Color.FromArgb(79, 70, 229);
            pnlIndicator2.Dock = DockStyle.Left;
            pnlIndicator2.Location = new Point(0, 0);
            pnlIndicator2.Margin = new Padding(4, 5, 4, 5);
            pnlIndicator2.Name = "pnlIndicator2";
            pnlIndicator2.Size = new Size(7, 128);
            pnlIndicator2.TabIndex = 0;
            // 
            // lblValTongSoGiaoDich
            // 
            lblValTongSoGiaoDich.AutoSize = true;
            lblValTongSoGiaoDich.Font = new Font("Microsoft Sans Serif", 16F);
            lblValTongSoGiaoDich.ForeColor = Color.FromArgb(15, 23, 42);
            lblValTongSoGiaoDich.Location = new Point(21, 58);
            lblValTongSoGiaoDich.Margin = new Padding(4, 0, 4, 0);
            lblValTongSoGiaoDich.Name = "lblValTongSoGiaoDich";
            lblValTongSoGiaoDich.Size = new Size(29, 31);
            lblValTongSoGiaoDich.TabIndex = 1;
            lblValTongSoGiaoDich.Text = "0";
            // 
            // lblTitleCard2
            // 
            lblTitleCard2.AutoSize = true;
            lblTitleCard2.Font = new Font("Microsoft Sans Serif", 8.5F);
            lblTitleCard2.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleCard2.Location = new Point(24, 23);
            lblTitleCard2.Margin = new Padding(4, 0, 4, 0);
            lblTitleCard2.Name = "lblTitleCard2";
            lblTitleCard2.Size = new Size(142, 18);
            lblTitleCard2.TabIndex = 2;
            lblTitleCard2.Text = "TỔNG SỐ BẢN GHI";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.BorderStyle = BorderStyle.FixedSingle;
            pnlCard1.Controls.Add(pnlIndicator1);
            pnlCard1.Controls.Add(lblValTongDoanhThu);
            pnlCard1.Controls.Add(lblTitleCard1);
            pnlCard1.Location = new Point(32, 169);
            pnlCard1.Margin = new Padding(4, 5, 4, 5);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(426, 130);
            pnlCard1.TabIndex = 1;
            // 
            // pnlIndicator1
            // 
            pnlIndicator1.BackColor = Color.FromArgb(5, 150, 105);
            pnlIndicator1.Dock = DockStyle.Left;
            pnlIndicator1.Location = new Point(0, 0);
            pnlIndicator1.Margin = new Padding(4, 5, 4, 5);
            pnlIndicator1.Name = "pnlIndicator1";
            pnlIndicator1.Size = new Size(7, 128);
            pnlIndicator1.TabIndex = 0;
            // 
            // lblValTongDoanhThu
            // 
            lblValTongDoanhThu.AutoSize = true;
            lblValTongDoanhThu.Font = new Font("Microsoft Sans Serif", 16F);
            lblValTongDoanhThu.ForeColor = Color.FromArgb(5, 150, 105);
            lblValTongDoanhThu.Location = new Point(21, 58);
            lblValTongDoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblValTongDoanhThu.Name = "lblValTongDoanhThu";
            lblValTongDoanhThu.Size = new Size(51, 31);
            lblValTongDoanhThu.TabIndex = 1;
            lblValTongDoanhThu.Text = "0 đ";
            // 
            // lblTitleCard1
            // 
            lblTitleCard1.AutoSize = true;
            lblTitleCard1.Font = new Font("Microsoft Sans Serif", 8.5F);
            lblTitleCard1.ForeColor = Color.FromArgb(100, 116, 139);
            lblTitleCard1.Location = new Point(24, 23);
            lblTitleCard1.Margin = new Padding(4, 0, 4, 0);
            lblTitleCard1.Name = "lblTitleCard1";
            lblTitleCard1.Size = new Size(145, 18);
            lblTitleCard1.TabIndex = 2;
            lblTitleCard1.Text = "TỔNG DOANH THU";
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.White;
            pnlTopHeader.Controls.Add(lblSubTitle);
            pnlTopHeader.Controls.Add(lblTitle);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(32, 37);
            pnlTopHeader.Margin = new Padding(4, 5, 4, 5);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1469, 108);
            pnlTopHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9.5F);
            lblSubTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubTitle.Location = new Point(19, 62);
            lblSubTitle.Margin = new Padding(4, 0, 4, 0);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(467, 21);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Theo dõi tài chính, tra cứu chi tiết, in báo cáo và xuất file CSV/Excel";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(16, 15);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(359, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Báo Cáo Thống Kê Doanh Thu";
            // 
            // FormBaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1533, 1108);
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormBaoCaoThongKe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Báo Cáo & Thống Kê Doanh Thu";
            Load += FormBaoCaoThongKe_Load_1;
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            pnlFilterCard.ResumeLayout(false);
            pnlFilterCard.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Panel pnlIndicator1;
        private System.Windows.Forms.Label lblTitleCard1;
        private System.Windows.Forms.Label lblValTongDoanhThu;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlIndicator2;
        private System.Windows.Forms.Label lblTitleCard2;
        private System.Windows.Forms.Label lblValTongSoGiaoDich;
        private System.Windows.Forms.Panel pnlFilterCard;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnXuatPdf;
        private System.Windows.Forms.DataGridView dgvBaoCao;
    }
}