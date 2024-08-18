using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Entities
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }

        public Instructor? Manager { get; set; }
        public int? InsManagerId { get; set; }

        public List<Instructor> Instructors { get; set; }
        public List<Student> students { get; set; }

    }
}
