using System;
using System.Collections.Generic;

namespace CodeQuality.E3_Functions
{
    public class CustomerRegistry
    {
        private List<Customer> CustomerList { get; set; } = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            CustomerList.Add(customer);

            GenerateAccountForCustomer(customer);

            UpdateCustomerStatistics(customer);

            SendWelComeEmailToCustomer(customer);

        }

        private void GenerateAccountForCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        private void UpdateCustomerStatistics(Customer customer)
        {
            throw new NotImplementedException();
        }

        private void SendWelComeEmailToCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}

