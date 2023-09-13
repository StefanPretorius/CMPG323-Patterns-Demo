using HomeWork_Patterns.Data;
using HomeWork_Patterns.Models;

namespace HomeWork_Patterns.Repository
{
    public class ProductRepository
    {
        protected readonly CMPG_323_Patterns_HomeworkContext _context = new CMPG_323_Patterns_HomeworkContext();

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public IEnumerable<Product> Details(Guid? id)
        {
            return _context.Products.ToList();
        }

    }
}
