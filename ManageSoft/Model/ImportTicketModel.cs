using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSoft.Entity;
using System.Data.Linq;

namespace ManageSoft.Model
{
   public class ImportTicketModel
    {
        private DataDataContext data;
        public ImportTicketModel()
        {
            data = new DataDataContext();
        }
        public IQueryable SelectAllImportTicket()
        {
            Table<im_ticket> im_tickets = data.GetTable<im_ticket>();
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<employee> employees = data.GetTable<employee>();
            var query = from i in im_tickets
                        join s in shipments on i.id_im_ticket equals s.id_im_ticket 
                        group s by new {i.id_im_ticket,i.date_im,i.id_accountant,i.id_shipper,i.id_storager,i.id_write } into lll
                        select new { id = lll.Key.id_im_ticket, date = lll.Key.date_im,
                                      acc = lll.Key.id_accountant,shipper=lll.Key.id_shipper,writer=lll.Key.id_write,storage=lll.Key.id_storager 
                                    , sl = lll.Count() };
            var exe = from dd in query
                    join a in employees on dd.acc equals a.id_employee
                    join b in employees on dd.shipper equals b.id_employee
                    join c in employees on dd.storage equals c.id_employee
                    join d in employees on dd.writer equals d.id_employee
                    select new{ID = dd.id,date=dd.date,acc_name=a.name_employee,shipper_name= b.name_employee,
                        storage_name =c.name_employee ,write= d.name_employee,Sl=dd.sl };
            return exe;
        }
        public IQueryable SelectImportTicket(DateTime date)
        {
            #region
            Table<im_ticket> im_tickets = data.GetTable<im_ticket>();
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<employee> employees = data.GetTable<employee>();
            var query = from i in im_tickets
                        join s in shipments on i.id_im_ticket equals s.id_im_ticket
                        group s by new { i.id_im_ticket, i.date_im, i.id_accountant, i.id_shipper, i.id_storager, i.id_write } into lll
                        select new
                        {
                            id = lll.Key.id_im_ticket,
                            date = lll.Key.date_im,
                            acc = lll.Key.id_accountant,
                            shipper = lll.Key.id_shipper,
                            writer = lll.Key.id_write,
                            storage = lll.Key.id_storager,
                            sl = lll.Count()
                        };
            var exe = from dd in query
                      join a in employees on dd.acc equals a.id_employee
                      join b in employees on dd.shipper equals b.id_employee
                      join c in employees on dd.storage equals c.id_employee
                      join d in employees on dd.writer equals d.id_employee
                      where dd.date.Value.Equals(date)
                      select new
                      {
                          ID = dd.id,
                          date = dd.date,
                          acc_name = a.name_employee,
                          shipper_name = b.name_employee,
                          storage_name = c.name_employee,
                          write = d.name_employee,
                          Sl = dd.sl
                      };
            #endregion
            return exe;
        }
        public IQueryable SelectImportTicket(int month)
        {
            #region
            Table<im_ticket> im_tickets = data.GetTable<im_ticket>();
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<employee> employees = data.GetTable<employee>();
            var query = from i in im_tickets
                        join s in shipments on i.id_im_ticket equals s.id_im_ticket
                        group s by new { i.id_im_ticket, i.date_im, i.id_accountant, i.id_shipper, i.id_storager, i.id_write } into lll
                        select new
                        {
                            id = lll.Key.id_im_ticket,
                            date = lll.Key.date_im,
                            acc = lll.Key.id_accountant,
                            shipper = lll.Key.id_shipper,
                            writer = lll.Key.id_write,
                            storage = lll.Key.id_storager,
                            sl = lll.Count()
                        };
            var exe = from dd in query
                      join a in employees on dd.acc equals a.id_employee
                      join b in employees on dd.shipper equals b.id_employee
                      join c in employees on dd.storage equals c.id_employee
                      join d in employees on dd.writer equals d.id_employee
                      where dd.date.Value.Month.Equals(month)
                      select new
                      {
                          ID = dd.id,
                          date = dd.date,
                          acc_name = a.name_employee,
                          shipper_name = b.name_employee,
                          storage_name = c.name_employee,
                          write = d.name_employee,
                          Sl = dd.sl
                      };
            #endregion
            return exe;
        }
        public IQueryable SelectImportTicket(DateTime beginDate,DateTime endDate)
        {
            #region
            Table<im_ticket> im_tickets = data.GetTable<im_ticket>();
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<employee> employees = data.GetTable<employee>();
            var query = from i in im_tickets
                        join s in shipments on i.id_im_ticket equals s.id_im_ticket
                        group s by new { i.id_im_ticket, i.date_im, i.id_accountant, i.id_shipper, i.id_storager, i.id_write } into lll
                        select new
                        {
                            id = lll.Key.id_im_ticket,
                            date = lll.Key.date_im,
                            acc = lll.Key.id_accountant,
                            shipper = lll.Key.id_shipper,
                            writer = lll.Key.id_write,
                            storage = lll.Key.id_storager,
                            sl = lll.Count()
                        };
            var exe = from dd in query
                      join a in employees on dd.acc equals a.id_employee
                      join b in employees on dd.shipper equals b.id_employee
                      join c in employees on dd.storage equals c.id_employee
                      join d in employees on dd.writer equals d.id_employee
                      where dd.date.Value.CompareTo(beginDate)>=0&&dd.date.Value.CompareTo(endDate)<=0
                      select new
                      {
                          ID = dd.id,
                          date = dd.date,
                          acc_name = a.name_employee,
                          shipper_name = b.name_employee,
                          storage_name = c.name_employee,
                          write = d.name_employee,
                          Sl = dd.sl
                      };
            #endregion
            return exe;
        }
      
        public int insertImportTicket(im_ticket _im_ticket)
        {
            Table<im_ticket> im_ticket = data.GetTable<im_ticket>();
            im_ticket.InsertOnSubmit(_im_ticket);
            data.SubmitChanges();
            return _im_ticket.id_im_ticket;
        }
        public void updateImportTicket(im_ticket _im_ticket)
        {
            Table<im_ticket> im_tickets = data.GetTable<im_ticket>();
            im_ticket im_ticket=im_tickets.Single<im_ticket>(im =>im.id_im_ticket==_im_ticket.id_im_ticket);
            im_ticket.date_im = _im_ticket.date_im;
            im_ticket.id_accountant = _im_ticket.id_accountant;
            im_ticket.id_shipper = _im_ticket.id_shipper;
            im_ticket.id_storager = _im_ticket.id_storager;
            im_ticket.id_write = _im_ticket.id_write;
            data.SubmitChanges();
           // return im_ticket.Equals(_im_ticket);          
        }
        public void deleteImportTicket(im_ticket _im_ticket)
        {
            Table<im_ticket> kkk = data.GetTable<im_ticket>();
            kkk.DeleteOnSubmit(_im_ticket);
            data.SubmitChanges(); 
        }





    }
}
