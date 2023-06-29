using System;
using System.Collections.Generic;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public static class CustomersManager
    {
        private static CustomerManager manager = new CustomerManager();

        public static void Create(Customer customer)
        {
            try
            { 
                manager.Create(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Customer Read(int key)
        {
            try
            {
                return manager.Read(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<Customer> ReadAll()
        {
            try
            {
                return manager.ReadAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(Customer customer)
        {
            try
            {
                manager.Update(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                manager.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
