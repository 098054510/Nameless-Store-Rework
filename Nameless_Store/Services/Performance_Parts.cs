using System.Linq;
using System.Collections.Generic;
using Nameless_Store.Data;

namespace Nameless_Store.Services
{
    public class Performance_parts
    {
        private readonly NamelessStoreContext _context;

        public Performance_parts(NamelessStoreContext context)
        {
            _context = context;
        }

        public List<Performance_parts> FindAll()
        {
            return _context.Performance_Parts.ToList();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Performance_parts()
        {
        }

        public Performance_parts(int ID, string Name, double Price)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
        }
    }
}
