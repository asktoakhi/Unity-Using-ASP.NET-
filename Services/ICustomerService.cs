﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Services
{
    public interface ICustomerService
    {
         List<Customer> GetCustomers();
        
    }
}
