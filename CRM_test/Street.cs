using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_test
{
    public  class Street
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int ShowOrder { get; set; }
        public int CityCode { get; set; }
        List<Street> listOfStreets = new List<Street>();

        public Street()
        {

        }

        public Street(string name, int showorder, int citycode)
        {
            Name = name;
            ShowOrder = showorder;
            CityCode = citycode;
        }


        public void Add(Street street)
        {

            listOfStreets.Add(street);
        }

        //public List<Street> GetStreets(string cityName)
        //{
        //    List<Street> streets = new List<Street>();
        //    if (listOfStreets.Contains()
        //    {

        //    }
        //}

        public override string ToString()
        {
            return $"Name: {Name}, Code: {Code}, Show Order: {ShowOrder} , City Code: {CityCode} ";
        }
    }
}
