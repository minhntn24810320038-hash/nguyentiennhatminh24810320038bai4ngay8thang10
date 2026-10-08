using System;
using System.Drawing;
using System.Windows.Forms;

namespace hoccsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlSoDo.Controls.Clear();
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button
                {
                    Text = "Vị trí " + i,
                    Width = 72,
                    Height = 45,
                    BackColor = Color.White,
                    Margin = new Padding(4),
                    UseVisualStyleBackColor = false
                };
                btn.Click += ViTri_Click;
                pnlSoDo.Controls.Add(btn);
            }
            cboKhungGio.SelectedIndex = 0;
            CapNhatThongKe();
        }

        private void ViTri_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (btn.BackColor == Color.Tomato)
            {
                MessageBox.Show("Vị trí này đã có người đặt!");
                return;
            }

            if (btn.BackColor == Color.LightGreen)
            {
                btn.BackColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.LightGreen;
            }

            CapNhatThongKe();
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKe();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Control c in pnlSoDo.Controls)
            {
                if (c is Button btn && btn.BackColor == Color.LightGreen)
                {
                    btn.BackColor = Color.Tomato;
                    count++;
                }
            }

            if (count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí!");
                return;
            }

            MessageBox.Show($"Đã xác nhận đặt thành công {count} vị trí!", "Thông báo");
            CapNhatThongKe();
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlSoDo.Controls)
            {
                if (c is Button btn && btn.BackColor == Color.LightGreen)
                {
                    btn.BackColor = Color.White;
                }
            }
            CapNhatThongKe();
        }

        private void CapNhatThongKe()
        {
            int count = 0;
            foreach (Control c in pnlSoDo.Controls)
            {
                if (c is Button btn && btn.BackColor == Color.LightGreen)
                {
                    count++;
                }
            }

            int donGia = cboKhungGio.SelectedIndex == 1 ? 150000 : 100000;
            decimal tamTinh = count * donGia;

            lblSoViTri.Text = count.ToString();
            lblTamTinh.Text = tamTinh.ToString("N0") + " VNĐ";
        }
    }
}