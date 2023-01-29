using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemStore;
namespace MyConsole
{
    public interface IDiscount
    {
        string Title { get; set; }
        void IsDiscounted();

        bool HasOrderBeenCompleted { get; }
        void ShipItem(Item item);
    }
}