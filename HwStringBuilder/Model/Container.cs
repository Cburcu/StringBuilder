using System;
using HwStringBuilder.Exceptions;

namespace HwStringBuilder.Model
{
    public class Container
    {
        private string _name;
        public int Id { get; set; }

        public string Name
        {
            get { return _name; }
            set {
                if (value == String.Empty)
                {
                    throw new ContainerNameIsNullException();
                }
                else
                {
                    _name = value;
                }
            } }

        public byte IsLoaded { get; set; }
    }
}
