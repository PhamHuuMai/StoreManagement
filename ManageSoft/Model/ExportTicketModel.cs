using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSoft.Entity;
using System.Data.Linq;

namespace ManageSoft.Model
{
   public class ExportTicketModel
    {
        private DataDataContext data;
        public ExportTicketModel()
        {
            data = new DataDataContext();
        }
        public int Insert(ex_ticket e)
        {
            Table<ex_ticket> table = data.GetTable<ex_ticket>();
            table.InsertOnSubmit(e);
            data.SubmitChanges();
            return e.id_ex_ticket;
        }
        public void Insert(List<ex_ticket_detail> exDetail)
        {
            Table<ex_ticket_detail> table = data.GetTable<ex_ticket_detail>();
            table.InsertAllOnSubmit<ex_ticket_detail>(exDetail);
            data.SubmitChanges();
        }
        public IQueryable SelectTicket()
        {
            Table<ex_ticket> ex = data.GetTable<ex_ticket>();
            Table<distributor> dis = data.GetTable<distributor>();
            Table<employee> em = data.GetTable<employee>();
            var query = from e in ex
                        join d in dis on e.id_distributor equals d.id_distributor
                        join f in em on e.id_write equals f.id_employee
                        join g in em on e.id_accountant equals g.id_employee
                        join h in em on e.id_shipper equals h.id_employee
                        join i in em on e.id_storager equals i.id_employee
                        select new
                        {
                            Số_chứng_từ = e.id_ex_ticket,
                            Nhà_nhập_khẩu = d.name_distributor,
                            Ngày_nhập = e.date_ex,
                            Kế_toán = g.name_employee,
                            Thủ_kho = i.name_employee,
                            Người_lập_phiếu = f.name_employee,
                            Người_nhận = h.name_employee
                        };
            return query;
        }
        public IQueryable SelectTicket(DateTime date)
        {
            Table<ex_ticket> ex = data.GetTable<ex_ticket>();
            Table<distributor> dis = data.GetTable<distributor>();
            Table<employee> em = data.GetTable<employee>();
            var query = from e in ex
                        join d in dis on e.id_distributor equals d.id_distributor
                        join f in em on e.id_write equals f.id_employee
                        join g in em on e.id_accountant equals g.id_employee
                        join h in em on e.id_shipper equals h.id_employee
                        join i in em on e.id_storager equals i.id_employee
                        where e.date_ex.Value.Equals(date)
                        select new
                        {
                            Số_chứng_từ = e.id_ex_ticket,
                            Nhà_nhập_khẩu = d.name_distributor,
                            Ngày_nhập = e.date_ex,
                            Kế_toán = g.name_employee,
                            Thủ_kho = i.name_employee,
                            Người_lập_phiếu = f.name_employee,
                            Người_nhận = h.name_employee
                        };
            return query;
        }
        public IQueryable SelectTicket(DateTime dateBegin,DateTime dateEnd)
        {
            Table<ex_ticket> ex = data.GetTable<ex_ticket>();
            Table<distributor> dis = data.GetTable<distributor>();
            Table<employee> em = data.GetTable<employee>();
            var query = from e in ex
                        join d in dis on e.id_distributor equals d.id_distributor
                        join f in em on e.id_write equals f.id_employee
                        join g in em on e.id_accountant equals g.id_employee
                        join h in em on e.id_shipper equals h.id_employee
                        join i in em on e.id_storager equals i.id_employee
                        where e.date_ex.Value.CompareTo(dateBegin)>=0 &&e.date_ex.Value.CompareTo(dateEnd)<=0
                        select new
                        {
                            Số_chứng_từ = e.id_ex_ticket,
                            Nhà_nhập_khẩu = d.name_distributor,
                            Ngày_nhập = e.date_ex,
                            Kế_toán = g.name_employee,
                            Thủ_kho = i.name_employee,
                            Người_lập_phiếu = f.name_employee,
                            Người_nhận = h.name_employee
                        };
            return query;
        }
        public IQueryable SelectTicket(int mounth)
        {
            Table<ex_ticket> ex = data.GetTable<ex_ticket>();
            Table<distributor> dis = data.GetTable<distributor>();
            Table<employee> em = data.GetTable<employee>();
            var query = from e in ex
                        join d in dis on e.id_distributor equals d.id_distributor
                        join f in em on e.id_write equals f.id_employee
                        join g in em on e.id_accountant equals g.id_employee
                        join h in em on e.id_shipper equals h.id_employee
                        join i in em on e.id_storager equals i.id_employee
                        where e.date_ex.Value.Month==mounth
                        select new
                        {
                            Số_chứng_từ = e.id_ex_ticket,
                            Nhà_nhập_khẩu = d.name_distributor,
                            Ngày_nhập = e.date_ex,
                            Kế_toán = g.name_employee,
                            Thủ_kho = i.name_employee,
                            Người_lập_phiếu = f.name_employee,
                            Người_nhận = h.name_employee
                        };
            return query;
        }
        public IQueryable SelectTicketDetail(int id)
        {
            Table<ex_ticket_detail> detail = data.GetTable<ex_ticket_detail>();
            Table<shipment> shipments = data.GetTable<shipment>();
            Table<item> items = data.GetTable<item>();

            var query = from d in detail
                        join s in shipments on d.id_shipment equals s.id_shipment
                        join i in items on s.id_item equals i.id_item
                        where d.id_ex_ticket == id
                        select new
                        {
                            Số_lô_hàng = s.id_shipment,
                            Tên_mặt_hàng = i.item_name,
                            Mã_hàng = i.id_item,
                            Ngày_SX = s.man_date,
                            Hạn_SD = s.exp_date,
                            Đơn_vị = s.unit,
                            Số_lượng = s.number,
                            Đơn_giá = s.ex_unit_price,
                            Thành_tiền = s.ex_unit_price * s.number
                        };
            return query;
        }

    }
}
