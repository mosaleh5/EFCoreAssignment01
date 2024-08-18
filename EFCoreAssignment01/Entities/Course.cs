using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName ="varchar(max)")]
        [MinLength(150)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.Duration)]
        public int Duration { get; set; }
        public Topic Topic { get; set; }
        public int Top_Id { get; set; }

       public List<StudCourse> StudCourses { get; set; }
        public List<CourseInst> CourseInsts { get; set; }
    }
}
