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

namespace QL_ThueXe
{
    public partial class LoaiXe : Form
    {
        public LoaiXe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Các thành phần khởi tạo
        /// </summary>
        private static LoaiXe instance;
        public static LoaiXe GetInstance()
        {
            if (instance == null)
                instance = new LoaiXe();
            return instance;
        }

        SqlConnection cn; 
        string cnStr; 
        DataTable dt_LoaiXe; 
        string option;

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoaiXe_Load(object sender, EventArgs e)
        {
            cnStr = System.Configuration.ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cn = new SqlConnection(cnStr);

            dgv_LoaiXe.DataSource = ThongTinLoaiXe();

            if (dgv_LoaiXe.Rows[0].Cells[0].Value != null)
            {
                DefaultData();
            }
        }

        /// <summary>
        /// Các xử lý khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private DataTable ThongTinLoaiXe()
        {
            string sql_ThongTinLX = @"SELECT *
                                      FROM LoaiXe ";
            dt_LoaiXe = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql_ThongTinLX, cn); 
            da.Fill(dt_LoaiXe);
            return dt_LoaiXe;
        }
        
        private void DefaultData()
        {
            txt_ID_LX.Text = dgv_LoaiXe.Rows[0].Cells["ID_LX"].Value.ToString();
            txt_TenLX.Text = dgv_LoaiXe.Rows[0].Cells["TenLoaiXe"].Value.ToString();
        }

        private void dgv_LoaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && btn_Them.Enabled == true && btn_CapNhat.Enabled == true && btn_Xoa.Enabled == true )
                 {
                    DataGridViewRow row = this.dgv_LoaiXe.Rows[e.RowIndex];
                    txt_ID_LX.Text = row.Cells["ID_LX"].Value.ToString();
                    txt_TenLX.Text = row.Cells["TenLoaiXe"].Value.ToString();
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnOff_PanelToolButtons(bool state)
        {
            btn_Them.Enabled = state;
            btn_CapNhat.Enabled = state;
            btn_Xoa.Enabled = state;
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
                            txt_TenLX.ReadOnly = false;
                            pnl_OkNoLoad.Show();
                        } break;

                    case "CapNhat":
                        {
                            OnOff_PanelToolButtons(false);
                            pnl_OkNoLoad.Show();
                            txt_TenLX.ReadOnly = false;
                        } break;
                        
                    case "Xoa":
                        {
                            OnOff_PanelToolButtons(false);
                            pnl_OkNoLoad.Show();
                        } break;

                    case "Ok":
                        {
                            txt_ID_LX.ReadOnly = true;
                            txt_TenLX.ReadOnly = true;
                            pnl_OkNoLoad.Hide();
                            OnOff_PanelToolButtons(true);
                        } break;

                    case "No":
                        {
                            OnOff_PanelToolButtons(true);
                            txt_ID_LX.ReadOnly = true;
                            txt_TenLX.ReadOnly = true;
                            pnl_OkNoLoad.Hide();
                            OnOff_PanelToolButtons(true);
                            DefaultData();
                            dgv_LoaiXe.DataSource = ThongTinLoaiXe();
                        } break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error! \n\n" + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Them()
        {
            SqlCommand cmd_ThemLX = new SqlCommand(@"INSERT INTO LoaiXe (ID_LX, TenLoaiXe)
                                                        VALUES (" + Int32.Parse(txt_ID_LX.Text) + ", N'" + txt_TenLX.Text + "')", cn);
            cn.Open();
            cmd_ThemLX.ExecuteNonQuery();
            cn.Close();
            dgv_LoaiXe.DataSource = ThongTinLoaiXe();
        }

        private void CapNhat()
        {
            SqlCommand cmd_CapNhatLX = new SqlCommand(@"UPDATE LoaiXe SET TenLoaiXe = N'" + txt_TenLX.Text + @"' 
                                                        WHERE ID_LX = " + Int32.Parse(txt_ID_LX.Text), cn);
            cn.Open();
            cmd_CapNhatLX.ExecuteNonQuery();
            cn.Close();
            dgv_LoaiXe.DataSource = ThongTinLoaiXe();
        }

        private void Xoa()
        {
            DataTable dt_checkinfo = new DataTable();
            string cmd_checkinfo = @"SELECT * FROM Xe WHERE Xe.ID_LX = " + Int32.Parse(txt_ID_LX.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd_checkinfo, cn);
            da.Fill(dt_checkinfo);
            if (dt_checkinfo.Rows.Count == 0)
            {
                SqlCommand cmd_XoaLX = new SqlCommand(@"DELETE FROM LoaiXe WHERE ID_LX = '" + txt_ID_LX.Text + "'", cn);
                cn.Open();
                cmd_XoaLX.ExecuteNonQuery();
                cn.Close();
                dgv_LoaiXe.DataSource = ThongTinLoaiXe();
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

                string sql = "SELECT TOP 1 ID_LX FROM LoaiXe ORDER BY ID_LX DESC";
                DataTable dt_LastID = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt_LastID);
                txt_ID_LX.Text = (Int32.Parse(dt_LastID.Rows[0][0].ToString()) + 1).ToString();
                txt_TenLX.Text = "";
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

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                CacButtonClicked("Ok");
                switch (option)
                {
                    case "Xoa":
                        {
                            Xoa();
                            DefaultData();
                        } break;
                        
                    case "CapNhat":
                        {
                            CapNhat();
                            DefaultData();
                        } break;

                    case "Them":
                        {
                            Them();
                        } break;
                }
                //switch (option)
                //{
                //    case "Them":
                //        {
                //            if (txt_TenLX.Text != "")
                //            {
                //                ThemLX();
                //                txt_ID_LX.ReadOnly = true;
                //                txt_TenLX.ReadOnly = true;
                //                OnOff_PanelToolButtons(true);
                //            }
                //            else
                //            {
                //                MessageBox.Show("Bạn phải điền đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            }
                //        }
                //        break;

                //    case "CapNhat":
                //        {
                //            if (txt_TenLX.Text != "")
                //            {
                //                CapNhat();
                //                txt_ID_LX.ReadOnly = true;
                //                txt_TenLX.ReadOnly = true;
                //                OnOff_PanelToolButtons(true);
                //            }
                //            else
                //            {
                //                MessageBox.Show("Bạn không được để trống ô Tên Loại Xe!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                //            }
                //        }
                //        break;

                //    case "Xoa":
                //        {
                //            if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                //            {
                //                Xoa();
                //                txt_ID_LX.Text = dgv_LoaiXe.Rows[0].Cells["ID_LX"].Value.ToString();
                //                txt_TenLX.Text = dgv_LoaiXe.Rows[0].Cells["TenLoaiXe"].Value.ToString();
                //                OnOff_PanelToolButtons(true);
                //                //dgv_LoaiXe.DataSource = ThongTinLoaiXe();
                //            }
                //        }
                //        break;
                //}
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
                dgv_LoaiXe.DataSource = ThongTinLoaiXe();
                txt_ID_LX.Text = dgv_LoaiXe.Rows[0].Cells["ID_LX"].Value.ToString();
                txt_TenLX.Text = dgv_LoaiXe.Rows[0].Cells["TenLoaiXe"].Value.ToString();
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
                if (MessageBox.Show("Bạn muốn đóng trang Loại Xe ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
