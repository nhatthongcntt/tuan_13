namespace quanlythongtin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maHN = new System.Windows.Forms.TextBox();
            this.txt_tenHN = new System.Windows.Forms.TextBox();
            this.txt_SoNguoiThamGia = new System.Windows.Forms.TextBox();
            this.comboBox_loaiphong = new System.Windows.Forms.ComboBox();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.button_LuuThemMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KetThuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "-THÔNG TIN PHÒNG HỘI NGHỊ-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hội Nghị :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hội Nghị :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Phòng HN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số người tham gia :";
            // 
            // txt_maHN
            // 
            this.txt_maHN.Location = new System.Drawing.Point(115, 51);
            this.txt_maHN.Name = "txt_maHN";
            this.txt_maHN.Size = new System.Drawing.Size(517, 20);
            this.txt_maHN.TabIndex = 5;
            // 
            // txt_tenHN
            // 
            this.txt_tenHN.Location = new System.Drawing.Point(115, 84);
            this.txt_tenHN.Name = "txt_tenHN";
            this.txt_tenHN.Size = new System.Drawing.Size(517, 20);
            this.txt_tenHN.TabIndex = 6;
            // 
            // txt_SoNguoiThamGia
            // 
            this.txt_SoNguoiThamGia.Location = new System.Drawing.Point(380, 118);
            this.txt_SoNguoiThamGia.Name = "txt_SoNguoiThamGia";
            this.txt_SoNguoiThamGia.Size = new System.Drawing.Size(252, 20);
            this.txt_SoNguoiThamGia.TabIndex = 7;
            this.txt_SoNguoiThamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoNguoiThamGia_KeyPress);
            // 
            // comboBox_loaiphong
            // 
            this.comboBox_loaiphong.FormattingEnabled = true;
            this.comboBox_loaiphong.Location = new System.Drawing.Point(115, 117);
            this.comboBox_loaiphong.Name = "comboBox_loaiphong";
            this.comboBox_loaiphong.Size = new System.Drawing.Size(121, 21);
            this.comboBox_loaiphong.TabIndex = 8;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Location = new System.Drawing.Point(10, 165);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(94, 23);
            this.btn_ThemMoi.TabIndex = 9;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = true;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // button_LuuThemMoi
            // 
            this.button_LuuThemMoi.Location = new System.Drawing.Point(135, 165);
            this.button_LuuThemMoi.Name = "button_LuuThemMoi";
            this.button_LuuThemMoi.Size = new System.Drawing.Size(101, 23);
            this.button_LuuThemMoi.TabIndex = 10;
            this.button_LuuThemMoi.Text = "Lưu thêm mới";
            this.button_LuuThemMoi.UseVisualStyleBackColor = true;
            this.button_LuuThemMoi.Click += new System.EventHandler(this.button_LuuThemMoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(262, 165);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 23);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = " Xóa phòng HN";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_KetThuc
            // 
            this.btn_KetThuc.Location = new System.Drawing.Point(552, 165);
            this.btn_KetThuc.Name = "btn_KetThuc";
            this.btn_KetThuc.Size = new System.Drawing.Size(80, 23);
            this.btn_KetThuc.TabIndex = 12;
            this.btn_KetThuc.Text = "Kết Thúc";
            this.btn_KetThuc.UseVisualStyleBackColor = true;
            this.btn_KetThuc.Click += new System.EventHandler(this.btn_KetThuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(10, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 205);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng hội nghị";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(55, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Họ tên sv: ......................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(187, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "masv:......................";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(380, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Lọc danh sách theo loại phòng hội nghị";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 445);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_KetThuc);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.button_LuuThemMoi);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.comboBox_loaiphong);
            this.Controls.Add(this.txt_SoNguoiThamGia);
            this.Controls.Add(this.txt_tenHN);
            this.Controls.Add(this.txt_maHN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maHN;
        private System.Windows.Forms.TextBox txt_tenHN;
        private System.Windows.Forms.TextBox txt_SoNguoiThamGia;
        private System.Windows.Forms.ComboBox comboBox_loaiphong;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.Button button_LuuThemMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_KetThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

