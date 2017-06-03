using ManageSoft.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoft.Model
{
    public class DoitacModel
    {
        DataDataContext data = new DataDataContext();
        public IQueryable SelectAllDoitac()
        {
            return from i in data.distributors
                   select new
                   {
                       i.id_distributor,
                       i.name_distributor,
                       i._address,
                   };
        }
        public int InsertDoitac(distributor e)
        {
            try
            {
                data.distributors.InsertOnSubmit(e);
                data.SubmitChanges();
            }
            catch (Exception ee)
            {
                throw ee;
            }
            return e.id_distributor;
        }
        public void UpdateDoitac(distributor e)
        {
            try
            {
                distributor ee = data.distributors.SingleOrDefault(a =>a.id_distributor == e.id_distributor);
                ee.id_distributor = e.id_distributor;
                ee.name_distributor = e.name_distributor;
                ee._address = e._address;
                data.SubmitChanges();
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }
        public void DeleteDoitac(int id)
        {
            try
            {
                data.distributors.DeleteOnSubmit(data.distributors.SingleOrDefault(c => c.id_distributor == id));
                data.SubmitChanges();
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }
    }
}
