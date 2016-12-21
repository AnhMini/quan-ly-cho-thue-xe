using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Collections;


namespace QL_ThueXe
{
    public partial class Xe : Form
    {
        public Xe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Các thành phần khởi tạo
        /// </summary>
        private static Xe instance;
        public static Xe GetInstance()
        {
            if (instance == null)
                instance = new Xe();
            return instance;
        }

        SqlConnection cn; 
        string cnStr; 
        DataTable dt_Xe; 
        string option, path_HinhXe = null;

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Xe_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'qL_ThueXeDataSet.LoaiXe' table. You can move, or remove it, as needed.
                this.loaiXeTableAdapter.Fill(this.qL_ThueXeDataSet.LoaiXe);

                // Kết nối database
                cnStr = @"Data Source=.;Initial Catalog=QL_ThueXe;Integrated Security=True";
                cn = new SqlConnection(cnStr);

                // Up data lên gridview KhachHang
                dgv_Xe.DataSource = ThongTinXe();
                dgv_Xe.Columns[2].Visible = false;

                // Up lên lable, combobox và textbox 
                if (dgv_Xe.Rows[0].Cells[0].Value != null)
                {
                    DefaultData();
                }

                // Groupbox tìm kiếm
                rdb_BienSo.Checked = false;
                rdb_TenXe.Checked = false;
                btn_TimKiem.Enabled = false;

                // Load hình nếu có
                if (path_HinhXe != "")
                {
                    pic_Xe.Image = Image.FromFile(path_HinhXe);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Các xử lý khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private DataTable ThongTinXe()
        {
            string sql_ThongTinXe = @"SELECT x.ID_Xe, x.TenXe, x.ID_LX, lx.TenLoaiXe, x.BienSo, x.DonGia, x.Hinh 
                                        FROM Xe x, LoaiXe lx
                                        WHERE x.ID_LX = lx.ID_LX";
            dt_Xe = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql_ThongTinXe, cn); // Kết nối CSDL và lấy thông tin dựa vào lệnh sql_ThongTinKH
            da.Fill(dt_Xe);
            return dt_Xe;
        }

        private void DefaultData()
        {
            txt_ID_Xe.Text = dgv_Xe.Rows[0].Cells["ID_Xe"].Value.ToString();
            txt_TenXe.Text = dgv_Xe.Rows[0].Cells["TenXe"].Value.ToString();
            cbx_LoaiXe.Text = dgv_Xe.Rows[0].Cells["TenLoaiXe"].Value.ToString();
            txt_BienSo.Text = dgv_Xe.Rows[0].Cells["BienSo"].Value.ToString();
            txt_DonGia.Text = dgv_Xe.Rows[0].Cells["DonGia"].Value.ToString();
            path_HinhXe = dgv_Xe.Rows[0].Cells["Hinh"].Value.ToString();
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
            txt_TenXe.Text = "";
            txt_DonGia.Text = "";
            txt_BienSo.Text = "";
        }

        private void rdb_TenXe_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
            {
                txt_NoiDungCanTim.Enabled = true;
                btn_TimKiem.Enabled = true;
            }
        }

        private void rdb_BienSo_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
            {
                txt_NoiDungCanTim.Enabled = true;
                btn_TimKiem.Enabled = true;
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
                            btn_XoaHinhAnh.Visible = true;
                            btn_Load.Visible = true;
                            txt_TenXe.ReadOnly = false;
                            txt_DonGia.ReadOnly = false;
                            txt_BienSo.ReadOnly = false;
                            cbx_LoaiXe.Enabled = true;
                        } break;

                    case "CapNhat":
                        {
                            OnOff_PanelToolButtons(false);
                            pnl_OkNoLoad.Show();
                            btn_XoaHinhAnh.Visible = true;
                            gbx_TimKiem.Enabled = false;
                            btn_XoaHinhAnh.Visible = true;
                            btn_Load.Visible = true;
                            txt_TenXe.ReadOnly = false;
                            txt_DonGia.ReadOnly = false;
                            txt_BienSo.ReadOnly = false;
                            cbx_LoaiXe.Enabled = true;
                        } break;

                    case "Xoa":
                        {
                            OnOff_PanelToolButtons(false);
                            gbx_TimKiem.Enabled = false;
                            pnl_OkNoLoad.Show();
                            btn_Load.Visible = false;
                            btn_XoaHinhAnh.Visible = false;

                        } break;

