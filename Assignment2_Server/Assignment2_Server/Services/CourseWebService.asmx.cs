using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Assignment2_Server.Models;

namespace Assignment2_Server.Services
{
    /// <summary>
    /// Summary description for CourseWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CourseWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<CCourse> GetAllCourses()
        {
            Assignment2Entities db = new Assignment2Entities();
            List<Course> courses = db.Courses.ToList();

            List<CCourse> cCourses = new List<CCourse>();

            db.Dispose();

            foreach (Course c in courses)
            {
                cCourses.Add(ConvertToCCourse(c));
            }

            return cCourses;
        }

        [WebMethod]
        public Boolean AddCourse(CCourse cCourse)
        {
            Assignment2Entities db = new Assignment2Entities();

            Course course = new Course();

            course = ConvertToCourse(cCourse);

            db.Courses.Add(course);
            db.SaveChanges();
            db.Dispose();

            return true;
        }

        [WebMethod]
        public Boolean SaveCourse(CCourse cCourse)
        {
            Assignment2Entities db = new Assignment2Entities();

            Course course = db.Courses.Where(x => x.CourseId == cCourse.CourseId).FirstOrDefault();

            Course studentTemp = ConvertToCourse(cCourse);

            db.Entry(course).CurrentValues.SetValues(studentTemp);

            db.SaveChanges();
            db.Dispose();

            return true;
        }

        [WebMethod]
        public List<CCourse> SearchCourses(String coursename)
        {
            Assignment2Entities db = new Assignment2Entities();

            List<Course> courses = (from m in db.Courses
                                    where m.CourseName.Contains(coursename)
                                    select m).ToList();

            List<CCourse> cCourses = new List<CCourse>();

            db.Dispose();

            foreach (Course c in courses)
            {
                cCourses.Add(ConvertToCCourse(c));
            }

            return cCourses;
        }
        
        [WebMethod]
        public CCourse GetCourse(int courseId)
        {
            Assignment2Entities db = new Assignment2Entities();

            Course course = db.Courses.Where(x => x.CourseId == courseId).FirstOrDefault();

            List<Enroll> enrolls = course.Enrolls.ToList();

            List<CStudent> classStudents = new List<CStudent>();

            StudentWebService studentWebService = new StudentWebService();
            foreach (Enroll e in enrolls)
            {
                classStudents.Add(studentWebService.ConvertToCStudent(e.Student));
            }

            CCourse cCourse = new CCourse();

            db.Dispose();

            cCourse = ConvertToCCourse(course);
            cCourse.Students = classStudents;

            return cCourse;
        }

        [WebMethod]
        public Boolean DeleteCourse(int studentId)
        {
            Assignment2Entities db = new Assignment2Entities();

            Course course = db.Courses.Where(x => x.CourseId == studentId).FirstOrDefault();

            List<Enroll> enrolls = course.Enrolls.ToList();

            db.Enrolls.RemoveRange(enrolls);
            db.Courses.Remove(course);

            db.SaveChanges();
            db.Dispose();

            return true;
        }

        public Course ConvertToCourse(CCourse cCourse)
        {
            Course course = new Course();

            course.CourseId = cCourse.CourseId;
            course.CourseCode = cCourse.CourseCode;
            course.CourseName = cCourse.CourseName;
            course.CourseCredits = cCourse.CourseCredits;
            course.SemesterNumber = cCourse.SemesterNumber;

            return course;
        }

        public CCourse ConvertToCCourse(Course course)
        {
            CCourse cCourse = new CCourse();

            cCourse.CourseId = course.CourseId;
            cCourse.CourseCode = course.CourseCode;
            cCourse.CourseName = course.CourseName;
            cCourse.CourseCredits = course.CourseCredits;
            cCourse.SemesterNumber = course.SemesterNumber;

            return cCourse;
        }

       



    }
}
