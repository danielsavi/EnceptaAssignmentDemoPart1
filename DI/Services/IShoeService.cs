using DAL;
using System.Collections.Generic;

namespace Services
{
    public interface IShoeService
    {
        List<Shoe> GetShoes();
    }
}
