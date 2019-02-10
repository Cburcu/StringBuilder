namespace HwStringBuilder
{
    public class Machines
    {
        public int Id { get;  }
        public string MachineName { get; }

        public string CountryName { get;  }

        public Machines(int id, string name, string country)
        {
            Id = id;
            MachineName = name;
            CountryName = country;
        }
    }
}
