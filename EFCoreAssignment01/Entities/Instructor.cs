using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public decimal HoureRate { get; set; }
        public int Dept_Id { get; set; }
    }
}
