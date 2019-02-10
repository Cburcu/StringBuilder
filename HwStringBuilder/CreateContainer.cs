using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwStringBuilder
{
    public class CreateContainer
    {
        public static Container GetContainer()
        {
            Container container = new Container();
            Country country = Countries.GetCountryName();
            container.CountryName = country.Name;
            country.Status = 1;
            container.IsLoaded = 1;
            return container;
        }
    }
}
