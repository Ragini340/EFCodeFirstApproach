using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstFinal.Models
{
    public class StudentData
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}