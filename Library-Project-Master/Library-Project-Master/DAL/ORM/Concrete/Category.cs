using Library_Project_Master.DAL.ORM.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project_Master.DAL.ORM.Concrete
{
    public class Category:BaseEntity 
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
