using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Services
{
    public class iCustomerService : ICustomerService
    {
        private ICustomerRepository _iCustomerRepository;

        public iCustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }

        // public List<Customer> GetCustomers()
        //{
        //    return _iCustomerRepository.GetCustomers();
        //}

     public   List<Customer> GetCustomers()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            return customerRepository.GetCustomers();
        }
    }
}
