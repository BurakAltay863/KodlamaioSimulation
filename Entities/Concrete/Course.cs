using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public int? Rate { get; set; }
        public int CategoryId { get; set; }
        public int IntructorId { get; set; }
    }
}
