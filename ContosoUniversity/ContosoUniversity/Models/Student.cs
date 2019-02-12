using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
                
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}