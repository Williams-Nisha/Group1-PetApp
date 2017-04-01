using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PetApp.Models
{
    public class AnimalCategoryViewModel
    {
        public List<Pet> pets;
        public SelectList category;
        public string animalCategory { get; set; }
    }
}