                    case "Ok":
                        {
                            OnOff_PanelToolButtons(true);
                            pnl_OkNoLoad.Hide();
                            btn_XoaHinhAnh.Enabled = true;
                            btn_Load.Visible = true;
                            gbx_TimKiem.Enabled = true;
                            btn_XoaHinhAnh.Visible = false;
                            btn_Load.Visible = false;
                            txt_ID_Xe.ReadOnly = true;
                            txt_TenXe.ReadOnly = true;
                            txt_DonGia.ReadOnly = true;
                            txt_BienSo.ReadOnly = true;
                            cbx_LoaiXe.Enabled = false;
                            DefaultData();
                            dgv_Xe.DataSource = ThongTinXe();
                            if (path_HinhXe != "")
                            {
                                pic_Xe.Image = Image.FromFile(path_HinhXe);
                            }
                        } break;


                    case "No":
                        {
                            OnOff_PanelToolButtons(true);
                            btn_TimKiem.Enabled = true;
                            txt_NoiDungCanTim.Enabled = true;
                            pnl_OkNoLoad.Hide();
                            btn_XoaHinhAnh.Visible = false;
                            btn_Load.Visible = false;
                            gbx_TimKiem.Enabled = true;
                            txt_ID_Xe.ReadOnly = true;
                            txt_TenXe.ReadOnly = true;
                            txt_DonGia.ReadOnly = true;
                            txt_BienSo.ReadOnly = true;
                            cbx_LoaiXe.Enabled = false;
                            DefaultData();
                            dgv_Xe.DataSource = ThongTinXe();
                            if (path_HinhXe != "")
                            {
                                pic_Xe.Image = Image.FromFile(path_HinhXe);
                            }
                        } break;

                    case "TimKiem":
                        {
                            OnOff_PanelToolButtons(true);
                            btn_Them.Enabled = false;
                            btn_QuayLai.Enabled = true;
                            pnl_OkNoLoad.Visible = false;
                        } break;

