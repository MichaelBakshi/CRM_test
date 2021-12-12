using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_test
{
    public  class City
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int ShowOrder { get; set; }
        //List<City> listOfCities = new List<City>();
        List<Street> listOfStreets = new List<Street>();

        public City ()
        {

        }

        public City(string name, int showorder, List<Street> streets)
        {
            Name = name;
            ShowOrder = showorder;
        }

        public void Add(string name,  int showorder, List<Street> streets)
        {

            City c = new City(name, showorder, streets);
        }

        //public void GetAllCities()
        //{
        //    foreach (var item in listOfCities)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}



        public override string ToString()
        {
            return $"Name: {Name}, Code: {Code}, Show Order: {ShowOrder} ";
        }
    }
}
