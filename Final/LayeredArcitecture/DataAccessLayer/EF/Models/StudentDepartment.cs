using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class StudentDepartment
    {
        public int Id { get; set; }
        public int StdId { get; set; }
        public int DeptId { get; set; }
    }
}
