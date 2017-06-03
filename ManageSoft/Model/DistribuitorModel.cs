using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSoft.Entity;

namespace ManageSoft.Model
{
   public class DistribuitorModel
    {
        private DataDataContext data;
        public DistribuitorModel()
        {
            data = new DataDataContext();
        }
        public IQueryable<distributor> SeachDistribui(String key)
        {
            Table<distributor> distri= data.GetTable<distributor>();
            var query = from dis in distri
                     where dis.name_distributor.Contains(key) || dis.id_distributor.ToString().Contains(key)
                     select dis;
            return query;
        }

        public IQueryable<distributor> SelectList()
        {
            return from d in data.distributors
                   select d;
        }
    }
}
