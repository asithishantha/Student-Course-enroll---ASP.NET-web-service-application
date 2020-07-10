using Assignment2__client.CourseServiceReference;
using Assignment2__client.EnrollServiceReference;
using Assignment2__client.StudentServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Input;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCourse = Assignment2__client.CourseServiceReference.CCourse;
using CStudent = Assignment2__client.StudentServiceReference.CStudent;

namespace Assignment2__client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void gridupdatestudent_Click(object sender, EventArgs e)
        {
            LoadAllStudents();
        }

        private void studentadd_Click(object sender, EventArgs e)
        {
            CStudent cStudent = new CStudent();

            cStudent.StudentCode = textstudentcode.Text;
            cStudent.StudentName = textstudentname.Text;
            cStudent.ContactNumber = textstudentcontact.Text;
            cStudent.Address = textstudentaddress.Text;
            cStudent.NIC = textstudentnic.Text;

            cStudent.Email = textstudentemail.Text;
            cStudent.ContactPerson = textstudentcontactperson.Text;

            StudentWebServiceSoapClient client = new StudentWebServiceSoapClient();
            client.AddStudent(cStudent);

            LoadAllStudents();
        }

        private void studentedit_Click(object sender, EventArgs e)
        {
            CStudent cStudent = new CStudent();

            cStudent.StudentId = Int32.Parse(lblid.Text);

            cStudent.StudentCode = textstudentcode.Text;
            cStudent.StudentName = textstudentname.Text;
            cStudent.ContactNumber = textstudentcontact.Text;
            cStudent.Address = textstudentaddress.Text;
            cStudent.NIC = textstudentnic.Text;

            cStudent.Email = textstudentemail.Text;
            cStudent.ContactPerson = textstudentcontactperson.Text;

            StudentWebServiceSoapClient client = new StudentWebServiceSoapClient();
            client.SaveStudent(cStudent);

            LoadAllStudents();
        }

        private void studentdelete_Click(object sender, EventArgs e)
        {
            if (lblid.Text == null || lblid.Text.ToString() == "")
            {
                return;
            }

            int studentId = Int32.Parse(lblid.Text.ToString());

            StudentWebServiceSoapClient client = new StudentWebServiceSoapClient();
            client.DeleteStudent(studentId);

            dgvstudent.DataSource = null;
            ClearFieldsStudent();
            LoadAllStudents();
        }
        private void ClearFieldsStudent()
        {
            lblid.Text = " ";

            textstudentcode.Text = "";
            textstudentname.Text = "";
            textstudentcontact.Text = "";
            textstudentaddress.Text = "";
            textstudentnic.Text = "";
            textstudentemail.Text = "";
            
            textstudentcontactperson.Text = "";

        }

        private void LoadAllStudents()
        {
            StudentWebServiceSoapClient client = new StudentWebServiceSoapClient();
            List<CStudent> students = client.GetAllStudents().ToList();
            dgvstudent.DataSource = students;
            dgvstudent1.DataSource = students;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllStudents();
            LoadAllCourses();
        }
        private void LoadAllCourses()
        {
            CourseWebServiceSoapClient client = new CourseWebServiceSoapClient();
            List<CCourse> courses = client.GetAllCourses().ToList();
            dgvcourse.DataSource = courses;
            dgvcourse1.DataSource = courses;
        }

    





        private void dgvstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvstudent.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lblid.Text = row.Cells[0].Value.ToString();
                textstudentcode.Text = row.Cells[1].Value.ToString();
                textstudentname.Text = row.Cells[2].Value.ToString();
                textstudentcontact.Text = row.Cells[3].Value.ToString();
                textstudentaddress.Text = row.Cells[4].Value.ToString();
                textstudentnic.Text = row.Cells[5].Value.ToString();
                textstudentemail.Text = row.Cells[6].Value.ToString();
                textstudentcontactperson.Text = row.Cells[7].Value.ToString();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void courseaddbtn_Click(object sender, EventArgs e)
        {
            CCourse classCourse = new CCourse();

            classCourse.CourseId = Int32.Parse(courselblid.Text);

            classCourse.CourseCode = textcoursecode.Text;
            classCourse.CourseName =textcoursename.Text;
            classCourse.CourseCredits = Int32.Parse(textcoursecredits.Text);
            classCourse.SemesterNumber = Int32.Parse(textsemesternumber.Text);
         

            CourseWebServiceSoapClient client = new CourseWebServiceSoapClient();
            client.AddCourse(classCourse);

            LoadAllStudents();
        }

        private void courseeditbtn_Click(object sender, EventArgs e)
        {
            CCourse classCourse = new CCourse();

            classCourse.CourseCode = textcoursecode.Text;
            classCourse.CourseName = textcoursename.Text;
            classCourse.CourseCredits = Int32.Parse(textcoursecredits.Text);
            classCourse.SemesterNumber = Int32.Parse(textsemesternumber.Text);


            CourseWebServiceSoapClient client = new CourseWebServiceSoapClient();
            client.SaveCourse(classCourse);

            LoadAllCourses();

        }

        private void coursedeletebtn_Click(object sender, EventArgs e)
        {
            if (courselblid.Text == null || courselblid.Text.ToString() == "")
            {
                return;
            }

            int courseId = Int32.Parse(courselblid.Text.ToString());

            StudentWebServiceSoapClient client = new StudentWebServiceSoapClient();
            client.DeleteStudent(courseId);

            dgvcourse.DataSource = null;
            ClearFieldsStudent();
            LoadAllStudents();
        }

        private void dgvcourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvcourse.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                courselblid.Text = row.Cells[0].Value.ToString();
                textcoursecode.Text = row.Cells[1].Value.ToString();
                textcoursename.Text = row.Cells[2].Value.ToString();
                textcoursecredits.Text = row.Cells[3].Value.ToString();
               textsemesternumber.Text= row.Cells[4].Value.ToString();
            }
        }

        private void dgvcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvstudent1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvstudent1_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvstudent1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textenrollid.Text = row.Cells[0].Value.ToString();
                
                textenrollstudentname.Text = row.Cells[2].Value.ToString();
                
            }
        }

        private void dgvcourse1_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvcourse1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textenrollcourseid.Text = row.Cells[0].Value.ToString();

                textenrollcoursename.Text = row.Cells[2].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textenrollid.Text == null || textenrollid.Text == "")
            {
                return;
            }

            if (textenrollcourseid.Text == null || textenrollcourseid.Text == "")
            {
                return;
            }

            EnrollWebServiceSoapClient client = new EnrollWebServiceSoapClient();

            int studentId = Int32.Parse(textenrollid.Text);
            int courseId = Int32.Parse(textenrollcourseid.Text);

            Boolean result = client.Enroll(studentId, courseId);

            if (result)
            {
                MessageBox.Show("Enrollment Successful");
            }
            else
            {
                MessageBox.Show("Enrollment Unsuccessful. Maybe enrollment already exists.");
            }
        }

        private void textstudentcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textstudentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
