using Microsoft.EntityFrameworkCore;

namespace PetShelterAPI.Models
{
  public class PetShelterAPIContext : DbContext
  {
    public DbSet<Pet> Pets { get; set; }

    public PetShelterAPIContext(DbContextOptions<PetShelterAPIContext> options) : base(options)
    {
    }
      protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pet>()
        .HasData(
          new Pet { PetId = 1, Name = "Matilda", Species = "Cat", Sex = "Female", Color = "brown", Age = 7, Description = "est. Nunc laoreet lectus quis massa. Mauris vestibulum," },
          new Pet { PetId = 2, Name = "Rexie", Species = "Cat", Sex = "Female", Color = "black", Age = 2, Description = "pellentesque massa lobortis ultrices. Vivamus rhoncus. Donec" },
          new Pet { PetId = 3, Name = "Matilda", Species = "Dog", Sex = "Male", Color = "white", Age = 4, Description = "tincidunt tempus risus. Donec egestas. Duis ac arcu." },
          new Pet { PetId = 4, Name = "Pip", Species = "Dog", Sex = "Female", Color = "white", Age = 4, Description = "enim. Mauris quis turpis vitae purus gravida sagittis. Duis gravida" },
          new Pet { PetId = 5, Name = "Bartholomew", Species = "Dog", Sex = "Male", Color = "cream", Age = 1, Description = "ultrices posuere cubilia Curae Phasellus ornare." }
        );
    }
  }
}