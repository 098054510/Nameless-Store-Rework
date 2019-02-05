using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nameless_Store.Data;
using Nameless_Store.Services;

namespace Nameless_Store.Data
{
    public class SeedingService
    {
        private NamelessStoreContext _context;

        public SeedingService(NamelessStoreContext context)
        {
            _context = context;
        }

        public void Seed() //Use this for add more cars, accessories and brands.
        {
            if (_context.Brands.Any() ||
                _context.Cars.Any() ||
                _context.Performance_kit.Any() ||
                _context.Performance_Parts.Any())
            {
                return; // Case Return, the Database has been seeded.
            }


            Brand B1 = new Brand(1, "Volkswagen", "Germany");
            Brand B2 = new Brand(2, "General Motors Co.", "United States");

            Cars C1 = new Cars(1, "Gol Plus 1.6", 1986, 5500);
            Cars C2 = new Cars(2, "Passat LSE 1.6", 1986, 5800);
            Cars C3 = new Cars(3, "Opala Diplomata SL/E 4.1", 1992, 9000);
            Cars C4 = new Cars(4, "Omega CD 4.1", 1996, 16000);

            Performance_parts A4 = new Performance_parts(1, "Surge Tank", 800);
            Performance_parts A8 = new Performance_parts(2, "Camshaft '49g'", 169);

            _context.Cars.AddRange(C1, C2, C3, C4);
            _context.Brands.AddRange(B1, B2);
            _context.Performance_Parts.AddRange(A4, A8);
            _context.SaveChanges();

        }
    }
}
