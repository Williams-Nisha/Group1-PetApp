using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PetApp.Models
{
    public class AnimalCategoryViewModel
    {
        public PaginatedList<Pet> pets;
        public SelectList category;
        public string AnimalCategory { get; set; }
    }
}