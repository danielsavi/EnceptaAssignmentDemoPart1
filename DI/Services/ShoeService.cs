using System.Collections.Generic;
using DAL;

namespace Services
{
    public class ShoeService : IShoeService
    {
        private IShoeRepository _iShoeRepository;

        public ShoeService(IShoeRepository iShoeRepository)
        {
            _iShoeRepository = iShoeRepository;
        }
        public List<Shoe> GetShoes()
        {
            return _iShoeRepository.GetShoes();
        }
    }
}
