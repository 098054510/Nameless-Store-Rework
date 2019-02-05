using Nameless_Store.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nameless_Store.Services
{
    public class Cars
    {

        private readonly NamelessStoreContext _context;

        public Cars(NamelessStoreContext context)
        {
            _context = context;
        }

        public List<Cars> FindAll()
        {
            return _context.Cars.ToList();
        }

        public int ID { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double BasePrice { get; set; }

        public Cars()
        {
        }

        public Cars(int ID, string Model, int Year, double BasePrice)
        {
            this.ID = ID;
            this.Model = Model;
            this.Year = Year;
            this.BasePrice = BasePrice;
        }
    }
}
