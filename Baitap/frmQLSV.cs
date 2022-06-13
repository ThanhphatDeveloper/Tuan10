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
namespace Baitap
{
    public partial class frmQLSV : Form
    {
        string connect = @"Data Source=NGUYEN-THANH-PH\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True";
        SqlDataAdapter daQLSinhVien = new SqlDataAdapter();
        DataSet dsSinhVien = new DataSet();
        DataView dvSinhVien;
        public frmQLSV()
        {
            InitializeComponent();
        }
        private void frmQLSV_Load(object sender, EventArgs e)
        {
            //Không phát sinh thêm cột
            dgvDSSV.AutoGenerateColumns = false;
            //Đổ dữ liệu vào cboLop
            daQLSinhVien = new SqlDataAdapter("SELECT * FROM LOP", connect);
            daQLSinhVien.Fill(dsSinhVien, "tblLop");
            cboLop.DataSource = dsSinhVien.Tables["tblLop"].Copy();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            //Đổ dữ liệu tất cả sinh viên vào bảng tblSinhVien
            daQLSinhVien = new SqlDataAdapter("SELECT * FROM SINHVIEN WHERE TRANGTHAI = 1", connect);
            daQLSinhVien.Fill(dsSinhVien, "tblSinhVien");

            //Đổ dữ liệu lớp vào colLopHoc
            colLopHoc.DataSource = dsSinhVien.Tables["tblLop"].Copy();
            colLopHoc.DisplayMember = "TenLop";
            colLopHoc.ValueMember = "MaLop";

            SqlCommand insertCommand = new SqlCommand("INSERT INTO SINHVIEN (MSSV,HO,TEN,MALOP,NGAYSINH,DIACHI,TRANGTHAI) VALUES(@MSSV,@HO,@TEN,@MALOP,@NGAYSINH,@DIACHI,1)");
            insertCommand.Parameters.Add("@MSSV", SqlDbType.NVarChar, 10, "MSSV");
            insertCommand.Parameters.Add("@HO", SqlDbType.NVarChar, 50, "Ho");
            insertCommand.Parameters.Add("@TEN", SqlDbType.NVarChar, 50, "Ten");
            insertCommand.Parameters.Add("@MALOP", SqlDbType.VarChar, 10, "MaLop");
            insertCommand.Parameters.Add("@NGAYSINH", SqlDbType.Date, 10, "NgaySinh");
            insertCommand.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 9999, "DiaChi");

            daQLSinhVien.InsertCommand = insertCommand;

            SqlCommand deleteCommand = new SqlCommand ("UPDATE SINHVIEN SET TRANGTHAI = 0 WHERE ID = @ID");
            insertCommand.Parameters.Add("@ID", SqlDbType.Int, 10, "ID");
            daQLSinhVien.DeleteCommand = deleteCommand;

            SqlCommandBuilder scb = new SqlCommandBuilder(daQLSinhVien); // cho phép cập nhật dữ liệu 
            dvSinhVien = dsSinhVien.Tables["tblSinhVien"].DefaultView;
            dgvDSSV.DataSource = dvSinhVien;
        }

        private void btnTimHoTen_Click(object sender, EventArgs e)
        {
            dsSinhVien.Tables["tblSinhVien"].Reset();
            dsSinhVien.Tables["tblLop"].Reset();
            if (radHoTen.Checked)
            {
                //Đổ dữ liệu sinh viên vào dgvDSSV theo truy vấn họ tên
                daQLSinhVien = new SqlDataAdapter(string.Format("SELECT * FROM SINHVIEN WHERE TRANGTHAI = 1 AND HO = N'{0}' OR TEN = N'{1}' ", txtHoTen.Text, txtHoTen.Text), connect);
                daQLSinhVien.Fill(dsSinhVien, "tblSinhVien");
                dgvDSSV.DataSource = dsSinhVien.Tables["tblSinhVien"].Copy();
                //Đổ dữ liệu lớp vào colLopHoc
                daQLSinhVien = new SqlDataAdapter("SELECT * FROM LOP", connect);
                daQLSinhVien.Fill(dsSinhVien, "tblLop");
                colLopHoc.DataSource = dsSinhVien.Tables["tblLop"].Copy();
                colLopHoc.DisplayMember = "TenLop";
                colLopHoc.ValueMember = "MaLop";
            }
            return;
        }

