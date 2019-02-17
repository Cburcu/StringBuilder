using System;
using System.Collections.Generic;

namespace HwStringBuilder.Model
{
    public class ContainerManager
    {
        public static Container Get(List<Country> countries)
        {
            Container container = new Container();
            Random random = new Random();

            int index = random.Next(0, 250);

            var country = countries[index];
            
            try
            {
                if (country.Status != 1)
                {
                    container.Name = country.Name;
                    country.Status = 1;
                    container.IsLoaded = 1;
                }
                else
                {
                    container.Name = string.Empty;
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
