using System.Linq;
using System.Collections.Generic;
using Nameless_Store.Data;

namespace Nameless_Store.Services
{
    public class Performance_kit
    {
        private readonly NamelessStoreContext _context;

        public Performance_kit(NamelessStoreContext context)
        {
            _context = context;
        }

        public List<Performance_kit> FindAll()
        {
            return _context.Performance_kit.ToList();
        }

        public int id { get; set; }
        public string Kit_name { get; set; }
        public double Price { get; set; }

        public Performance_kit()
        {
        }

        public Performance_kit(int id, string Kit_name, double Price)
        {
            this.id = id;
            this.Kit_name = Kit_name;
            this.Price = Price;
        }
    }
}