        private void radHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (!radHoTen.Checked)
                txtHoTen.Text = string.Empty;
        }

        private void btnTimMSSV_Click(object sender, EventArgs e)
        {
            dsSinhVien.Tables["tblSinhVien"].Reset();
            dsSinhVien.Tables["tblLop"].Reset();
            if (radMSSV.Checked)
            {
                //Đổ dữ liệu sinh viên vào dgvDSSV theo truy vấn MSSV
                daQLSinhVien = new SqlDataAdapter(string.Format("SELECT * FROM SINHVIEN WHERE TRANGTHAI = 1 AND MSSV = {0} ", txtMSSV.Text), connect);
                daQLSinhVien.Fill(dsSinhVien, "tblSinhVien");
                dgvDSSV.DataSource = dsSinhVien.Tables["tblSinhVien"].Copy();
                //Đổ dữ liệu lớp vào colLopHoc
                daQLSinhVien = new SqlDataAdapter("SELECT * FROM LOP", connect);
                daQLSinhVien.Fill(dsSinhVien, "tblLop");
                colLopHoc.DataSource = dsSinhVien.Tables["tblLop"].Copy();
                colLopHoc.DisplayMember = "TenLop";
                colLopHoc.ValueMember = "MaLop";
            }
            return;

        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            dsSinhVien.Tables["tblSinhVien"].Reset();
            dsSinhVien.Tables["tblLop"].Reset();
            if (radTatCa.Checked)
            {
                //Đổ dữ liệu tất cả sinh viên vào dgvDSSV
                daQLSinhVien = new SqlDataAdapter("SELECT * FROM SINHVIEN WHERE TRANGTHAI = 1", connect);
                daQLSinhVien.Fill(dsSinhVien, "tblSinhVien");
                dgvDSSV.DataSource = dsSinhVien.Tables["tblSinhVien"].Copy();
                //Đổ dữ liệu lớp vào colLopHoc
                daQLSinhVien = new SqlDataAdapter("SELECT * FROM LOP", connect);
                daQLSinhVien.Fill(dsSinhVien, "tblLop");
                colLopHoc.DataSource = dsSinhVien.Tables["tblLop"].Copy();
                colLopHoc.DisplayMember = "TenLop";
                colLopHoc.ValueMember = "MaLop";
            }
        }

        private void radMSSV_CheckedChanged(object sender, EventArgs e)
        {
            if (!radMSSV.Checked)
                txtMSSV.Text = string.Empty;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (radLop.Checked)
            {
                dsSinhVien.Tables["tblSinhVien"].Reset();
                dsSinhVien.Tables["tblLop"].Reset();
                //Đổ dữ liệu tất cả sinh viên vào dgvDSSV              
                daQLSinhVien = new SqlDataAdapter(string.Format("SELECT * FROM SINHVIEN WHERE TRANGTHAI = 1 AND MALOP = {0}",cboLop.SelectedValue), connect);
                daQLSinhVien.Fill(dsSinhVien, "tblSinhVien");
                dgvDSSV.DataSource = dsSinhVien.Tables["tblSinhVien"].Copy();
                //Đổ dữ liệu lớp vào colLopHoc
                daQLSinhVien = new SqlDataAdapter("SELECT * FROM LOP", connect);
                daQLSinhVien.Fill(dsSinhVien, "tblLop");
                colLopHoc.DataSource = dsSinhVien.Tables["tblLop"].Copy();
                colLopHoc.DisplayMember = "TenLop";
                colLopHoc.ValueMember = "MaLop";
            }
            return;
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            daQLSinhVien.Update(dsSinhVien, "tblSinhVien");

            dsSinhVien.Tables["tblSinhVien"].Rows.Clear();
            daQLSinhVien.Fill(dsSinhVien, "tblSinhVien");
            dvSinhVien = dsSinhVien.Tables["tblSinhVien"].DefaultView;
            dgvDSSV.DataSource = dvSinhVien;
        }
    }
}
