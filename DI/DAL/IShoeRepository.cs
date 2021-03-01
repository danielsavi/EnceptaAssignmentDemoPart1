using System.Collections.Generic;

namespace DAL
{
  public  interface IShoeRepository
    {
        List<Shoe> GetShoes();
    }
}
