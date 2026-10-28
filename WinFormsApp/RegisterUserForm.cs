
using ConsoleApp1.DataLayer.Models;
using ConsoleApp1.DataLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class RegisterUserForm : Form
    {
        List<Student> students = new List<Student>();

        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            string name = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string mobile = mobileTextBox.Text.Trim();
            string nationalCode = nationalCodeTextBox.Text.Trim();

            if (name == "" || lastName == "" ||
                mobile == "" || nationalCode == "")
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید.");
                return;
            }

            if (mobile.Length != 11 ||
                !mobile.All(char.IsDigit))
            {
                MessageBox.Show(
                    "لطفاً شماره موبایل را به صورت 11 رقم وارد کنید."
                );
                return;
            }

            Student st = new Student(
                name,
                lastName,
                mobile,
                nationalCode
            );

            students.Add(st);

            userDataGridView.DataSource = null;
            userDataGridView.DataSource = students;

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            mobileTextBox.Clear();
            nationalCodeTextBox.Clear();

            MessageBox.Show("دانشجو با موفقیت ثبت شد.");
        }

        private void showByMockButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Files",
                "MockData",
                "students.json"
            );

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                List<Student>? mockStudents =
                    JsonConvert.DeserializeObject<List<Student>>(json);

                if (mockStudents == null)
                {
                    MessageBox.Show("اطلاعات فایل JSON معتبر نیست.");
                    return;
                }

                userDataGridView.DataSource = null;
                userDataGridView.DataSource = mockStudents;
            }
            else
            {
                MessageBox.Show("فایل داده‌های آزمایشی پیدا نشد.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

