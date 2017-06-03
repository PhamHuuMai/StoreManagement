using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSoft.Entity;
using System.Data.Linq;
namespace ManageSoft.Model
{
   public class ShipmentModel
    {
        private DataDataContext data;
        public ShipmentModel()
        {
            data = new DataDataContext();
        }
        public int InsertShipment(shipment shipment )
        {
            Table<shipment> shipments = data.GetTable<shipment>();
            shipments.InsertOnSubmit(shipment);
            data.SubmitChanges();
            return shipment.id_shipment;
        }
        public void InsertShipment(IEnumerable<shipment> shipment)
        {
            Table<shipment> shipments = data.GetTable<shipment>();
            shipments.InsertAllOnSubmit<shipment>(shipment);
            data.SubmitChanges();
        }
        public IQueryable SelectShipment(int idImTicket)
        {
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<item> items = data.GetTable<item>();
            return from s in shipments
                   join i in items on s.id_item equals i.id_item
                   where s.id_im_ticket.Value == idImTicket
                   select new {
                      Số_Lô_Hàng =s.id_shipment,          
                      Tên_Mặt_Hàng =i.item_name,
                      Giá_Nhập=s.im_unit_price,
                      Giá_Bán=s.ex_unit_price,
                      Ngày_SX=s.man_date,
                      Hạn_SD=s.exp_date,
                      Số_Lượng=s.number,
                      Đơn_Vị=s.unit,
                      Vị_trí =s.posion,
                   };
        }
        public IQueryable SelectShipment()
        {
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<item> items = data.GetTable<item>();
            Table<ex_ticket_detail> dt = data.GetTable<ex_ticket_detail>();
            return from s in shipments
                   join i in items on s.id_item equals i.id_item
                   join d in dt on s.id_shipment equals d.id_shipment into aa
                   from a in aa.DefaultIfEmpty()
                   select new
                   {
                       Số_Lô_Hàng = s.id_shipment,
                       Mã_Hàng =s.id_item,
                       Tên_Mặt_Hàng = i.item_name,
                       Giá_Nhập = s.im_unit_price,
                       Giá_Bán = s.ex_unit_price,
                       Ngày_SX = s.man_date,
                       Hạn_SD = s.exp_date,
                       Số_Lượng = a.number==null?s.number:s.number-a.number,
                       Đơn_Vị = s.unit,
                       Vị_trí = s.posion,
                   };
        }
        public IQueryable<ItemInfor> Select()
        {
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<item> items = data.GetTable<item>();
            Table<ex_ticket_detail> dt = data.GetTable<ex_ticket_detail>();
            return from s in shipments
                   join i in items on s.id_item equals i.id_item
                   join d in dt on s.id_shipment equals d.id_shipment into aa
                   from a in aa.DefaultIfEmpty()
                   select new ItemInfor
                   {
                       id_shipment = s.id_shipment,
                       id_item = s.id_item,
                       NameItem=i.item_name,
                       im_unit_price = s.im_unit_price,
                       ex_unit_price = s.ex_unit_price,
                       man_date = s.man_date,
                       exp_date = s.exp_date,
                       number = a.number == null ? s.number : s.number - a.number,
                       unit = s.unit,
                       posion = s.posion,
                   };
        }
        public IQueryable SelectOut()
        {
            Table<ex_ticket_detail> detail = data.GetTable<ex_ticket_detail>();
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<ex_ticket> ex=data.GetTable<ex_ticket>();
            Table<im_ticket> im_tickets = data.GetTable<im_ticket>();
            Table<employee> employees = data.GetTable<employee>();
            var query1 = from d in detail
                        join s in shipments on d.id_shipment equals s.id_shipment
                        join e in ex on d.id_ex_ticket equals e.id_ex_ticket
                        select new
                        {
                            Ngày_xuất = e.date_ex,
                            Thành_tiền = d.number * s.ex_unit_price
                        };
            var re1 = from f in query1
                     group f.Thành_tiền by f.Ngày_xuất into j
                     select new
                     {
                         date = j.Key.Value,
                         money1 = j.Sum()
                     };
            var query2 = from i in im_tickets
                        join s in shipments on i.id_im_ticket equals s.id_im_ticket
                        select new
                        {
                            date = i.date_im,
                            money = s.im_unit_price * s.number
                        };
            var re2 = from i in query2
                     group i.money by i.date into kk
                     select new
                     {
                         date = kk.Key.Value,
                         money2 = kk.Sum()
                     };
            var leftJoin = from r1 in re1
                           join r2 in re2 on r1.date equals r2.date into temp
                           from t in temp.DefaultIfEmpty()
                           select new
                           {
                               date = r1.date,
                               money1 = r1.money1.Value,
                               money2 = t==null ? 0 : t.money2.Value
                           };
            var rightJoin = from r2 in re2
                            join r1 in re1 on r2.date equals r1.date into temp
                            from t in temp.DefaultIfEmpty()
                            select new
                            {
                               date = r2.date,
                               money1 = t==null ? 0 : t.money1.Value,
                               money2 = r2.money2.Value
                               
                            };
            var fullJoin= leftJoin.Union(rightJoin);
            return fullJoin;
        }
        public IQueryable Storage()
        {
            Table<ex_ticket_detail> detail = data.GetTable<ex_ticket_detail>();
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<item> items = data.GetTable<item>();
            Table<im_ticket> im_tickets = data.GetTable<im_ticket>();
            //            var query=from i in shipments
            var a = from d in detail
                    select new { d.id_shipment, d.number };
            var b = from c in a
                    group c.number by c.id_shipment into kkkk
                    select new { id = kkkk.Key,number = kkkk.Sum()};
            var g = from s in shipments
                    join e in im_tickets on s.id_im_ticket equals e.id_im_ticket
                    join f in items on s.id_item equals f.id_item
                    select new
                    {
                        Số_chứng_từ = s.id_im_ticket,
                        Ngày_nhập = e.date_im,
                        Số_lô=s.id_shipment,
                        Tên_mặt_hàng = f.item_name,
                        Ngày_SX = s.man_date,
                        Hạn_SD = s.exp_date,
                        Đơn_vị = s.unit,
                        Số_lượng_nhập = s.number,
                        Vị_trí = s.posion
                    };
            var n = from m in g
                    join l in b on m.Số_lô equals l.id into kk
                    from r in kk.DefaultIfEmpty()
                    select new
                    {
                        m.Số_chứng_từ,
                        m.Số_lô,
                        m.Ngày_nhập,
                        m.Tên_mặt_hàng,
                        m.Đơn_vị,
                        m.Số_lượng_nhập,
                        Số_lượng_trong_kho = r.number == null ? m.Số_lượng_nhập : (m.Số_lượng_nhập - r.number),
                        m.Ngày_SX,
                        m.Hạn_SD,
                        m.Vị_trí
                     };
            return n;
        }

    }
}
