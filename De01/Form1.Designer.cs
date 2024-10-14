using System.Drawing;
using System.Windows.Forms;

namespace De01
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDSinhVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDStudent = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.PKDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDontSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgvIDStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin chi tiết";
            // 
            // IDSinhVien
            // 
            this.IDSinhVien.AutoSize = true;
            this.IDSinhVien.Location = new System.Drawing.Point(51, 90);
            this.IDSinhVien.Name = "IDSinhVien";
            this.IDSinhVien.Size = new System.Drawing.Size(67, 13);
            this.IDSinhVien.TabIndex = 1;
            this.IDSinhVien.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp học";
            // 
            // txtIDStudent
            // 
            this.txtIDStudent.Location = new System.Drawing.Point(130, 88);
            this.txtIDStudent.Name = "txtIDStudent";
            this.txtIDStudent.Size = new System.Drawing.Size(86, 20);
            this.txtIDStudent.TabIndex = 5;
            this.txtIDStudent.TextChanged += new System.EventHandler(this.txtIDStudent_TextChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(459, 88);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(86, 20);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // PKDateTime
            // 
            this.PKDateTime.Location = new System.Drawing.Point(130, 146);
            this.PKDateTime.Name = "PKDateTime";
            this.PKDateTime.Size = new System.Drawing.Size(172, 20);
            this.PKDateTime.TabIndex = 8;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(459, 146);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(104, 21);
            this.cbClass.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(171, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 20);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(240, 206);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(64, 20);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(309, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 20);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(379, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 20);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDontSave
            // 
            this.btnDontSave.Location = new System.Drawing.Point(448, 206);
            this.btnDontSave.Name = "btnDontSave";
            this.btnDontSave.Size = new System.Drawing.Size(64, 20);
            this.btnDontSave.TabIndex = 14;
            this.btnDontSave.Text = "Không lưu";
            this.btnDontSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(518, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 20);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 207);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(86, 20);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(101, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 20);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIDStudent,
            this.dgvFullName,
            this.dgvDate,
            this.dgvClass});
            this.dgvStudent.Location = new System.Drawing.Point(10, 242);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowTemplate.Height = 25;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(572, 130);
            this.dgvStudent.TabIndex = 18;
            // 
            // dgvIDStudent
            // 
            this.dgvIDStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvIDStudent.HeaderText = "Mã sinh viên";
            this.dgvIDStudent.Name = "dgvIDStudent";
            // 
            // dgvFullName
            // 
            this.dgvFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFullName.HeaderText = "Họ và Tên";
            this.dgvFullName.Name = "dgvFullName";
            // 
            // dgvDate
            // 
            this.dgvDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDate.HeaderText = "Ngày sinh";
            this.dgvDate.Name = "dgvDate";
            // 
            // dgvClass
            // 
            this.dgvClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvClass.HeaderText = "Lớp";
            this.dgvClass.Name = "dgvClass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 390);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDontSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.PKDateTime);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtIDStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDSinhVien);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Danh Sách Sinh Viên (NVP)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label IDSinhVien;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIDStudent;
        private TextBox txtFullName;
        private DateTimePicker PKDateTime;
        private ComboBox cbClass;
        private Button btnAdd;
        private Button btnDel;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnDontSave;
        private Button btnExit;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridViewTextBoxColumn dgvIDStudent;
        private DataGridViewTextBoxColumn dgvFullName;
        private DataGridViewTextBoxColumn dgvDate;
        private DataGridViewTextBoxColumn dgvClass;
        private DataGridView dgvStudent;
    }
}