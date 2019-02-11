using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Class8Example1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public int Age { get; set; }
        public Classroom StudentClassroom { get; set; }
        public Address StudentAddress { get; set; }

    }

    public class Classroom
    {
        public int ClassroomId { get; set; }

        [Required]
        [DisplayName("Classroom Name")]
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }

        public override string ToString()
        {
            return Name + ","+ Number;
        }
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return Street+", "+City+", "+PostalCode;
        }
    }
}