using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace QL_ThueXe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Các thành phần khởi tạo
        /// </summary>
        KhachHang frm_KhachHang = KhachHang.GetInstance();
        LoaiXe frm_LoaiXe = LoaiXe.GetInstance();
        Xe frm_Xe = Xe.GetInstance();
        HoaDon frm_HoaDon = HoaDon.GetInstance();
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Các hàm hỗ trợ
        /// </summary>
        private void KhoaMenuItems()
        {
            try
            {
                mit_KhachHang.Enabled = false;
                mit_LoaiXe.Enabled = false;
                mit_Xe.Enabled = false;
                mit_HoaDon.Enabled = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void CacMenuItemClicked(string button)
        {
            try
            {
                switch (button)
                {
                    case "KhachHang":
                        {
                            KhoaMenuItems();
                            mit_KhachHang.Enabled = true;
                        }
                        break;

                    case "LoaiXe":
                        {
                            KhoaMenuItems();
                            mit_LoaiXe.Enabled = true;
                        }
                        break;

                    case "Xe":
                        {
                            KhoaMenuItems();
                            mit_Xe.Enabled = true;
                        }
                        break;

                    case "HoaDon":
                        {
                            KhoaMenuItems();
                            mit_HoaDon.Enabled = true;
                        }
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        /// <summary>
        /// Menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mit_KhachHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang.MdiParent = this;
            if (frm_HoaDon.Visible == true || frm_LoaiXe.Visible == true || frm_Xe.Visible == true)
            {
                MessageBox.Show("Không thể mở khi chưa tắt các bảng khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (frm_KhachHang.Visible == false || frm_KhachHang.Visible == true)
                {
                    frm_KhachHang.Show();
                    frm_KhachHang.BringToFront();
                }
            }
        }

        private void mit_LoaiXe_Click(object sender, EventArgs e)
        {
            try
            {
                frm_LoaiXe.MdiParent = this;
                if (frm_HoaDon.Visible == true || frm_KhachHang.Visible == true || frm_Xe.Visible == true)
                {
                    MessageBox.Show("Không thể mở khi chưa tắt bảng hiện tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (frm_LoaiXe.Visible == false || frm_LoaiXe.Visible == true)
                    {
                        frm_LoaiXe.Show();
                        frm_LoaiXe.BringToFront();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n"+exc.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mit_Xe_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Xe.MdiParent = this;
                if (frm_HoaDon.Visible == true || frm_KhachHang.Visible == true || frm_LoaiXe.Visible == true)
                {
                    MessageBox.Show("Không thể mở khi chưa tắt bảng hiện tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (frm_Xe.Visible == false || frm_Xe.Visible == true)
                    {
                        frm_Xe.Show();
                        frm_Xe.BringToFront();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mit_HoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                frm_HoaDon.MdiParent = this;
                if (frm_Xe.Visible == true || frm_KhachHang.Visible == true || frm_LoaiXe.Visible == true)
                {
                    MessageBox.Show("Không thể mở khi chưa tắt bảng hiện tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (frm_HoaDon.Visible == false || frm_HoaDon.Visible == true)
                    {
                        frm_HoaDon.Show();
                        frm_HoaDon.BringToFront();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mit_ThongTinNhom_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("DANH SÁCH THÀNH VIÊN:\n\nHọ Tên SV1 (Leader)\nMSSV1\n\nHọ Tên SV2\nMSSV2\n\nHọ Tên SV3\nMSSV3",
                                  "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mit_ExitAll_Click(object sender, EventArgs e)
        {
            // chinh sua ma nguon
            try
            {
                if (frm_KhachHang.Visible == true || frm_HoaDon.Visible == true || frm_LoaiXe.Visible == true || frm_Xe.Visible == true)
                {
                    MessageBox.Show("Bạn phải tắt bảng thông tin hiện tại!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frm_KhachHang.Visible == true || frm_HoaDon.Visible == true || frm_LoaiXe.Visible == true || frm_Xe.Visible == true)
                {
                    MessageBox.Show("Bạn phải tắt bảng thông tin hiện tại!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    if (MessageBox.Show("Bạn muốn thoát Chương Trình ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

    }
}
