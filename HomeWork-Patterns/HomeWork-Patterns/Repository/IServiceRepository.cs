using HomeWork_Patterns.Models;

namespace HomeWork_Patterns.Repository
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
    }
}
