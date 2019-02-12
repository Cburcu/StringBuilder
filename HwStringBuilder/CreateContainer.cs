using System;
using System.Collections.Generic;

namespace HwStringBuilder
{
    public class CreateContainer
    {
        public static Container GetContainer(List<Country> countries)
        {
            Container container = new Container();
            Random random = new Random();

            int index = random.Next(0, 250);

            var country = countries[index];
            
            try
            {
                if (country.Status != 1)
                {
                    container.CountryName = country.Name;
                    country.Status = 1;
                    container.IsLoaded = 1;
                }
                else
                {
                    container.CountryName = string.Empty;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return container;
        }
    }
}
