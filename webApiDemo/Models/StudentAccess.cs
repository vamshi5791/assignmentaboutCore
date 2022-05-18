using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using webApiDemo.Models.DB;

namespace webApiDemo.Models
{
    public class StudentAccess
    {
        mySchoolContext context = new mySchoolContext();

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            students = context.Students.FromSqlRaw("select * from students").ToList();
            return students;
        }

        public List<Student> GetStudent(Student data)
        {
            List<Student> students = new List<Student>();
            students = context.Students.FromSqlRaw(string.Format("select * from students where studentid={0}", data.Studentid)).ToList();
            return students;
        }

        //update students set Name='virat'  where Studentid=1;

        public void Updatestudent(Student data)
        {

            context.Database.ExecuteSqlRaw(string.Format("update  students set Name='{0}' where studentid={1}", data.Name, data.Studentid));

        }
        public void AddStudents(Student data)
        {
            context.Database.ExecuteSqlRaw(string.Format("insert into students(Name,Age) values('{0}','{1}')",data.Name,data.Age));
        }

        public void DeleteStudent(Student data)
        {
            context.Database.ExecuteSqlRaw("delete  from students where studentid={0}", data.Studentid);

        }
        
    }
}
