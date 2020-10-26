using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grup22.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Boolean isAdmin { get; set; }
    }
}
