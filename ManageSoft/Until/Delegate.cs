using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSoft.Entity;
namespace ManageSoft.Until
{
   public class Delegate
    {
        public delegate void SendEmployee(employee em);
        public delegate void AddItem(item item);
    }
}
