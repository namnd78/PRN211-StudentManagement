namespace Project
{
    partial class Department
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDoEdit = new System.Windows.Forms.Button();
            this.btnDoAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDepartment = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDelete.Image = global::Project.Properties.Resources.paint_roller;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(894, 235);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(200, 60);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "   Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnEdit.Image = global::Project.Properties.Resources.writing;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(894, 146);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(200, 60);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "   Chỉnh sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnAdd.Image = global::Project.Properties.Resources.microscope;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(894, 57);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(200, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "   Thêm mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDoEdit
            // 
            this.btnDoEdit.BackColor = System.Drawing.Color.White;
            this.btnDoEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoEdit.Image = global::Project.Properties.Resources.reload_sm;
            this.btnDoEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoEdit.Location = new System.Drawing.Point(416, 190);
            this.btnDoEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoEdit.Name = "btnDoEdit";
            this.btnDoEdit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoEdit.Size = new System.Drawing.Size(143, 49);
            this.btnDoEdit.TabIndex = 21;
            this.btnDoEdit.Text = "  Cập nhật";
            this.btnDoEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoEdit.UseVisualStyleBackColor = false;
            this.btnDoEdit.Click += new System.EventHandler(this.btnDoEdit_Click);
            // 
            // btnDoAdd
            // 
            this.btnDoAdd.BackColor = System.Drawing.Color.White;
            this.btnDoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoAdd.Image = global::Project.Properties.Resources.plus_sm;
            this.btnDoAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoAdd.Location = new System.Drawing.Point(416, 190);
            this.btnDoAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoAdd.Name = "btnDoAdd";
            this.btnDoAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoAdd.Size = new System.Drawing.Size(143, 49);
            this.btnDoAdd.TabIndex = 20;
            this.btnDoAdd.Text = " Thêm mới";
            this.btnDoAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoAdd.UseVisualStyleBackColor = false;
            this.btnDoAdd.Click += new System.EventHandler(this.btnDoAdd_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(226, 131);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 29);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEPARTMENT INFORMATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(90, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã khoa";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtCode.Location = new System.Drawing.Point(226, 74);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(174, 29);
            this.txtCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(175, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "DEPARTMENT LIST";
            // 
            // dgDepartment
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgDepartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepartment.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartment.Location = new System.Drawing.Point(175, 469);
            this.dgDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.RowHeadersWidth = 51;
            this.dgDepartment.RowTemplate.Height = 25;
            this.dgDepartment.Size = new System.Drawing.Size(990, 435);
            this.dgDepartment.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoDelete);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnDoEdit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDoAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.groupBox1.Location = new System.Drawing.Point(175, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(590, 262);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnDoDelete
            // 
            this.btnDoDelete.BackColor = System.Drawing.Color.White;
            this.btnDoDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnDoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnDoDelete.Image = global::Project.Properties.Resources.eraser;
            this.btnDoDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoDelete.Location = new System.Drawing.Point(446, 190);
            this.btnDoDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoDelete.Name = "btnDoDelete";
            this.btnDoDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDoDelete.Size = new System.Drawing.Size(113, 49);
            this.btnDoDelete.TabIndex = 27;
            this.btnDoDelete.Text = "   Xóa";
            this.btnDoDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoDelete.UseVisualStyleBackColor = false;
            this.btnDoDelete.Click += new System.EventHandler(this.btnDoDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(90, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên khoa";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnExportExcel);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dgDepartment);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1582, 953);
            this.panel4.TabIndex = 5;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnExportExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnExportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(174)))), ((int)(((byte)(254)))));
            this.btnExportExcel.Image = global::Project.Properties.Resources.excel;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(1023, 402);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportExcel.Size = new System.Drawing.Size(142, 40);
            this.btnExportExcel.TabIndex = 28;
            this.btnExportExcel.Text = " Xuất Excel";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(175, 412);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = " Tìm mã khoa, tên khoa";
            this.txtSearch.Size = new System.Drawing.Size(256, 30);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDoEdit;
        private Button btnDoAdd;
        private TextBox txtName;
        private Label label1;
        private Label label3;
        private TextBox txtCode;
        private Label label2;
        private DataGridView dgDepartment;
        private GroupBox groupBox1;
        private Label label4;
        private Panel panel4;
        private Button btnDoDelete;
        private TextBox txtSearch;
        private Button btnExportExcel;
    }
}