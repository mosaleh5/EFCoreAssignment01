using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Entities
{
    
    public class StudCourse
    {
        [Key]

        public int Stud_Id { get; set; }
        [Key]
        public int Course_Id { get; set; }
        [Required]
        [Range(1 ,100 , ErrorMessage = "invalid Grade , Please inter Grade from 1 to 100 ")]
        public int Grade { get; set; }

    }
}
