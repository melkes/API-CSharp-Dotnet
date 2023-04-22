namespace PetShelterAPI.Models
{
  public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        // public string Breed { get; set; }
        public string Sex { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        // public string Image { get; set; }
        public string Description { get; set; }
    }
}