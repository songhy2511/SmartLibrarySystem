namespace Library.UI
{
    partial class FormDieuPhoiSach
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSach = new System.Windows.Forms.Label();
            this.lblNguon = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblChonBanSao = new System.Windows.Forms.Label();
            this.cboBanSao = new System.Windows.Forms.ComboBox();
            this.lblThongTinCuon = new System.Windows.Forms.Label();
            this.lblChonDich = new System.Windows.Forms.Label();
            this.cboChiNhanhDich = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(342, 21);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "LUÂN CHUYỂN BẢN SAO GIỮA CÁC CHI NHÁNH";
            // 
            // lblSach
            // 
            this.lblSach.AutoSize = true;
            this.lblSach.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSach.Location = new System.Drawing.Point(22, 45);
            this.lblSach.Name = "lblSach";
            this.lblSach.Size = new System.Drawing.Size(66, 17);
            this.lblSach.TabIndex = 1;
            this.lblSach.Text = "Đầu sách:";
            // 
            // lblNguon
            // 
            this.lblNguon.AutoSize = true;
            this.lblNguon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNguon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNguon.Location = new System.Drawing.Point(22, 70);
            this.lblNguon.Name = "lblNguon";
            this.lblNguon.Size = new System.Drawing.Size(90, 15);
            this.lblNguon.TabIndex = 2;
            this.lblNguon.Text = "Chi nhánh xuất:";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.lblChonBanSao);
            this.pnlCard.Controls.Add(this.cboBanSao);
            this.pnlCard.Controls.Add(this.lblThongTinCuon);
            this.pnlCard.Controls.Add(this.lblChonDich);
            this.pnlCard.Controls.Add(this.cboChiNhanhDich);
            this.pnlCard.Controls.Add(this.lblGhiChu);
            this.pnlCard.Controls.Add(this.txtGhiChu);
            this.pnlCard.Location = new System.Drawing.Point(20, 100);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(465, 220);
            this.pnlCard.TabIndex = 3;
            // 
            // lblChonBanSao
            // 
            this.lblChonBanSao.AutoSize = true;
            this.lblChonBanSao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblChonBanSao.Location = new System.Drawing.Point(15, 12);
            this.lblChonBanSao.Name = "lblChonBanSao";
            this.lblChonBanSao.Size = new System.Drawing.Size(252, 15);
            this.lblChonBanSao.TabIndex = 0;
            this.lblChonBanSao.Text = "1. Chọn cuốn sách / Mã vạch cần chuyển (*):";
            // 
            // cboBanSao
            // 
            this.cboBanSao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanSao.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboBanSao.FormattingEnabled = true;
            this.cboBanSao.Location = new System.Drawing.Point(15, 34);
            this.cboBanSao.Name = "cboBanSao";
            this.cboBanSao.Size = new System.Drawing.Size(430, 25);
            this.cboBanSao.TabIndex = 1;
            this.cboBanSao.SelectedIndexChanged += new System.EventHandler(this.cboBanSao_SelectedIndexChanged);
            // 
            // lblThongTinCuon
            // 
            this.lblThongTinCuon.AutoSize = true;
            this.lblThongTinCuon.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblThongTinCuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblThongTinCuon.Location = new System.Drawing.Point(15, 63);
            this.lblThongTinCuon.Name = "lblThongTinCuon";
            this.lblThongTinCuon.Size = new System.Drawing.Size(188, 15);
            this.lblThongTinCuon.TabIndex = 2;
            this.lblThongTinCuon.Text = "Tình trạng vật lý: Sẵn sàng trên kệ";
            // 
            // lblChonDich
            // 
            this.lblChonDich.AutoSize = true;
            this.lblChonDich.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblChonDich.Location = new System.Drawing.Point(15, 88);
            this.lblChonDich.Name = "lblChonDich";
            this.lblChonDich.Size = new System.Drawing.Size(215, 15);
            this.lblChonDich.TabIndex = 3;
            this.lblChonDich.Text = "2. Chi nhánh tiếp nhận chuyển đến (*):";
            // 
            // cboChiNhanhDich
            // 
            this.cboChiNhanhDich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiNhanhDich.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboChiNhanhDich.FormattingEnabled = true;
            this.cboChiNhanhDich.Location = new System.Drawing.Point(15, 110);
            this.cboChiNhanhDich.Name = "cboChiNhanhDich";
            this.cboChiNhanhDich.Size = new System.Drawing.Size(430, 25);
            this.cboChiNhanhDich.TabIndex = 4;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblGhiChu.Location = new System.Drawing.Point(15, 145);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(117, 15);
            this.lblGhiChu.TabIndex = 5;
            this.lblGhiChu.Text = "3. Ghi chú điều phối:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(15, 167);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(430, 36);
            this.txtGhiChu.TabIndex = 6;
            this.txtGhiChu.Text = "Điều chuyển cân đối nhu cầu bạn đọc";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(220, 335);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(165, 38);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "🔄 XÁC NHẬN CHUYỂN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnHuy.Location = new System.Drawing.Point(395, 335);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 38);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "ĐÓNG";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormDieuPhoiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(505, 395);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblNguon);
            this.Controls.Add(this.lblSach);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDieuPhoiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điều Phối / Luân Chuyển Bản Sao Sách";
            this.Load += new System.EventHandler(this.FormDieuPhoiSach_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSach;
        private System.Windows.Forms.Label lblNguon;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblChonBanSao;
        private System.Windows.Forms.ComboBox cboBanSao;
        private System.Windows.Forms.Label lblThongTinCuon;
        private System.Windows.Forms.Label lblChonDich;
        private System.Windows.Forms.ComboBox cboChiNhanhDich;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}