using System;
using HwStringBuilder.Model;

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

            var countries = Countries.CountriesStatus();

            Container container1 = ContainerManager.Get(countries);
            Container container2 = ContainerManager.Get(countries);

            Console.WriteLine($"{container1.Name} - {container1.IsLoaded}");
            Console.WriteLine($"{container2.Name} - {container2.IsLoaded}");

            Console.ReadLine();
        }
    }
}
