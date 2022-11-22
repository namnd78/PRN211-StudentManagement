namespace Project
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDepartmentStudent = new System.Windows.Forms.Button();
            this.btnStudentMark = new System.Windows.Forms.Button();
            this.btnInputMark = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDepartmentStudent);
            this.panel1.Controls.Add(this.btnStudentMark);
            this.panel1.Controls.Add(this.btnInputMark);
            this.panel1.Controls.Add(this.btnSubject);
            this.panel1.Controls.Add(this.btnDepartment);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 950);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnExit.Image = global::Project.Properties.Resources.power_button;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 865);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(300, 85);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "  Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnDepartmentStudent
            // 
            this.btnDepartmentStudent.BackColor = System.Drawing.Color.White;
            this.btnDepartmentStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartmentStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartmentStudent.FlatAppearance.BorderSize = 0;
            this.btnDepartmentStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDepartmentStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDepartmentStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepartmentStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDepartmentStudent.Image = global::Project.Properties.Resources.bar_chart;
            this.btnDepartmentStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmentStudent.Location = new System.Drawing.Point(0, 631);
            this.btnDepartmentStudent.Name = "btnDepartmentStudent";
            this.btnDepartmentStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDepartmentStudent.Size = new System.Drawing.Size(300, 85);
            this.btnDepartmentStudent.TabIndex = 6;
            this.btnDepartmentStudent.Text = "  Thống kê";
            this.btnDepartmentStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartmentStudent.UseVisualStyleBackColor = false;
            this.btnDepartmentStudent.Click += new System.EventHandler(this.btnDepartmentStudent_Click);
            this.btnDepartmentStudent.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnDepartmentStudent.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnStudentMark
            // 
            this.btnStudentMark.BackColor = System.Drawing.Color.White;
            this.btnStudentMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentMark.FlatAppearance.BorderSize = 0;
            this.btnStudentMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnStudentMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnStudentMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudentMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnStudentMark.Image = global::Project.Properties.Resources.research;
            this.btnStudentMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentMark.Location = new System.Drawing.Point(0, 546);
            this.btnStudentMark.Name = "btnStudentMark";
            this.btnStudentMark.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStudentMark.Size = new System.Drawing.Size(300, 85);
            this.btnStudentMark.TabIndex = 5;
            this.btnStudentMark.Text = "  Tra cứu điểm";
            this.btnStudentMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentMark.UseVisualStyleBackColor = false;
            this.btnStudentMark.Click += new System.EventHandler(this.btnStudentMark_Click);
            this.btnStudentMark.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnStudentMark.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnInputMark
            // 
            this.btnInputMark.BackColor = System.Drawing.Color.White;
            this.btnInputMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInputMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInputMark.FlatAppearance.BorderSize = 0;
            this.btnInputMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnInputMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnInputMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputMark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInputMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnInputMark.Image = global::Project.Properties.Resources.file;
            this.btnInputMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInputMark.Location = new System.Drawing.Point(0, 461);
            this.btnInputMark.Name = "btnInputMark";
            this.btnInputMark.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnInputMark.Size = new System.Drawing.Size(300, 85);
            this.btnInputMark.TabIndex = 4;
            this.btnInputMark.Text = "  Nhập điểm";
            this.btnInputMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInputMark.UseVisualStyleBackColor = false;
            this.btnInputMark.Click += new System.EventHandler(this.btnInputMark_Click);
            this.btnInputMark.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnInputMark.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.White;
            this.btnSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubject.FlatAppearance.BorderSize = 0;
            this.btnSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnSubject.Image = global::Project.Properties.Resources.book2;
            this.btnSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubject.Location = new System.Drawing.Point(0, 376);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubject.Size = new System.Drawing.Size(300, 85);
            this.btnSubject.TabIndex = 3;
            this.btnSubject.Text = "  Môn học";
            this.btnSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubject.UseVisualStyleBackColor = false;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            this.btnSubject.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnSubject.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.White;
            this.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDepartment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDepartment.Image = global::Project.Properties.Resources.microscope;
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.Location = new System.Drawing.Point(0, 291);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDepartment.Size = new System.Drawing.Size(300, 85);
            this.btnDepartment.TabIndex = 2;
            this.btnDepartment.Text = "  Khoa";
            this.btnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            this.btnDepartment.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnDepartment.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.White;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnStudent.Image = global::Project.Properties.Resources.student;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 206);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(300, 85);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "  Sinh Viên";
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            this.btnStudent.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnStudent.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 206);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.fpt_png1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(245, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Project.Properties.Resources.background5;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(300, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 950);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Project.Properties.Resources.background5;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1882, 3);
            this.panel6.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT MANAGEMENT";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.BackgroundImage = global::Project.Properties.Resources.uni1;
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelBody.ForeColor = System.Drawing.Color.Black;
            this.panelBody.Location = new System.Drawing.Point(305, 3);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1577, 950);
            this.panelBody.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT MANAGEMENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnDepartmentStudent;
        private Button btnStudentMark;
        private Button btnInputMark;
        private Button btnSubject;
        private Button btnDepartment;
        private Button btnStudent;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel6;
        private Label label1;
        private Panel panelBody;
    }
}