using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class Users
    {
        public int Id { get; set; }

        public string Password { get; set; }

        public int LockoutEnabled { get; set; }

        public DateTime LockoutEndDateUtc { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

    }
}
