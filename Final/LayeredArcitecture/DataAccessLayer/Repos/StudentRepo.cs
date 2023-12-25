using DataAccessLayer.EF;
using DataAccessLayer.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    public class StudentRepo
    {
        public static List<Student> Get()
        {
            var db = new PeopleManagementContext();
            return db.Students.ToList();
        }

        public static Student Get(int id) 
        {
            var db = new PeopleManagementContext();
            return db.Students.Find(id);
        }

        public static bool Add(Student student) 
        {
            var db = new PeopleManagementContext();
            db.Students.Add(student);
            return db.SaveChanges() > 0;
        }
        public static bool Update(Student student)
        {
            var ex = Get(student.Id);
            var db = new PeopleManagementContext(); 
            db.Entry(ex).CurrentValues.SetValues(student);
            return db.SaveChanges() > 0;

        }
        public static bool Delete(int id)
        {
            var ex = Get(id);
            var db = new PeopleManagementContext();
            db.Students.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
