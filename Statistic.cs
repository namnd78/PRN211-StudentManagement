using Microsoft.Office.Interop.Excel;
using Project.Models;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        MyTestContext context = new MyTestContext();

        private void Statistic_Load(object sender, EventArgs e)
        {
            int male = context.SinhViens.Where(item => item.GioiTinh == true).ToList().Count;
            int female = context.SinhViens.Where(item => item.GioiTinh == false).ToList().Count;
            double[] genderValue = { male, female };
            string[] genderName = { "Nam", "Nữ" };
            var gender = pie1.Plot.AddPie(genderValue);
            gender.SliceLabels = genderName;
            gender.ShowPercentages = true;
            gender.ShowValues = true;
            //pie.ShowLabels = true;
            pie1.Plot.Legend();
            pie1.Refresh();

            var department = context.Khoas.ToArray();
            string[] departmentName = new string[department.Length];
            double[] departmentStudent = new double[department.Length];
            for (int i = 0; i < department.Length; i++)
            {
                departmentName[i] = department[i].TenKhoa;
                var student = context.SinhViens.Where(item => item.MaKhoa == department[i].MaKhoa).ToList();
                departmentStudent[i] = student.Count;
            }
            double[] countValue = departmentStudent;
            string[] countName = departmentName;
            var countStudent = pie2.Plot.AddPie(countValue);
            countStudent.SliceLabels = countName;
            countStudent.ShowPercentages = true;
            countStudent.ShowValues = true;
            pie2.Plot.Legend();
            pie2.Refresh();

            // do truot
            int pass = context.SinhViens.Where(item => item.Gpa >= 5).ToList().Count;
            int notpass = context.SinhViens.Where(item => item.Gpa < 5).ToList().Count;
            double[] passValue = { pass, notpass };
            string[] passName = { "Pass", "Not Pass" };
            var gpa = pie3.Plot.AddPie(passValue);
            gpa.SliceLabels = passName;
            gpa.ShowPercentages = true;
            gpa.ShowValues = true;
            pie3.Plot.Legend();
            pie3.Refresh();

            // chuyen nganh
            int change = context.SinhViens.Where(item => item.ChuyenNganh == true).ToList().Count;
            int notchange = context.SinhViens.Where(item => item.ChuyenNganh == false).ToList().Count;
            double[] changeValue = { change, notchange };
            var changeDepart = pie4.Plot.AddPie(changeValue);
            changeDepart.ShowValues = true;
            changeDepart.DonutSize = .6;
            changeDepart.DonutLabel = $"{changeValue[0] / changeValue.Sum() * 100:00.0}%"; ;
            pie4.Plot.Legend();
            pie4.Refresh();

            //thoi hoc

            txtQuit.Text = context.SvthoiHocs.Find(1).SoLuong.ToString();
        }

        private void pepco1_Click(object sender, EventArgs e)
        {
        }
    }
}
