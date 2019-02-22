using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore
{  

    public class Pet
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public int OwnerId { get; set; }
        public virtual Owner PetOwner { get; set; }
        public Breed Type { get; set; }
        public enum Breed { Dog, Cat, Fish, Hamester, [Display(Name = "Guinea Pig")] GuineaPig }
        
    }
}
