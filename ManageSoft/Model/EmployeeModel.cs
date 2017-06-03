using ManageSoft.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoft.Model
{
    class EmployeeModel
    {
        DataDataContext data = new DataDataContext();
        public IQueryable SelectAllEmployee()
        {
            return from i in data.employees
                   select new
                   {
                       i.id_employee,
                       i.birth_date,
                       i.name_employee,
                       GioiTinh= i.sex==1?"Nam":"Nữ",
                       i.distributor.name_distributor
                   };
        }
        public int InsertEmployee(employee e)
        {
            try
            {
                data.employees.InsertOnSubmit(e);
                data.SubmitChanges();
            }
            catch (Exception ee)
            {
                throw ee;
            }
            return e.id_employee;
        }
        public void UpdateEmployee(employee e)
        {
            try
            {
                employee ee = data.employees.SingleOrDefault(x => x.id_employee == e.id_employee);
                ee.id_distributor = e.id_distributor;
                ee.sex = e.sex;
                ee.birth_date = e.birth_date;
                ee.name_employee = e.name_employee;
                data.SubmitChanges();
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }
        public void DeleteEmployee(int id)
        {
            try
            {
                data.employees.DeleteOnSubmit(data.employees.SingleOrDefault(c => c.id_employee == id));
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }
    }
}
