using HomeWork_Patterns.Data;
using HomeWork_Patterns.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork_Patterns.Repository
{
    public class ServiceRepository
    {
        protected readonly CMPG_323_Patterns_HomeworkContext _context = new CMPG_323_Patterns_HomeworkContext();
        public IEnumerable<Service> GetAll()
        {
            return _context.Services.ToList();
        }
    }
}
