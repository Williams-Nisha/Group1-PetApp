using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetApp.Models;

namespace PetApp.Controllers
{
    public class PetsController : Controller
    {
        private readonly PetAppContext _context;

        public PetsController(PetAppContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(string animalCategory, string searchString, string getBreed, string getZip, int? page)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> categoryQuery = from p in _context.Pet
                                               orderby p.AnimalCategory
                                               select p.AnimalCategory;

            var pets = from p in _context.Pet
                       select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                pets = pets.Where(s => s.SerialNum.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(animalCategory))
            {
                pets = pets.Where(x => x.AnimalCategory == animalCategory);
            }

            if (!String.IsNullOrEmpty(getBreed))
            {
                pets = pets.Where(s => s.Breed.Contains(getBreed));
            }

            if (!String.IsNullOrEmpty(getZip))
            {
                pets = pets.Where(s => s.OwnerZip.Contains(getZip));
            }

            var animalCatVM = new AnimalCategoryViewModel();
            animalCatVM.category = new SelectList(await categoryQuery.Distinct().ToListAsync());
            //animalCatVM.pets = await pets.ToListAsync();

            int pageSize = 4;
            animalCatVM.pets = await PaginatedList<Pet>.CreateAsync(pets.AsNoTracking(), page ?? 1, pageSize);

            return View(animalCatVM);
        }


        // GET: Pets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet
                .SingleOrDefaultAsync(m => m.ID == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // GET: Pets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,RegisterDate,SerialNum,AnimalCategory,Breed,AnimalName,BirthDate,OwnerName,OwnerStreet,OwnerCity,OwnerState,OwnerZip,OwnerPhoneNum,PhotoUrl")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet.SingleOrDefaultAsync(m => m.ID == id);
            if (pet == null)
            {
                return NotFound();
            }
            return View(pet);
        }

        // POST: Pets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,RegisterDate,SerialNum,AnimalCategory,Breed,AnimalName,BirthDate,OwnerName,OwnerStreet,OwnerState,OwnerZip,OwnerPhoneNum,PhotoUrl")] Pet pet)
        {
            if (id != pet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(pet);
        }

        // GET: Pets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet
                .SingleOrDefaultAsync(m => m.ID == id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pet = await _context.Pet.SingleOrDefaultAsync(m => m.ID == id);
            _context.Pet.Remove(pet);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PetExists(int id)
        {
            return _context.Pet.Any(e => e.ID == id);
        }
    }
}
