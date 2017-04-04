using System;
using System.ComponentModel.DataAnnotations;

namespace PetApp.Models
{
    public class Pet
    {
        public int ID { get; set; }

        [Display(Name = "Register Date")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]*$")]
        [Required]
        [StringLength(9)]
        [Display(Name = "Serial Number")]
        public string SerialNum { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Animal Category")]
        public string AnimalCategory { get; set; }

        [Display(Name = "Breed")]
        public string Breed { get; set; }


        [Display(Name = "Animal Name")]
        public string AnimalName { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(40)]
        [Display(Name = "Owner Name")]
        public string OwnerName { get; set; }

        [RegularExpression(@"^[\w ]+$")]
        [Required]
        [StringLength(50)]
        [Display(Name = "Owner Street")]
        public string OwnerStreet { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Owner City")]
        public string OwnerCity { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Owner State")]
        public string OwnerState { get; set; }

        [RegularExpression(@"^[0-9]*$")]
        [Required]
        [StringLength(5)]
        [Display(Name = "Owner Zip")]
        public string OwnerZip { get; set; }

        [RegularExpression(@"^(?:-*\d-*){10}$")]
        [Required]
        [StringLength(12)]
        [Display(Name = "Phone Number")]
        public string OwnerPhoneNum { get; set; }


        [Display(Name = "Photo Url")]
        public string PhotoUrl { get; set; }
    }
}
