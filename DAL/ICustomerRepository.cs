using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WebX.Common;

namespace DAL
{
    public interface ICustomerRepository
    {

       // DataTable Getdata();
       // object GetCustomer();

        List<Customer> GetCustomers();

    }
}
