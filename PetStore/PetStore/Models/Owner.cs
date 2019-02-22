using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore
{
    public class Owner
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string FullName { get; set; }
        [Required]
        [StringLength(20)]
        public string Street { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string Occupation { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
