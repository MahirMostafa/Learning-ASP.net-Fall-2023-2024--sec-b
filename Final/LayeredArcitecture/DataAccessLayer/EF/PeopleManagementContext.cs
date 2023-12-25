using DataAccessLayer.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF
{
    public class PeopleManagementContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department>Departments { get; set; }
    }
}
