using FitnessApp.BOL;
using FitnessApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BLL
{
    public class CustomerBL
    {

        public Customer AddCustomer(Customer objCustomerBo)
        {
            return new CustomerDAL().AddCustomer(objCustomerBo);
        }

        public Customer UpdateCustomer(Customer objCustomerBo)
        {
            return new CustomerDAL().CustomerUpdate(objCustomerBo);
        }


        public List<Customer> ShowCustomer()
        {
            return new CustomerDAL().ShowCustomers();
        }
        public Customer GetCustomer(int id)
        {
            return new CustomerDAL().GetCustomer(id);
        }
        public int CustomerLoginBL(Customer objCustomerBo)
        {
            return new CustomerDAL().CustomerLogin(objCustomerBo);
        }
        public bool CustomerSignupBL(Customer objCustomerBo)
        {
            return new CustomerDAL().CustomerSignup(objCustomerBo);
        }
        public System.Data.DataTable GetAllCustomersBL(Customer objCustomerBo)
        {
            return new CustomerDAL().GetCustomers(objCustomerBo);
        }
        public System.Data.DataTable SearchTrainer(string searchedtext)
        {
            return new CustomerDAL().SearchTrainers(searchedtext);
        }
    }
}
