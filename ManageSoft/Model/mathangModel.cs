using ManageSoft.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoft.Model
{
   public class mathangModel
    {
        DataDataContext data = new DataDataContext();
        public IQueryable SelectAllMatHang()
        {
            return from i in data.items
                   select new
                   {
                       i.id_item,
                       i.item_name,
                       i.name_type,
                       i.planet_type,
                   };
        }
        public int InsertMatHang(item e)
        {
            try
            {
                data.items.InsertOnSubmit(e);
                data.SubmitChanges();
            }
            catch (Exception ee)
            {
                throw ee;
            }
            return e.id_item;
        }
        public void UpdateMatHang(item e)
        {
            try
            {
                item ee = data.items.SingleOrDefault(x => x.id_item == e.id_item);
                ee.id_item = e.id_item;
                ee.item_name = e.item_name;
                ee.name_type = e.name_type;
                ee.planet_type = e.planet_type;
                data.SubmitChanges();
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }
        public void DeleteMatHang(int id)
        {
            try
            {
                data.items.DeleteOnSubmit(data.items.SingleOrDefault(c => c.id_item == id));
                data.SubmitChanges();
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }
    }
}
