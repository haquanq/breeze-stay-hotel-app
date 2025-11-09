using System;

namespace HotelManagement.Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DbMappingAttribute : Attribute
    {
        private string _name;
        public string Name { get => _name; }

        public DbMappingAttribute(string name) { _name = name; }
    }
}
