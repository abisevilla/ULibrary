using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebULibrary.Models
{
    public class BookEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Gender { get; set; }

        public int IdAutor { get; set; }
        public int year { get; set; }
    }
}