                    case "QuayLai":
                        {
                            OnOff_PanelToolButtons(true);
                            pnl_OkNoLoad.Visible = false;
                            gbx_TimKiem.Enabled = true;
                        } break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true)
                {
                    DataGridViewRow row = this.dgv_Xe.Rows[e.RowIndex];
                    txt_ID_Xe.Text = row.Cells["ID_Xe"].Value.ToString();
                    txt_TenXe.Text = row.Cells["TenXe"].Value.ToString();
                    txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
                    txt_BienSo.Text = row.Cells["BienSo"].Value.ToString();
                    cbx_LoaiXe.Text = row.Cells["TenLoaiXe"].Value.ToString();
                    path_HinhXe = row.Cells["Hinh"].Value.ToString();
                    if (path_HinhXe != "")
                    {
                        pic_Xe.Image = Image.FromFile(path_HinhXe);
                    }
                    else
                    {
                        pic_Xe.Image = null;
                    }
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemXe()
        {
            SqlCommand cmd_ThemXe = new SqlCommand(@"INSERT INTO Xe  (ID_Xe, TenXe, ID_LX, BienSo, DonGia, Hinh)
                                                        VALUES (" + Int32.Parse(txt_ID_Xe.Text) + ", N'" + txt_TenXe.Text +
                                                                 "', " + Int32.Parse(cbx_LoaiXe.SelectedValue.ToString()) + ", N'" + txt_BienSo.Text +
                                                                 "', " + Int32.Parse(txt_DonGia.Text) + ", N'" + path_HinhXe + "')", cn);
            cn.Open();
            cmd_ThemXe.ExecuteNonQuery();
            cn.Close();

            if (path_HinhXe != "")
            {
                pic_Xe.Image = Image.FromFile(path_HinhXe);
            }
            dgv_Xe.DataSource = ThongTinXe();
        }

        private void CapNhat()
        {
            SqlCommand cmd_CapNhatXe = new SqlCommand(@"UPDATE Xe SET TenXe = N'" + txt_TenXe.Text + "', ID_LX = " + Int32.Parse(cbx_LoaiXe.SelectedValue.ToString()) + @",
                                            BienSo = N'" + txt_BienSo.Text + @"', DonGia = " + Int32.Parse(txt_DonGia.Text) + @", Hinh = N'" + path_HinhXe + @"' 
                                            WHERE ID_Xe = " + Int32.Parse(txt_ID_Xe.Text) + "", cn);
            cn.Open();
            cmd_CapNhatXe.ExecuteNonQuery();
            cn.Close();

            if (path_HinhXe != "")
            {
                pic_Xe.Image = Image.FromFile(path_HinhXe);
            }
            dgv_Xe.DataSource = ThongTinXe();
        }

        private void Xoa()
        {
            DataTable dt_checkinfo = new DataTable();
            string cmd_checkinfo = @"SELECT * FROM HoaDon hd  
                                    WHERE hd.ID_XE ='" + txt_ID_Xe.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd_checkinfo, cn);
            da.Fill(dt_checkinfo);

            if (dt_checkinfo.Rows.Count == 0)
            {
                SqlCommand cmd_XoaXe = new SqlCommand(@"DELETE FROM Xe WHERE ID_Xe = '" + txt_ID_Xe.Text + "'", cn);
                cn.Open();
                cmd_XoaXe.ExecuteNonQuery();
                cn.Close();
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

                string sql = "SELECT TOP 1 ID_Xe FROM Xe ORDER BY ID_Xe DESC";
                DataTable dt_LastID = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt_LastID);
                txt_ID_Xe.Text = (Int32.Parse(dt_LastID.Rows[0][0].ToString()) + 1).ToString();
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
            // Tim kiem xe
            string sql_TimKiem;
            DataTable dt_TimKiem = new DataTable();
            try
            {
                CacButtonClicked("TimKiem");
                option = "TiemKiem";

                if (txt_NoiDungCanTim.Text == "")
                {
                    dt_TimKiem.Clear();
                    dgv_Xe.DataSource = dt_TimKiem;
                    ClearAllTextBox();
                    MessageBox.Show("Không có nội dung cần tìm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rdb_TenXe.Checked == true)
                    {
                        sql_TimKiem = @"SELECT x.ID_Xe, x.TenXe, x.ID_LX, lx.TenLoaiXe, x.BienSo, x.DonGia, x.Hinh
                                        FROM Xe x,LoaiXe lx WHERE TenXe LIKE N'%" + txt_NoiDungCanTim.Text.Trim() + "%'";
                        SqlDataAdapter da = new SqlDataAdapter(sql_TimKiem, cn);
                        da.Fill(dt_TimKiem);
                        if (dt_TimKiem.Rows.Count == 0)
                        {
                            dt_TimKiem.Clear();
                            dgv_Xe.DataSource = dt_TimKiem;
                            dgv_Xe.Columns[2].Visible = false;
                            btn_CapNhat.Enabled = false;
                            btn_Xoa.Enabled = false;
                            MessageBox.Show("Không có nội dung cần tìm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dgv_Xe.DataSource = dt_TimKiem;
                            dgv_Xe.Columns[2].Visible = false;
                            DefaultData();
                        }
                    }

                    if (rdb_BienSo.Checked == true)
                    {
                        sql_TimKiem = @"SELECT x.ID_Xe, x.TenXe, x.ID_LX, lx.TenLoaiXe, x.BienSo, x.DonGia, x.Hinh
                                        FROM Xe x,LoaiXe lx WHERE BienSo LIKE N'%" + txt_NoiDungCanTim.Text + "%'";
                        SqlDataAdapter da = new SqlDataAdapter(sql_TimKiem, cn);
                        da.Fill(dt_TimKiem);
                        if (dt_TimKiem.Rows.Count == 0)
                        {
                            dt_TimKiem.Clear();
                            dgv_Xe.DataSource = dt_TimKiem;
                            dgv_Xe.Columns[2].Visible = false;
                            btn_CapNhat.Enabled = false;
                            btn_Xoa.Enabled = false;
                            MessageBox.Show("Không có nội dung cần tìm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dgv_Xe.DataSource = dt_TimKiem;
                            dgv_Xe.Columns[2].Visible = false;
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
                dgv_Xe.DataSource = ThongTinXe();
                DefaultData();
                btn_QuayLai.Enabled = false;
                OnOff_PanelToolButtons(true);
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
                if (MessageBox.Show("Bạn muốn đóng trang Thông Tin Xe ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                            if (txt_TenXe.Text != "" && txt_DonGia.Text != "" && txt_BienSo.Text != "")
                            {
                                ThemXe();
                                CacButtonClicked("Ok");
                            }
                            else
                            {
                                MessageBox.Show("Bạn không được để trống các ô!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } break;

                    case "CapNhat":
                        {
                            if (txt_TenXe.Text != "" && txt_DonGia.Text != "" && txt_BienSo.Text != "")
                            {
                                CapNhat();
                                CacButtonClicked("Ok");
                            }
                            else
                            {
                                MessageBox.Show("Bạn không được để trống các ô!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        } break;

                    case "Xoa":
                        {
                            if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                Xoa();
                                CacButtonClicked("Ok");
                                DefaultData();
                            }
                        } break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n"+ exc.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            try
            {
                CacButtonClicked("No");
                option = "No";
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
                    path_HinhXe = openFileDialog1.FileName.ToString();
                    pic_Xe.Image = Image.FromFile(path_HinhXe);
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
                if (MessageBox.Show("Bạn có chắc muốn xóa hình Xe?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    pic_Xe.Image = null;
                    btn_XoaHinhAnh.Enabled = false;
                    path_HinhXe = "";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
