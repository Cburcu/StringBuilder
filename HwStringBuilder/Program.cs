using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HwStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RandomCountry

            //List<Category> categories = new List<Category>()
            //{
            //    new Category{ Id=1, Name="Books" },
            //    new Category{ Id=2, Name="Journal" },
            //    new Category{ Id=3, Name="Novel" },
            //    new Category{ Id=4, Name="Map" },
            //    new Category{ Id=5, Name="Dictionary" },
            //    new Category{ Id=6, Name="Guidebook" },
            //    new Category{ Id=7, Name="Encyclopedia" },
            //    new Category{ Id=8, Name="Culture" },
            //    new Category{ Id=9, Name="Education" },
            //    new Category{ Id=10, Name="Philosophy" }
            //};
            //Random random = new Random();

            #endregion

            #region Random Ex

            //StringBuilder stringBuilder = new StringBuilder();
            //for (int i = 0; i < 100; i++)
            //{
            //    stringBuilder.AppendLine(string.Format("Product{0}|{1}|{2}", i.ToString(), random.Next(100, 500).ToString(), DateTime.Now.AddDays(random.Next(1, 7)).ToString()));
            //}
            //File.WriteAllText("Products.txt", stringBuilder.ToString());

            #endregion

            #region GetRequest

            //string url = "http://country.io/names.json";

            //WebRequest request = WebRequest.Create(url);
            //request.Credentials = CredentialCache.DefaultCredentials;
            //WebResponse response = request.GetResponse();
            //Stream dataStream = response.GetResponseStream();
            //StreamReader reader = new StreamReader(dataStream);
            //string responseFromServer = reader.ReadToEnd();

            //string[] countries = responseFromServer.Split(',');
            //for (int i = 0; i < countries.Length; i++)
            //{
            //    if (i == 20 || i == 21)
            //    {
            //        var x = countries[i];
            //        count.Add(x);
            //    }
            //    var cntry = countries[i].Split(':');
            //    count.Add(cntry[1]);
            //}

            //reader.Close();
            //response.Close();
            #endregion

            Dictionary<Machines, string> MachineCity = new Dictionary<Machines, string>();
            Random rand = new Random();
            var countries = Countries.GetCountries();

            //Machines[] machines = new Machines[]
            //{
            //    new Machines(1, "Machine1", countries[rand.Next(countries.Count)]),
            //    new Machines(2, "Machine2", countries[rand.Next(countries.Count)]),
            //    new Machines(3, "Machine3", countries[rand.Next(countries.Count)]),
            //    new Machines(4, "Machine4", countries[rand.Next(countries.Count)]),
            //    new Machines(5, "Machine5", countries[rand.Next(countries.Count)])
            //};

            // herhangi bir makinaya countryName eklediğinde o countryName listeden çıkmalı

            Machines[] machines = new Machines[5];
            for (var m = 0; m < 5; m++)
            {
                int index = rand.Next(countries.Count);
                string countryName = countries[index];
                machines[m] = new Machines(1, $"Machine{countryName}", countryName);
                countries.Remove(countryName);
            }

            foreach (var machine in machines)
            {
                Console.WriteLine($"{machine.MachineName} => {machine.CountryName}");
            }

            Console.ReadLine();
        }
    }
}
