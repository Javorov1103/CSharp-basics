using Fluffy.Models;

namespace Fluffy.Contracts
{
    public interface ICatService
    {
        void Add(Cat cat);
        List<Cat> GetAll();
    }
}
