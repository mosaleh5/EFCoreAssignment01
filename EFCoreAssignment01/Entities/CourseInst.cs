using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment01.Entities
{
    
    public  class CourseInst
    {
        public int InstId { get; set; }
        public int CourseId { get; set; }
        public double Evaluate { get; set; }
    }
}
