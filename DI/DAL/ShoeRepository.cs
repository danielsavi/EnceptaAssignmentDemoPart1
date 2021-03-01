using System.Collections.Generic;

namespace DAL
{
    public class ShoeRepository : IShoeRepository
    {
        public List<Shoe> GetShoes()
        {
            return new List<Shoe>(){
                new Shoe { Id = 1, Name = "shoe1" },
                new Shoe { Id = 2, Name = "shoe2" },
                new Shoe { Id = 3, Name = "shoe3" },
                new Shoe { Id = 4, Name = "shoe4" },
            };
        }
    }
}
