using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.App3.Models
{
    public class Country
    {
        public string Img { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Population { get; set; }

        public string Capital { get; set; }

        public Country(string img, string name, string description, string population, string capital)
        {
            Img = img;
            Name = name;
            Description = description;
            Population = population;
            Capital = capital;
        }

    }
}
