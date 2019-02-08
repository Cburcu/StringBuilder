using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwStringBuilder
{
    public class Machines
    {
        public static int Id { get; set; }
        public string MachineName { get; set; }

        public string CountryName { get; set; }

        public Machines(int id, string name, string country)
        {
            Id = id;
            MachineName = name;
            CountryName = country;
        }
    }
}
