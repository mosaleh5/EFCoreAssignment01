using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public Department? Department { get; set; }
        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }

        public Department? ManagedDepartment { get; set; }


        public List<CourseInst> CourseInsts { get; set; }


    }
}
