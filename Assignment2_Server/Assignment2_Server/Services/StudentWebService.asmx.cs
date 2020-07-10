using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Assignment2_Server.Models;

namespace Assignment2_Server.Services
{
    /// <summary>
    /// Summary description for StudentWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<CStudent> GetAllStudents()
        {
            Assignment2Entities db = new Assignment2Entities();
            List<Student> students = db.Students.ToList();

            List<CStudent> classStudents = new List<CStudent>();

            db.Dispose();

            foreach (Student s in students)
            {
                classStudents.Add(ConvertToCStudent(s));
            }

            return classStudents;
        }

        [WebMethod]
        public Boolean AddStudent(CStudent classStudent)
        {
            Assignment2Entities db = new Assignment2Entities();

            Student student = new Student();

            student = ConvertToStudent(classStudent);

            db.Students.Add(student);
            db.SaveChanges();
            db.Dispose();

            return true;
        }

        [WebMethod]
        public Boolean SaveStudent(CStudent classStudent)
        {
            Assignment2Entities db = new Assignment2Entities();

            Student student = db.Students.Where(x => x.StudentId == classStudent.StudentId).FirstOrDefault();

            Student studentTemp = ConvertToStudent(classStudent);

            db.Entry(student).CurrentValues.SetValues(studentTemp);

            db.SaveChanges();
            db.Dispose();

            return true;
        }

        [WebMethod]
        public List<CStudent> SearchStudents(String studentName)
        {
            Assignment2Entities db = new Assignment2Entities();

            List<Student> students = (from m in db.Students
                                      where m.StudentName.Contains(studentName)
                                      select m).ToList();

            List<CStudent> classStudents = new List<CStudent>();

            db.Dispose();

            foreach (Student s in students)
            {
                classStudents.Add(ConvertToCStudent(s));
            }

            return classStudents;
        }

        [WebMethod]
        public CStudent GetStudent(int studentId)
        {
            Assignment2Entities db = new Assignment2Entities();

            Student student = db.Students.Where(x => x.StudentId == studentId).FirstOrDefault();

            List<Enroll> enrollments = student.Enrolls.ToList();

            List<CCourse> cCourses = new List<CCourse>();

            CourseWebService courseWebService = new CourseWebService();
            foreach (Enroll e in enrollments)
            {
                cCourses.Add(courseWebService.ConvertToCCourse(e.Course));
            }

            CStudent classStudent = new CStudent();

            db.Dispose();

            classStudent = ConvertToCStudent(student);
            classStudent.Courses = cCourses;

            return classStudent;
        }

        [WebMethod]
        public Boolean DeleteStudent(int studentId)
        {
            Assignment2Entities db = new Assignment2Entities();

            Student student = db.Students.Where(x => x.StudentId == studentId).FirstOrDefault();
            List<Enroll> enrollments = student.Enrolls.ToList();

            db.Enrolls.RemoveRange(enrollments);
            db.Students.Remove(student);

            db.SaveChanges();
            db.Dispose();

            return true;
        }

        public Student ConvertToStudent(CStudent classStudent)
        {
            Student student = new Student();

            student.StudentId = classStudent.StudentId;
            student.StudentCode = classStudent.StudentCode;
            student.StudentName = classStudent.StudentName;
            student.ContactNumber = classStudent.ContactNumber;
            student.Address = classStudent.Address;
            student.Nic = classStudent.NIC;
            student.Email = classStudent.Email;

            student.ContactPerson = classStudent.ContactPerson;

            return student;
        }

        public CStudent ConvertToCStudent(Student student)
        {
            CStudent classStudent = new CStudent();

            classStudent.StudentId = student.StudentId;
            classStudent.StudentCode = student.StudentCode;
            classStudent.StudentName = student.StudentName;
            classStudent.ContactNumber = student.ContactNumber;
            classStudent.Address = student.Address;
            classStudent.NIC = student.Nic;
            classStudent.Email = student.Email;
            
            classStudent.ContactPerson = student.ContactPerson;

            return classStudent;
        }

       
    }
}
