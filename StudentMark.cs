using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace Project
{
    public partial class StudentMark : Form
    {
        public StudentMark()
        {
            InitializeComponent();
        }

        MyTestContext context = new MyTestContext();

        private void StudentMark_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var data = context.KetQuas.Select(item => new
                {
                    MaSo = item.MaSo,
                    MaMh = item.MaMh,
                    TenMh = item.Mon.TenMh,
                    Diem = item.Diem,
                }).ToList();
                dgMark.DataSource = data;
                dgMark.Columns["MaSo"].Visible = false;
                dgMark.Columns["MaMh"].HeaderText = "Mã môn";
                dgMark.Columns["TenMh"].HeaderText = "Tên môn học";
                dgMark.Columns["Diem"].HeaderText = "Điểm";

                var dataDepartment = context.Khoas.OrderBy(item => item.MaKhoa).ToList();
                dataDepartment.Insert(0, new Khoa { MaKhoa = "All", TenKhoa = " Tất cả khoa" });
                cboDepartment.DataSource = dataDepartment;
                cboDepartment.DisplayMember = "TenKhoa";
                cboDepartment.ValueMember = "MaKhoa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }
        private void cboDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            var dataStudentCode = context.SinhViens.Select(item => new
            {
                MaSo = item.MaSo,
                MaKhoa = item.MaKhoa
            });
            if (cboDepartment.SelectedIndex != 0)
            {
                dataStudentCode = dataStudentCode.Where(item => item.MaKhoa == cboDepartment.SelectedValue.ToString());
            }
            cboStudentCode.DataSource = dataStudentCode.OrderBy(item => item.MaSo).ToList();
            cboStudentCode.DisplayMember = "MaSo";
        }
        private void cboStudentCode_SelectedValueChanged(object sender, EventArgs e)
        {
            int studentCode = Convert.ToInt32(cboStudentCode.Text);
            SinhVien student = context.SinhViens.Find(studentCode);
            txtStudentName.Text = student.HoTen;
            var data = context.KetQuas.Select(item => new
            {
                MaSo = item.MaSo,
                MaMh = item.MaMh,
                TenMh = item.Mon.TenMh,
                Diem = item.Diem
            }).Where(item => item.MaSo == student.MaSo).ToList();
            dgMark.DataSource = data;
            txtAverage.Text = student.Gpa.ToString();
        }

        private double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < dgMark.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dgMark.Rows[i].Cells["Diem"].Value);
            }
            double average = sum / dgMark.Rows.Count;
            return average;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLSX (*.xlsx)|*.xlsx|XLS (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(saveFileDialog.FileName);
                LoadData();
            }
        }

        private void ToExcel(string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range range;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Bảng điểm";

                dgMark.Columns.RemoveAt(0);
                dgMark.Columns.RemoveAt(1);
                worksheet.Cells[1, 1] = "Bảng điểm sinh viên mã  " + cboStudentCode.Text + " - " + txtStudentName.Text;
                range = worksheet.Cells[1, 1];
                range.Font.Bold = true;
                range.Font.Size += 2;
                range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgMark.ColumnCount]];
                range.Merge();
                range = worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, dgMark.ColumnCount]];
                range.Font.Bold = true;
                range.Interior.Color = Color.PaleTurquoise;
                for (int i = 0; i < dgMark.ColumnCount; i++)
                {
                    worksheet.Cells[3, i + 1] = dgMark.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgMark.RowCount; i++)
                {
                    for (int j = 0; j < dgMark.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 4, j + 1] = dgMark.Rows[i].Cells[j].Value.ToString();
                    }
                }
                worksheet.Cells[dgMark.RowCount + 5, dgMark.ColumnCount - 1] = "Điểm trung bình";
                worksheet.Cells[dgMark.RowCount + 5, dgMark.ColumnCount] = CalculateAverage().ToString("#.##");
                range = worksheet.Rows[dgMark.RowCount + 5];
                range.Font.Bold = true;
                //excel.Columns.AutoFit();
                worksheet.Columns.AutoFit();
                excel.Visible = true;
                workbook.SaveAs(fileName);
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
