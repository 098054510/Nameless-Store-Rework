using Nameless_Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nameless_Store.Models
{
    public class DepartmentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Brand> Brand { get; set; } = new List<Brand>();
        public ICollection<Performance_kit> Performance_kit { get; set; } = new List<Performance_kit>();
        public ICollection<Cars> Cars { get; set; } = new List<Cars>();
        public ICollection<Performance_parts> Performance_Parts { get; set; } = new List<Performance_parts>();

        public DepartmentModel()
        {
        }

        public DepartmentModel(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public void AddBrand(Brand B)
        {
            Brand.Add(B);
        }

        public void RemoveBrand(Brand B)
        {
            Brand.Remove(B);
        }

        public void AddAccessory(Performance_kit PK)
        {
            Performance_kit.Add(PK);
        }

        public void RemoveAccessory(Performance_kit PK)
        {
            Performance_kit.Remove(PK);
        }

        public void AddAccessory(Performance_parts PP)
        {
            Performance_Parts.Add(PP);
        }

        public void RemoveAccessory(Performance_parts PP)
        {
            Performance_Parts.Add(PP);
        }

        public void AddFullStockCar(Cars C)
        {
            Cars.Add(C);
        }

        public void RemoveFullStockCar(Cars C)
        {
            Cars.Remove(C);
        }
    }
}
