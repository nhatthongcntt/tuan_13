using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlythongtin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (SqlConnection con = Connection.getSqlConnect())
            {
                con.Open();
                //datagridview
                SqlCommand cmd = new SqlCommand("select * from HoiNghi", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //combobox
                SqlCommand cmd1 = new SqlCommand("select maLoaiPhong from LoaiPhong", con);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    comboBox_loaiphong.Items.Add(rd["maLoaiPhong"].ToString());
                }
                rd.Close();

                con.Close();
            }
        }
        private void Clear()
        {
            dataGridView1.ClearSelection();
            txt_tenHN.Text = "";
            txt_maHN.Text = "";
            txt_SoNguoiThamGia.Text = "";
            comboBox_loaiphong.SelectedIndex = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrows;
            numrows = e.RowIndex;
            try
            {
                txt_maHN.Text = dataGridView1.Rows[numrows].Cells[0].Value.ToString();
                txt_tenHN.Text = dataGridView1.Rows[numrows].Cells[1].Value.ToString();
                txt_SoNguoiThamGia.Text = dataGridView1.Rows[numrows].Cells[2].Value.ToString();
                comboBox_loaiphong.Text = dataGridView1.Rows[numrows].Cells[3].Value.ToString();
            }
            catch(Exception){
                txt_maHN.Text = "";
                txt_tenHN.Text = "";
                txt_SoNguoiThamGia.Text = "";
                comboBox_loaiphong.Text = "";
            }
        }

        private void ThemMoi()
        {
            using (SqlConnection con = Connection.getSqlConnect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into HoiNghi Values(@IDHN, @Name, @songuoi, @IDPhong)", con);
                cmd.Parameters.AddWithValue("@IDHN", txt_maHN.Text);
                cmd.Parameters.AddWithValue("@Name", txt_tenHN.Text);
                cmd.Parameters.AddWithValue("@songuoi", int.Parse(txt_SoNguoiThamGia.Text));
                cmd.Parameters.AddWithValue("@IDPhong", comboBox_loaiphong.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }
        private void XoaHN()
        {
            using (SqlConnection con = Connection.getSqlConnect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete HoiNghi Where maHoiNghi = @IDHN", con);
                cmd.Parameters.AddWithValue("@IDHN", txt_maHN.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }
        
        private void txt_SoNguoiThamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //ràng buộc mã HN
        private bool Check_maHoiNghi()
        {
            if (txt_maHN.Text.Length >= 2)
            {
                string firstTwoChars = txt_maHN.Text.Substring(0, 2);
                if (firstTwoChars != "HN")
                {
                    MessageBox.Show("Mã Hội Nghị phải bắt đầu với 'HN'", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_maHN.Text = "HN";
                    txt_maHN.SelectionStart = txt_maHN.Text.Length;
                    txt_maHN.Focus();
                    return false;
                }
            }

            if (txt_maHN.Text.Length > 5)
            {
                MessageBox.Show("Không được nhập nhiều hơn 5 ký tự", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_maHN.Text = "HN";
                txt_maHN.SelectionStart = txt_maHN.Text.Length;
                txt_maHN.Focus();
                return false;
            }
            return true;
        }
        //ràng buộc tên HN
        private bool Check_tenHN(string input)
        {
            // Kiểm tra xem chuỗi có chứa ký tự đặc biệt hay không
            if (input.Any(char.IsPunctuation))
            {
                MessageBox.Show("Tên hội nghị Không được nhập ký tự đặc biệt", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenHN.Focus();
                return false;
            }

            return true;
        }
        //ràng buộc số người
        private bool Check_Songuoi()
        {
            int songuoi = int.Parse(txt_SoNguoiThamGia.Text);
            if (songuoi < 50)
            {
                MessageBox.Show("Không được nhập ít hơn 50 người", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else { return true; }
        }

        //button thêm mới
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            Clear();
            txt_maHN.Focus();
        }
        //button lưu thêm mới
        private void button_LuuThemMoi_Click(object sender, EventArgs e)
        {
            if ( Check_maHoiNghi())
            {
                if (Check_Songuoi())
                {
                    if(Check_tenHN(txt_tenHN.Text))
                    {
                        ThemMoi();
                        MessageBox.Show("thêm thành công");
                    }
                }
            }
        }
        //button xóa
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            XoaHN();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("việc đóng ứng dụng có chắc chắn không","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        //button kết thúc
        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("việc đóng ứng dụng có chắc chắn không", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
