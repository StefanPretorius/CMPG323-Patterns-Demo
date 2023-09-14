using HomeWork_Patterns.Data;
using HomeWork_Patterns.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HomeWork_Patterns.Repository
{
    public class ServiceRepository : GenericRepository<Service> , IServiceRepository
    {
        //protected readonly CMPG_323_Patterns_HomeworkContext _context = new CMPG_323_Patterns_HomeworkContext();
        // public IEnumerable<Service> GetAll()
        // {
        //     return _context.Services.ToList();
        // }
        public ServiceRepository(CMPG_323_Patterns_HomeworkContext context) : base(context)
        {

        }

        public  Service GetMostRecentService()
        {
            return _context.Services.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }
}
