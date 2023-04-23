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

    // GET api/pets
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pet>>> Get()
    {
      return await _db.Pets.ToListAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Pet>> GetPet(int id)
    {
         Pet pet = await _db.Pets.FindAsync(id);

        if (pet == null)
        {
            return NotFound();
        }

        return pet;
    }
    
    // POST api/pets
    [HttpPost]
    public async Task<ActionResult<Pet>> Post(Pet pet)
    {
      _db.Pets.Add(pet);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPet), new { id = pet.PetId }, pet);
    }

    // PUT: api/Pets/5
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

    // DELETE: api/Pets/5
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