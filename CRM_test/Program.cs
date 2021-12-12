using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            List<Street> streets = new List<Street>();


            cities.Add(new City("Ashdod", 1 , streets));
            cities.Add(new City("Azor", 2, streets));
            cities.Add(new City("Holon", 3, streets));

            streets.Add(new Street("Bograshov", 1, 3));
            streets.Add(new Street("Arlozorov", 2, 3));
            streets.Add(new Street("Jabotinsky", 3, 3));

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
