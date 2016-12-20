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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Các thành phần khởi tạo
        /// </summary>
        private static KhachHang instance;
        public static KhachHang GetInstance()
        {
            if (instance == null)
                instance = new KhachHang();
            return instance;
        }

        SqlConnection cn; 
        string cnStr; 
        DataTable dt_KhachHang; 
        string option,path_HinhCMND = "";
        
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                cnStr = @"Data Source=.;Initial Catalog=QL_ThueXe;Integrated Security=True";
                cn = new SqlConnection(cnStr);

                dgv_KhachHang.DataSource = ThongTinKhachHang();

                if (dgv_KhachHang.Rows[0].Cells[0].Value != null)
                {
                    DefaultData();
                }

                if (path_HinhCMND != "")
                {
                    pic_CMND.Image = Image.FromFile(path_HinhCMND);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n"+ exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Các xử lý khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private DataTable ThongTinKhachHang()
        {
            string sql_ThongTinKH = @"SELECT * FROM KhachHang ";
            dt_KhachHang = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql_ThongTinKH, cn); 
            da.Fill(dt_KhachHang);
            return dt_KhachHang;
        }

        private void DefaultData()
        {
            txt_CMND.Text = dgv_KhachHang.Rows[0].Cells["CMND"].Value.ToString();
            txt_HoTen.Text = dgv_KhachHang.Rows[0].Cells["HoTen"].Value.ToString();
            cbx_GioiTinh.Text = dgv_KhachHang.Rows[0].Cells["GioiTinh"].Value.ToString();
            txt_SDT.Text = dgv_KhachHang.Rows[0].Cells["SDT"].Value.ToString();
            path_HinhCMND = dgv_KhachHang.Rows[0].Cells["Hinh"].Value.ToString();
        }

        private void OnOff_PanelToolButtons(bool state)
        {
            btn_Them.Enabled = state;
            btn_CapNhat.Enabled = state;
            btn_Xoa.Enabled = state;
            btn_QuayLai.Enabled = state;
            btn_Dong.Enabled = state;
        }

        private void ClearAllTextBox()
        {
            txt_CMND.Text = "";
            txt_HoTen.Text = "";
            txt_SDT.Text = "";
            cbx_GioiTinh.Text = "";
        }

        private void rdb_TenKH_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
            {
                btn_TimKiem.Enabled = true;
                txt_NoiDungCanTim.Enabled = true;
            }
        }

        private void rdb_SDT_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
            {
                btn_TimKiem.Enabled = true;
                txt_NoiDungCanTim.Enabled = true;
            }
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
                {
                    DataGridViewRow row = this.dgv_KhachHang.Rows[e.RowIndex];

                    txt_CMND.Text = row.Cells["CMND"].Value.ToString();
                    txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                    cbx_GioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                    txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                    path_HinhCMND = row.Cells["Hinh"].Value.ToString();
                    if (path_HinhCMND != "")
                    {
                        pic_CMND.Image = Image.FromFile(path_HinhCMND);
                    }
                    else
                    {
                        pic_CMND.Image = null;
                    }
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CacButtonClicked(string button)
        {
            try
            {
                switch (button)
                {
                    case "Them":
                        {
                            OnOff_PanelToolButtons(false);
                            ClearAllTextBox();
                            pnl_OkNoLoad.Show();
                            btn_XoaHinhAnh.Visible = false;
                            gbx_TimKiem.Enabled = false;

                            txt_CMND.ReadOnly = false;
                            txt_HoTen.ReadOnly = false;
                            txt_SDT.ReadOnly = false;
                            cbx_GioiTinh.Enabled = true;
                        }break;

                    case "CapNhat":
                        {
                            OnOff_PanelToolButtons(false);
                            pnl_OkNoLoad.Show();
                            btn_XoaHinhAnh.Visible = true;
                            gbx_TimKiem.Enabled = false;

                            txt_HoTen.ReadOnly = false;
                            txt_SDT.ReadOnly = false;
                            cbx_GioiTinh.Enabled = true;
                        }break;
                        

                    case "Xoa":
                        {
                            OnOff_PanelToolButtons(false);
                            gbx_TimKiem.Enabled = false;
                            pnl_OkNoLoad.Show();
                            btn_Load.Visible = false;
                            btn_XoaHinhAnh.Visible = false;
                        }break;
                        


                    case "Ok":
                        {
                            OnOff_PanelToolButtons(true);
                            pnl_OkNoLoad.Hide();
                            btn_XoaHinhAnh.Enabled = true;
                            btn_Load.Visible = true;
                            gbx_TimKiem.Enabled = true;

                            txt_CMND.ReadOnly = true;
                            txt_HoTen.ReadOnly = true;
                            txt_SDT.ReadOnly = true;
                            cbx_GioiTinh.Enabled = false;
                            DefaultData();
                            if (path_HinhCMND != "")
                            {
                                pic_CMND.Image = Image.FromFile(path_HinhCMND);
                            }
                        }break;
                        

                    case "No":
                        {
                            OnOff_PanelToolButtons(true);
                            btn_TimKiem.Enabled = true;
                            txt_NoiDungCanTim.Enabled = true;
                            pnl_OkNoLoad.Hide();
                            btn_XoaHinhAnh.Enabled = true;
                            btn_Load.Visible = true;
                            gbx_TimKiem.Enabled = true;
                            txt_CMND.ReadOnly = true;
                            txt_HoTen.ReadOnly = true;
                            txt_SDT.ReadOnly = true;
                            cbx_GioiTinh.Enabled = false;
                            DefaultData();
                            dgv_KhachHang.DataSource = ThongTinKhachHang();
                            if (path_HinhCMND != "")
                            {
                                pic_CMND.Image = Image.FromFile(path_HinhCMND);
                            }
                        }break;

                    case "TimKiem":
                        {
                            OnOff_PanelToolButtons(true);
                            btn_Them.Enabled = false;
                            btn_QuayLai.Enabled = true;
                            pnl_OkNoLoad.Visible = false;
                        }
                        break;

                    case "QuayLai":
                        {
                            OnOff_PanelToolButtons(true);
                            pnl_OkNoLoad.Visible = false;
                            gbx_TimKiem.Enabled = true;
                        }
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
        }

        private void ThemKhachHang()
        {
            SqlCommand cmd_ThemKH = new SqlCommand(@"INSERT INTO KhachHang (CMND, HoTen, SDT, GioiTinh, Hinh)
                                                        VALUES (N'" + txt_CMND.Text + "', N'" + txt_HoTen.Text +
                                                                 "', N'" + txt_SDT.Text + "', N'" + cbx_GioiTinh.Text +
                                                                 "', N'" + path_HinhCMND + "')", cn);
            cn.Open();
            cmd_ThemKH.ExecuteNonQuery();
            cn.Close();

            if (path_HinhCMND != "")
            {
                pic_CMND.Image = Image.FromFile(path_HinhCMND);
            }
            dgv_KhachHang.DataSource = ThongTinKhachHang();
        }

        private void CapNhat()
        {
            SqlCommand cmd_CapNhatKH = new SqlCommand(@"UPDATE KhachHang SET CMND = N'" + txt_CMND.Text + "', HoTen = N'" + txt_HoTen.Text + @"',
                                            SDT = N'" + txt_SDT.Text + @"', GioiTinh = '" + cbx_GioiTinh.Text + @"', Hinh = '" + path_HinhCMND  + @"' 
                                            WHERE CMND = '" + txt_CMND.Text + "'", cn);
            cn.Open();
            cmd_CapNhatKH.ExecuteNonQuery();
            cn.Close();

            if (path_HinhCMND != "")
            {
                pic_CMND.Image = Image.FromFile(path_HinhCMND);
            }
            dgv_KhachHang.DataSource = ThongTinKhachHang();
        }

        private void Xoa()
        {
            DataTable dt_checkinfo = new DataTable();
            string cmd_checkinfo = @"SELECT * FROM HoaDon hd 
                                    WHERE hd.CMND = '" + txt_CMND.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd_checkinfo,cn);
            da.Fill(dt_checkinfo);
            
            if (dt_checkinfo.Rows.Count == 0)
            {
                SqlCommand cmd_XoaKH = new SqlCommand(@"DELETE FROM KhachHang WHERE CMND = '" + txt_CMND.Text + "'", cn);
                cn.Open();
                cmd_XoaKH.ExecuteNonQuery();
                cn.Close();
                dgv_KhachHang.DataSource = ThongTinKhachHang();
            }
            else
            {
                MessageBox.Show("Dữ liệu liên quan đến thông tin Hóa Đơn, không thể xóa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Các sử lý sụ kiện button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                CacButtonClicked("Them");
                option = "Them";

                pic_CMND.Image = null;
                path_HinhCMND = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                CacButtonClicked("CapNhat");
                option = "CapNhat";
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                CacButtonClicked("Xoa");
                option = "Xoa";
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql_TimKiem;
            DataTable dt_TimKiem = new DataTable();
            try
            {
                CacButtonClicked("TimKiem");

                if (txt_NoiDungCanTim.Text == "")
                {
                    dt_TimKiem.Clear();
                    dgv_KhachHang.DataSource = dt_TimKiem;
                    ClearAllTextBox();
                    MessageBox.Show("Không có nội dung cần tìm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rdb_TenKH.Checked == true)
                    {
                        sql_TimKiem = @"SELECT * FROM KhachHang
                                                WHERE HoTen LIKE N'%" + txt_NoiDungCanTim.Text.Trim() + "%'";
                        
                        SqlDataAdapter da = new SqlDataAdapter(sql_TimKiem, cn);
                        da.Fill(dt_TimKiem);
                        if (dt_TimKiem.Rows.Count == 0)
                        {
                            dt_TimKiem.Clear();
                            dgv_KhachHang.DataSource = dt_TimKiem;
                            btn_CapNhat.Enabled = false;
                            btn_Xoa.Enabled = false;
                            MessageBox.Show("Không có nội dung cần tìm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dgv_KhachHang.DataSource = dt_TimKiem;
                            DefaultData();
                        }
                    }

                    if (rdb_SDT.Checked == true)
                    {
                        sql_TimKiem = @"SELECT * FROM KhachHang
                                                WHERE SDT LIKE N'%" + txt_NoiDungCanTim.Text + "%'";
                        SqlDataAdapter da = new SqlDataAdapter(sql_TimKiem, cn);
                        da.Fill(dt_TimKiem);
                        if (dt_TimKiem.Rows.Count == 0)
                        {
                            dt_TimKiem.Clear();
                            dgv_KhachHang.DataSource = dt_TimKiem;
                            btn_CapNhat.Enabled = false;
                            btn_Xoa.Enabled = false;
                            MessageBox.Show("Không có nội dung cần tìm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dgv_KhachHang.DataSource = dt_TimKiem;
                            DefaultData();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_KhachHang.DataSource = ThongTinKhachHang();
                CacButtonClicked("TimKiem");
                DefaultData();
                btn_Them.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn đóng trang Khách Hàng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                switch (option)
                {
                    case "Them":
                        {
                            if (txt_CMND.Text != "")
                            {
                                ThemKhachHang();
                                CacButtonClicked("Ok");
                            }
                            else
                            {
                                MessageBox.Show("Bạn không được để trống ô CMND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }break;

                    case "CapNhat":
                        {
                            if (txt_CMND.Text != "")
                            {
                                CapNhat();
                                CacButtonClicked("Ok");
                            }
                            else
                            {
                                MessageBox.Show("Bạn không được để trống ô CMND!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }break;

                    case "Xoa":
                        {
                            if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                Xoa();
                                CacButtonClicked("Ok");
                                DefaultData();
                            }
                        }break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            try
            {
                CacButtonClicked("No");
                dgv_KhachHang.DataSource = ThongTinKhachHang();
                DefaultData();
                if (path_HinhCMND != "")
                {
                    pic_CMND.Image = Image.FromFile(path_HinhCMND);
                }
                else
                {
                    pic_CMND.Image = null;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path_HinhCMND = openFileDialog1.FileName.ToString();
                    pic_CMND.Image = Image.FromFile(path_HinhCMND);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaHinhAnh_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa hình CMND?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    pic_CMND.Image = null;
                    btn_XoaHinhAnh.Enabled = false;
                    path_HinhCMND = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
    }
}