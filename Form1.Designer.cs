namespace hoccsharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSoDo = new System.Windows.Forms.FlowLayoutPanel() { Location = new System.Drawing.Point(12, 12), Size = new System.Drawing.Size(410, 230), BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle };

            this.cboKhungGio = new System.Windows.Forms.ComboBox() { Location = new System.Drawing.Point(530, 15), Size = new System.Drawing.Size(160, 23), DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList };
            this.cboKhungGio.Items.AddRange(new object[] { "Sáng (100.000đ)", "Tối (150.000đ)" });
            this.cboKhungGio.SelectedIndexChanged += new System.EventHandler(this.cboKhungGio_SelectedIndexChanged);

            this.lblSoViTri = new System.Windows.Forms.Label() { Text = "0", Location = new System.Drawing.Point(530, 55), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold) };
            this.lblTamTinh = new System.Windows.Forms.Label() { Text = "0 VNĐ", Location = new System.Drawing.Point(530, 95), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold) };

            this.btnXacNhan = new System.Windows.Forms.Button() { Text = "Xác nhận đặt", Location = new System.Drawing.Point(435, 140), Size = new System.Drawing.Size(120, 35) };
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);

            this.btnHuyChon = new System.Windows.Forms.Button() { Text = "Hủy chọn tất cả", Location = new System.Drawing.Point(565, 140), Size = new System.Drawing.Size(125, 35) };
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);

            this.ClientSize = new System.Drawing.Size(705, 255);
            this.Text = "Interactive Slot Booking";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlSoDo,
                new System.Windows.Forms.Label { Text = "Khung giờ:", Location = new System.Drawing.Point(435, 18), AutoSize = true }, this.cboKhungGio,
                new System.Windows.Forms.Label { Text = "Số vị trí đang chọn:", Location = new System.Drawing.Point(435, 55), AutoSize = true }, this.lblSoViTri,
                new System.Windows.Forms.Label { Text = "Tạm tính tiền:", Location = new System.Drawing.Point(435, 95), AutoSize = true }, this.lblTamTinh,
                this.btnXacNhan, this.btnHuyChon
            });
        }

        private System.Windows.Forms.FlowLayoutPanel pnlSoDo;
        private System.Windows.Forms.ComboBox cboKhungGio;
        private System.Windows.Forms.Label lblSoViTri, lblTamTinh;
        private System.Windows.Forms.Button btnXacNhan, btnHuyChon;
    }
}