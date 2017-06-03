using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using ManageSoft.Entity;

namespace ManageSoft.Model
{
   public class ItemModel
    {
       private DataDataContext data;
       public ItemModel()
        {
            data = new DataDataContext();
        }
        public String GetNameItem(int id)
        {
            Table<item> items = data.GetTable<item>();
            var item = from i in items
                       where i.id_item==id
                       select i.item_name;
            return item.ToArray<string>()[0];
        }
        public IQueryable<item> SeachItem(String keyword)
        {
            Table<item> items = data.GetTable<item>();
            return from i in items
                   where i.id_item.ToString().Contains(keyword) || i.item_name.Contains(keyword)
                   select i;
        }
        public int InsertItem(item item)
        {
            Table<item> items = data.GetTable<item>();
            items.InsertOnSubmit(item);
            data.SubmitChanges();
            return item.id_item;
        }
    }
}
