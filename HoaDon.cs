using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace QL_ThueXe
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Các thành phần khởi tạo
        /// </summary>
        private static HoaDon instance;
        public static HoaDon GetInstance()
        {
            if (instance == null)
                instance = new HoaDon();
            return instance;
        }

        SqlConnection cn; 
        string cnStr; 
        DataTable dt_HoaDon; 
        string option;

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThueXeDataSet2.Xe' table. You can move, or remove it, as needed.
            this.xeTableAdapter.Fill(this.qL_ThueXeDataSet2.Xe);
            // TODO: This line of code loads data into the 'qL_ThueXeDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qL_ThueXeDataSet1.KhachHang);
            cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnStr);

            dgv_HoaDon.DataSource = ThongTinHD();

            if (dgv_HoaDon.Rows.Count > 0 && dgv_HoaDon.Rows[0].Cells[0].Value != null)
            {
                DefaultData();
            }
        }
        /// <summary>
        /// Các xử lý khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private DataTable ThongTinHD()
        {
            string sql = "Select * From View_ThongTinHoaDon";

            dt_HoaDon = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt_HoaDon);
            return dt_HoaDon;
        }
        private void DefaultData()
        {
            txt_ID_HD.Text = dgv_HoaDon.Rows[0].Cells["ID_HD"].Value.ToString();
            cbx_HoTen.Text = dgv_HoaDon.Rows[0].Cells["HoTen"].Value.ToString();
            cbx_TenXe.Text = dgv_HoaDon.Rows[0].Cells["TenXe"].Value.ToString();
            txt_BienSo.Text = dgv_HoaDon.Rows[0].Cells["BienSo"].Value.ToString();
            txt_NgayThue.Text = dgv_HoaDon.Rows[0].Cells["NgayThue"].Value.ToString();
            txt_NgayTra.Text = dgv_HoaDon.Rows[0].Cells["NgayTra"].Value.ToString();
            lbl_DonGia.Text = dgv_HoaDon.Rows[0].Cells["DonGia"].Value.ToString();
            if (txt_NgayTra.Text == "")
            {
                txt_TinhTrang.Text = "Đang Thuê";
            }
            else
            {
                txt_TinhTrang.Text = "Đã Thuê";
            }
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
                {
                    DataGridViewRow row = this.dgv_HoaDon.Rows[e.RowIndex];
                    txt_ID_HD.Text = row.Cells["ID_HD"].Value.ToString();
                    cbx_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                    cbx_TenXe.Text = row.Cells["TenXe"].Value.ToString();
                    txt_BienSo.Text = row.Cells["BienSo"].Value.ToString();
                    txt_NgayThue.Text = row.Cells["NgayThue"].Value.ToString();
                    txt_NgayTra.Text = row.Cells["NgayTra"].Value.ToString();
                    lbl_DonGia.Text = row.Cells["DonGia"].Value.ToString();
                    if (txt_NgayTra.Text == "")
                    {
                        txt_TinhTrang.Text = "Đang Thuê";
                    }
                    else
                    {
                        txt_TinhTrang.Text = "Đã Thuê";
                    }
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdb_DangThue_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
            {
                btn_TimKiem.Enabled = true;
            }
        }

        private void rdb_DaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
            {
                btn_TimKiem.Enabled = true;
            }
        }

        private void OnOff_PanelToolButtons(bool state)
        {
            btn_Them.Enabled = state;
            btn_CapNhat.Enabled = state;
            btn_Xoa.Enabled = state;
            btn_TimKiem.Enabled = state;
            btn_Bill.Enabled = state;
            btn_QuayLai.Enabled = state;
            btn_Dong.Enabled = state;
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
                            pnl_OkNo.Show();
                        } break;

                    case "CapNhat":
                        {
                            OnOff_PanelToolButtons(false);
                            pnl_OkNo.Show();
                        } break;

                    case "Xoa":
                        {
                            OnOff_PanelToolButtons(false);
                            pnl_OkNo.Show();
                        } break;

                    case "TimKiem":
                        {
                            OnOff_PanelToolButtons(true);
                            btn_Them.Enabled = false;
                        } break;

                    case "Bill":
                        {
                            OnOff_PanelToolButtons(false);
                            pnl_OkNo.Show();
                            gbx_ThanhToan.Visible = true;
                            gbx_TimKiem.Visible = false;
                        } break;

                    case "QuayLai":
                        {
                            OnOff_PanelToolButtons(true);
                            pnl_OkNo.Hide();
                            gbx_ThanhToan.Visible = false;
                            gbx_TimKiem.Visible = true;
                        } break;
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Them()
        {
            SqlCommand cmd_ThemHD = new SqlCommand(@"INSERT INTO HoaDon  (ID_HD, CMND, ID_Xe, NgayThue)
                                                        VALUES ('" + txt_ID_HD.Text + "', N'" + cbx_HoTen.SelectedValue.ToString() +
                                                                 "', " + Int32.Parse(cbx_TenXe.SelectedValue.ToString()) + 
                                                                 ", '" + DateTime.Parse(txt_NgayThue.Text) +  "')", cn);
            cn.Open();
            cmd_ThemHD.ExecuteNonQuery();
            cn.Close();
        }

        private void CapNhat()
        {
            SqlCommand cmd_CapNhatHD = new SqlCommand(@"UPDATE HoaDon SET CMND = N'" + cbx_HoTen.SelectedValue.ToString() +
                                                        @"'WHERE ID_HD = N'" + txt_ID_HD.Text + "'", cn);
            cn.Open();
            cmd_CapNhatHD.ExecuteNonQuery();
            cn.Close();
        }

        private void Xoa()
        {
            SqlCommand cmd_XoaHD = new SqlCommand(@"DELETE FROM HoaDon WHERE ID_HD = '" + txt_ID_HD.Text + "'", cn);
            cn.Open();
            cmd_XoaHD.ExecuteNonQuery();
            cn.Close();
        }

        private void Bill()
        {
            SqlCommand cmd_CapNhatNgayTra = new SqlCommand(@"UPDATE HoaDon SET NgayTra = N'" + DateTime.Parse(txt_NgayTra.Text) +
                                                        @"'WHERE ID_HD = N'" + txt_ID_HD.Text + "'", cn);
            cn.Open();
            cmd_CapNhatNgayTra.ExecuteNonQuery();
            cn.Close();
        }

        /// <summary>
        /// Các sử lý sụ kiện button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Them_Click(object sender, EventArgs e)
        {
            CacButtonClicked("Them");
            option = "Them";
            cbx_HoTen.Enabled = true;
            cbx_TenXe.Enabled = true;

            string str_All, str_Year, str_Month, str_Day, str_apm, str_Hour, str_Minute, str_Second;
            str_Year = DateTime.Now.Year.ToString().Substring(2, 2);
            str_Month = DateTime.Now.Month.ToString();
            str_Day = DateTime.Now.Day.ToString();
            str_Hour = DateTime.Now.Hour.ToString();
            str_Minute = DateTime.Now.Minute.ToString();
            str_Second = DateTime.Now.Second.ToString();
            str_apm = DateTime.Now.ToString().Substring(DateTime.Now.ToString().Length - 2, 2);
            str_All = str_Year + str_Month + str_Day + str_apm + str_Hour + str_Minute + str_Second;
            txt_ID_HD.Text = str_All;

            txt_BienSo.Text = "";
            txt_TinhTrang.Text = "";
            txt_NgayTra.Text = "";
            txt_NgayThue.Text = DateTime.Now.ToString();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            CacButtonClicked("CapNhat");
            option = "CapNhat";
            cbx_HoTen.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            CacButtonClicked("Xoa");
            option = "Xoa";
            cbx_HoTen.Enabled = false;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                switch (option)
                {
                    case "Them":
                        {
                            Them();
                        } break;

                    case "CapNhat":
                        {
                            CapNhat();
                        } break;

                    case "Xoa":
                        {
                            Xoa();
                        } break;

                    case "Bill":
                        {
                            Bill();
                            gbx_ThanhToan.Visible = true;
                            gbx_TimKiem.Visible = false;
                        } break;
                        
                }
                dgv_HoaDon.DataSource = ThongTinHD();
                DefaultData();
                OnOff_PanelToolButtons(true);
                cbx_HoTen.Enabled = false;
                cbx_TenXe.Enabled = false;
                pnl_OkNo.Hide();
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
                dgv_HoaDon.DataSource = ThongTinHD();
                DefaultData();
                OnOff_PanelToolButtons(true);
                cbx_HoTen.Enabled = false;
                cbx_TenXe.Enabled = false;
                pnl_OkNo.Hide();
                gbx_ThanhToan.Visible = false;
                gbx_TimKiem.Visible = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                CacButtonClicked("TimKiem");
                string sql_TimKiem;
                DataTable dt_TimKiem = new DataTable();
                if (rdb_DangThue.Checked == true)
                {
                    sql_TimKiem = @"SELECT hd.ID_HD, kh.HoTen, hd.CMND, Xe.TenXe, lx.TenLoaiXe, Xe.BienSo, hd.NgayThue, hd.NgayTra
                                    FROM KhachHang kh, Xe, LoaiXe lx, HoaDon hd
                                    WHERE kh.CMND = hd.CMND AND Xe.ID_Xe = hd.ID_XE AND Xe.ID_LX = lx.ID_LX AND NgayTra IS NULL";
                    SqlDataAdapter da = new SqlDataAdapter(sql_TimKiem, cn);
                    da.Fill(dt_TimKiem);
                    if (dt_TimKiem.Rows.Count == 0)
                    {
                        dt_TimKiem.Clear();
                        dgv_HoaDon.DataSource = dt_TimKiem;
                        MessageBox.Show("Không có nội dung cần tìm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dgv_HoaDon.DataSource = dt_TimKiem;
                        DefaultData();
                    }
                }
                if (rdb_DaThue.Checked == true)
                {
                    sql_TimKiem = @"SELECT hd.ID_HD, kh.HoTen, hd.CMND, Xe.TenXe, lx.TenLoaiXe, Xe.BienSo, hd.NgayThue, hd.NgayTra
                                    FROM KhachHang kh, Xe, LoaiXe lx, HoaDon hd
                                    WHERE kh.CMND = hd.CMND AND Xe.ID_Xe = hd.ID_XE AND Xe.ID_LX = lx.ID_LX AND NgayTra IS NOT NULL"; 
                    SqlDataAdapter da = new SqlDataAdapter(sql_TimKiem, cn);
                    da.Fill(dt_TimKiem);
                    if (dt_TimKiem.Rows.Count == 0)
                    {
                        dt_TimKiem.Clear();
                        dgv_HoaDon.DataSource = dt_TimKiem;
                        MessageBox.Show("Không có nội dung cần tìm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dgv_HoaDon.DataSource = dt_TimKiem;
                        DefaultData();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            CacButtonClicked("Bill");
            pnl_OkNo.Show();
            txt_NgayTra.Text = DateTime.Now.ToString();
            option = "Bill";
            DataTable dt_TongSoNgay = new DataTable();
            string sql_TongSoNgay = @"SELECT (DATEDIFF(Hour,NgayThue, GETDATE())/24 + 
                                            (DATEDIFF(Hour,NgayThue, GETDATE())%24*0.01)) AS TongSoNgay
                                      FROM HoaDon WHERE ID_HD = '" + txt_ID_HD.Text + "'";

            SqlDataAdapter da_TongSoNgay = new SqlDataAdapter(sql_TongSoNgay, cn);
            da_TongSoNgay.Fill(dt_TongSoNgay);
            lbl_TongSoNgay.Text = dt_TongSoNgay.Rows[0][0].ToString();
            
            DataTable dt_ThanhTien = new DataTable();
            string sql_ThanhTien = @"SELECT (DATEDIFF(Hour,NgayThue, GETDATE())/24 + 
                                            (DATEDIFF(Hour,NgayThue, GETDATE())%24*0.01))*DonGia AS TongSoNgay
                                      FROM HoaDon, Xe WHERE ID_HD = '" + txt_ID_HD.Text + "' AND Xe.ID_Xe = HoaDon.ID_Xe";
                                       
            SqlDataAdapter da_ThanhTien = new SqlDataAdapter(sql_ThanhTien, cn);
            da_ThanhTien.Fill(dt_ThanhTien);
            lbl_ThanhTien.Text = dt_ThanhTien.Rows[0][0].ToString();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_HoaDon.DataSource = ThongTinHD();
                DefaultData();
                CacButtonClicked("QuayLai");
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

    }
}
