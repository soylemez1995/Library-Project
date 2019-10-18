using Library_Project_Master.DAL.ORM.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project_Master.DAL.ORM.Concrete
{
    public enum Role
    {
        None = 0,
        Admin = 1,
        Employee = 2,
        Customer = 3,
        Author = 4
    }
    public class AppUser:BaseEntity 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; internal set; }
        public string UserName { get; internal set; }

        public Role Role { get; set; }

        public virtual List<Book> Books { get; set; }

    }
}
