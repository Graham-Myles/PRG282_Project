using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.BusinessLogicLayer;
using PRG282_Project.DataAccesLayer;

namespace PRG282_Project
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHandler DH = new DatabaseHandler();
            dataGridView1.DataSource = DH.displaystudent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtStudentNum.Text = row.Cells["StudentID"].Value.ToString();
                txtName.Text = row.Cells["StudentName"].Value.ToString();
                txtSurname.Text = row.Cells["StudentSurname"].Value.ToString();
                
                txtDOB.Text = row.Cells["DOB"].Value.ToString();
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["Adress"].Value.ToString();
                txtCourse.Text = row.Cells["ModuleCode"].Value.ToString();


            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Student_Form studentfrm = new Student_Form();
            Login_Form loginfrm = new Login_Form();

            loginfrm.Show();
            studentfrm.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSearch.Text);
            DatabaseHandler DH = new DatabaseHandler();
            dataGridView1.DataSource = DH.SearchStudent(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DatabaseHandler DH = new DatabaseHandler();
            int id = Convert.ToInt32(txtStudentNum.Text);
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string Phonenumber = txtPhone.Text; 
            int ModuleCode = Convert.ToInt32(txtCourse.Text);
            string dob = txtDOB.Text;
            string Addres = txtAddress.Text;
            string Gender = txtGender.Text;
            string Pic = txtImage.Text;
            DH.UpdateStudent(id, name, surname, Phonenumber, ModuleCode, dob, Addres, Gender, Pic);
            DH.displaystudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DatabaseHandler DH = new DatabaseHandler();
            int id = Convert.ToInt32(txtStudentNum.Text);
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string Phonenumber = txtPhone.Text;
            int ModuleCode = Convert.ToInt32(txtCourse.Text);
            string dob = txtDOB.Text;
            string Addres = txtAddress.Text;
            string Gender = txtGender.Text;
            string Pic = txtImage.Text;
            DH.InsertStudent(id, name, surname, Phonenumber, ModuleCode, dob, Addres, Gender, Pic);
            DH.displaystudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DatabaseHandler DH = new DatabaseHandler();
            int id = Convert.ToInt32(txtSearch.Text);
            DH.DeleteStudent(id);
            DH.displaystudent();
        }

        private void btnToModule_Click(object sender, EventArgs e)
        {
            Student_Form studentfrm = new Student_Form();
            Module_Form modulefrm = new Module_Form();

            modulefrm.Show();
            studentfrm.Close();
        }
    }
}
