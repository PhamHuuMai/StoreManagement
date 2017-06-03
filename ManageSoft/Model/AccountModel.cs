using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using ManageSoft.Entity;

namespace ManageSoft.Model
{
   public class AccountModel 
    {
        private DataDataContext data;
        public AccountModel()
        {
            data = new DataDataContext();
        }
        public Boolean CheckAccount(String username ,String password)
        {
            Table<account> acc = data.accounts;
            var query = from i in acc
                        where i.Username.Equals(username) && i.Pass.Equals(password)
                        select i;
            return query.Count<account>()==0 ? false : true;    
        } 

        
    }
}
