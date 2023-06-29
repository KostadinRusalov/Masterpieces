using System;
using System.Collections.Generic;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public static class OrdersManager
    {
        private static OrderManager manager = new OrderManager();

        public static void Create(Order order)
        {
            try
            {
                manager.Create(order);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Order Read(int key)
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

        public static IEnumerable<Order> ReadAll()
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

        public static void Update(Order order)
        {
            try
            {
                manager.Update(order);
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
