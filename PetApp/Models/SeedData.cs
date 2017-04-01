using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PetApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PetAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<PetAppContext>>()))
            {
                // Look for any movies.
                if (context.Pet.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pet.AddRange(
                     new Pet
                     {
                         RegisterDate = DateTime.Parse("2017-4-1"),
                         SerialNum = "45t85shr20",
                         AnimalCategory = "Dog",
                         Breed = "Lab",
                         AnimalName = "Mika",
                         BirthDate = DateTime.Parse("2005-10-21"),
                         OwnerName = "George Rogers",
                         OwnerStreet = "789 Aglentine",
                         OwnerCity = "Atlanta",
                         OwnerState = "Georgia",
                         OwnerZip = "45187",
                         OwnerPhoneNum = "546-812-7456",
                         PhotoUrl = "/images/mika.jpg"
        
                      },

                     new Pet
                     {
                         RegisterDate = DateTime.Parse("2017-4-1"),
                         SerialNum = "2156ghw51",
                         AnimalCategory = "Dog",
                         Breed = "Rotweiler",
                         AnimalName = "Gigi",
                         BirthDate = DateTime.Parse("2015-2-15"),
                         OwnerName = "Bethany Richardson",
                         OwnerStreet = "121 Harmony Way",
                         OwnerCity = "Biloxi",
                         OwnerState = "Mississippi",
                         OwnerZip = "75428",
                         OwnerPhoneNum = "225-852-5454",
                         PhotoUrl = "/images/gigi.jpg"
                     },

                     new Pet
                     {
                         RegisterDate = DateTime.Parse("2017-4-1"),
                         SerialNum = "sdf157rso",
                         AnimalCategory = "Bird",
                         Breed = "Parakeet",
                         AnimalName = "Roger",
                         BirthDate = DateTime.Parse("2008-8-6"),
                         OwnerName = "Natalie Durrant",
                         OwnerStreet = "546 Beach House Drive",
                         OwnerCity = "Miami",
                         OwnerState = "Florida",
                         OwnerZip = "84527",
                         OwnerPhoneNum = "561-287-8546",
                         PhotoUrl = "/images/roger.jpg"
                     },

                   new Pet
                   {
                       RegisterDate = DateTime.Parse("2017-4-1"),
                       SerialNum = "45t7v3u21",
                       AnimalCategory = "Bird",
                       Breed = "Dove",
                       AnimalName = "Lovely",
                       BirthDate = DateTime.Parse("2012-5-10"),
                       OwnerName = "Cecelia Arnold",
                       OwnerStreet = "579 Rolling Way",
                       OwnerCity = "New York",
                       OwnerState = "New York",
                       OwnerZip = "58739",
                       OwnerPhoneNum = "457-211-5479",
                       PhotoUrl = "/images/lovely.jpg"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
