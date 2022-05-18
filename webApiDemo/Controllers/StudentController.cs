using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webApiDemo.Models;
using webApiDemo.Models.DB;

namespace webApiDemo.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       
        StudentAccess sc = new StudentAccess();
        [Route("students")]
        public ActionResult GetAllStudentsData()
        {
            List<Student> students = new List<Student>();
            students= sc.GetAllStudents();
            if(students==null || students.Count == 0)
            {
                return BadRequest();
            }
            return Ok(students);
        }

        [Route("add-student")]
        public ActionResult AddStudentsData(Student data)
        {
            sc.AddStudents(data);
            return Ok("success");
        }

        [Route("delete-student")]
        public ActionResult DeleteStudentData(Student data)
        {
            sc.DeleteStudent(data);
            return Ok("student deleted");
        }

        [Route("get-student")]
        public ActionResult GetStudentData(Student data)
        {
            List<Student> stu = new List<Student>();

            stu = sc.GetStudent(data);
            return Ok(stu);
        }
        [Route("update-student")]
        public ActionResult UpdatestudentData(Student data)
        {
            List<Student> stu = new List<Student>();

            sc.Updatestudent(data);
            return Ok("Data updated");
        }
    }
}
