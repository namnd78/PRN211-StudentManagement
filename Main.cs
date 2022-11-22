namespace Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Student());
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Department());
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Subject());
        }

        private void btnInputMark_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InputMark());
        }

        private void btnStudentMark_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentMark());
        }

        private void btnDepartmentStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statistic());
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        Form currentChildForm;
        private void OpenChildForm(Form form)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm?.Close();
        }
    }
}