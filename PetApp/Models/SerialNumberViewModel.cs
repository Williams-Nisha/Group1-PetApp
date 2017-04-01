using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PetApp.Models
{
    public class SerialNumberViewModel
    {
        public List<Pet> pets;
        public SelectList serial;
        public string serialNumber { get; set; }
    }
}