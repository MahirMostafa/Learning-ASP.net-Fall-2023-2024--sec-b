using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo
    {
        public static string Get(int id)
        {
            return "ID found";
        }
        public static string Create(News n) 
        {
            return "Created";
        }
    }
}
