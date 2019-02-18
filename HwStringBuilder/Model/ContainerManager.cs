using System;
using HwStringBuilder.Model;

namespace HwStringBuilder.Model
{
    public class ContainerManager
    {
        public static Container GetContainer(CountryManager countryFactory)
        {
            Container container = new Container();
            
            Random random = new Random();

            int index = random.Next(0, 250);

            Country country = countryFactory.GetCountry(2);
            var status = countryFactory.GetCurrentStatus(country.Name);
            try
            {
                if (!status)
                {
                    container.CountryName = country.Name;
                    container.IsLoaded = 1;
                    country.Status = 1;
                    //countryFactory.ActivateCountry(2);
                }
                else
                {
                    container.CountryName = String.Empty;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return container;
        }
    }
}
