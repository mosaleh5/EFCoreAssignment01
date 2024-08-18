using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Entities
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        [DataType(DataType.Text)]
        [Column(TypeName ="varchar(50)")]
        [MinLength(3)]
        public string Name { get; set; }
        public Course Course { get; set; }
    }
}
