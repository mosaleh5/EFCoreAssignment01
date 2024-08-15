using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Entities
{
    public  class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public String Address { get; set; }
        public int Age { get; set; }
        public int Dep_id { get; set; }
    }
}
