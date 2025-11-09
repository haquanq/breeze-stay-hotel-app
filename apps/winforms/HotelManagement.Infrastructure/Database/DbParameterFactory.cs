using HotelManagement.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.Infrastructure.Database
{
    public class DbParameterFactory : IDbParameterFactory
    {
        public Dictionary<string, dynamic> Create<T>(T ob) where T : class
        {
            var p = new Dictionary<string, dynamic>();
            foreach (var a in typeof(T).GetProperties())
            {
                object[] atrributeList = a.GetCustomAttributes(typeof(DbMappingAttribute), true);
                if (atrributeList.Length == 0) continue;

                string name = atrributeList.Cast<DbMappingAttribute>().First().Name;
                var value = a.GetValue(ob);
                if (name is null || value is null) continue;

                if (value is Enum)
                {
                    p.Add(name, value.ToString());
                }
                else
                {
                    p.Add(name, value);
                }
            }

            return p;
        }
    }
}
