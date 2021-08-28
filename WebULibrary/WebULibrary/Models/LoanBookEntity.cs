using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebULibrary.Models
{
    public class LoanBookEntity: BaseEntity
    {
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public bool IsOpen { get; set; }

    }
}
