using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EF.Models
{
    public class PersonDepartment
    {
        public int Id { get; set; }


        public int PersonId { get; set; }
        public int DepartmentId { get; set; }
    }
}
