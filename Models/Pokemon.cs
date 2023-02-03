namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public ICollection<Review> Rewiews { get;set; }
        public ICollection<PokemonOwner> PokemonOwners { get;set; }
        public ICollection<PokemonCategory> PokemonCategories { get;set; }
    }
}
