using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole.Shop
{
    public static class Factory
    {
        public static List<IPerson> personList = new();
        public static IPerson CreatePerson()
        {
            return new Person();
        }

    }
}