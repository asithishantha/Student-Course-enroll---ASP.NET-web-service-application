using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Assignment2_Server.Services
{
    /// <summary>
    /// Summary description for EnrollWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EnrollWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public Boolean Enroll(int studentId, int courseId)
        {
            Assignment2Entities db = new Assignment2Entities();

            Enroll enroll = db.Enrolls.Where(x => x.StudentId == studentId && x.CourseId == courseId).FirstOrDefault();

            if (enroll != null)
            {
                return false;
            }

            Enroll enrollment = new Enroll();

            enrollment.StudentId = studentId;
            enrollment.CourseId = courseId;


            db.Enrolls.Add(enrollment);

            db.SaveChanges();
            db.Dispose();

            return true;
        }
    }
}
