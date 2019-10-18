using Library_Project_Master.DAL.ORM.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project_Master.DAL.ORM.Concrete
{
    public class Book:BaseEntity 
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
