using De01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.GenerateAndBindData();
            this.LoadLopIntoComboBox();
            this.dgvStudent.CellContentClick += new DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;

            // Thiết lập màu sắc cho nút
            ChangeButtonColor(btnSave, false);
            ChangeButtonColor(btnUpdate, false);
            ChangeButtonColor(btnDel, false);

        }

        private void GenerateAndBindData()
        {
            using (var context = new MyDBContext())
            {
                var students = context.Sinhviens.Include("Lop").ToList();
                dgvStudent.Rows.Clear();

                foreach (var student in students)
                {
                    dgvStudent.Rows.Add(student.MaSV, student.HotenSV, student.NgaySinh, student.Lop?.TenLop);
                }
            }
        }
        private void LoadLopIntoComboBox()
        {
            using (var context = new MyDBContext())
            {
           
                var listLop = context.Lops.ToList();

                cbClass.DataSource = listLop;
                cbClass.DisplayMember = "TenLop"; 
                cbClass.ValueMember = "MaLop";     
            }
        }
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấp vào hàng và cột hợp lệ
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                txtIDStudent.Text = row.Cells["dgvIDStudent"].Value.ToString();
                txtFullName.Text = row.Cells["dgvFullName"].Value.ToString();
                var dateValue = dgvStudent.Rows[e.RowIndex].Cells[2].Value;

                // Kiểm tra xem giá trị có phải là DateTime
                if (dateValue != null && DateTime.TryParse(dateValue.ToString(), out DateTime selectedDate))
                {
                    // Gán giá trị cho PKDateTime
                    PKDateTime.Value = selectedDate;
                }
                else
                {
                    // Nếu không phải là giá trị hợp lệ, có thể đặt ngày về giá trị mặc định
                    PKDateTime.Value = DateTime.Now; // Hoặc giá trị mặc định khác
                }
                string NameClass = row.Cells["dgvClass"].Value.ToString();
                using (var context = new MyDBContext())
                {
                    // Lấy thông tin lớp (Lop) và nạp danh sách sinh viên liên quan
                    var classEntity = context.Lops.FirstOrDefault(f => f.TenLop == NameClass); // So sánh với NameClass

                    if (classEntity != null)
                    {
                        cbClass.SelectedValue = classEntity.MaLop; // Đặt giá trị cho ComboBox
                    }
                }

            }
        }

        private void ValidateInputs()
        {
            bool isValid = !string.IsNullOrWhiteSpace(txtIDStudent.Text) &&
                           !string.IsNullOrWhiteSpace(txtFullName.Text) &&
                           cbClass.SelectedItem != null;

            btnSave.Enabled = isValid;
            btnUpdate.Enabled = isValid;
            btnDel.Enabled = isValid;
            btnAdd.Enabled = isValid;

            ChangeButtonColor(btnSave, isValid);
            ChangeButtonColor(btnUpdate, isValid);
            ChangeButtonColor(btnDel, isValid);
            ChangeButtonColor(btnAdd, isValid);
        }
        private void ChangeButtonColor(Button btn, bool isEnabled)
        {
            if (isEnabled)
            {
                btn.BackColor = SystemColors.Control; 
            }
            else
            {
                btn.BackColor = Color.Gray; 
            }
        }

        private void txtIDStudent_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentId = txtIDStudent.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                cbClass.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền tất cả các trường đúng cách.");
                return;
            }

            using (var context = new MyDBContext())
            {
                // Tìm sinh viên theo mã sinh viên
                var student = context.Sinhviens.Find(studentId);

                if (student == null)
                {
                   
                    student = new Sinhvien
                    {
                        MaSV = studentId,
                        HotenSV = txtFullName.Text,
                        NgaySinh = PKDateTime.Value,
                        Lop = context.Lops.Find(cbClass.SelectedValue) // Tìm lớp theo SelectedValue
                    };

                    // Thêm sinh viên mới vào cơ sở dữ liệu
                    context.Sinhviens.Add(student);
                    context.SaveChanges();
                    MessageBox.Show("Thêm sinh viên thành công.");
                    this.GenerateAndBindData();
                }
                else
                {
                   
                    MessageBox.Show("Sinh viên đã tồn tại!");
                }
            }
        }

    }
}
