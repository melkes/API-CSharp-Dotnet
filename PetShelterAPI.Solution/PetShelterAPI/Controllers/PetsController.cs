using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShelterAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class PetsController : ControllerBase
{
    private readonly PetShelterAPIContext _db;

    public PetsController(PetShelterAPIContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pet>>> Get(string name, string species, string sex, string color, int minimumAge, string description)
    {
      IQueryable<Pet> query = _db.Pets.AsQueryable();
      
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      
      if (sex != null)
      {
        query = query.Where(entry => entry.Sex == sex);
      }
      
      if (color != null)
      {
        query = query.Where(entry => entry.Color == color);
      }

      if (minimumAge > 0)
      {
        query = query.Where(entry => entry.Age >= minimumAge);
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }

      return await query.ToListAsync();
    }
    
    // [HttpGet("{id}")]
    // public async Task<ActionResult<Pet>> GetPet(int id)
    // {
    //      Pet pet = await _db.Pets.FindAsync(id);

    //     if (pet == null)
    //     {
    //         return NotFound();
    //     }

    //     return pet;
    // }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPet(int id)
    {
    var pet = await _db.Pets
             .FirstOrDefaultAsync(pet => pet.PetId == id);
     if (pet == null)
      {
        return NotFound();
      }
      return Ok(pet);
    }

    [HttpPost]
    public async Task<ActionResult<Pet>> Post(Pet pet)
    {
      _db.Pets.Add(pet);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPet), new { id = pet.PetId }, pet);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Pet pet)
    {
      if (id != pet.PetId)
      {
        return BadRequest();
      }

      _db.Pets.Update(pet);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!PetExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool PetExists(int id)
    {
      return _db.Pets.Any(e => e.PetId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePet(int id)
    {
      Pet pet = await _db.Pets.FindAsync(id);
      if (pet == null)
      {
        return NotFound();
      }

      _db.Pets.Remove(pet);
      await _db.SaveChangesAsync();

      return NoContent();
    }
}