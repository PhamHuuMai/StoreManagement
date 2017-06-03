using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoft.Model
{
    public class ItemInfor : Entity.shipment
    {
        private String nameItem;

        public string NameItem
        {
            get
            {
                return nameItem;
            }

            set
            {
                nameItem = value;
            }
        }
    }
}
