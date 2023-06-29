using System;
using System.Collections.Generic;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public static class ProductOrdersManager
    {
        private static ProductOrderManager manager = new ProductOrderManager();

        public static void Create(ProductOrder productOrder)
        {
            try
            {
                manager.Create(productOrder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ProductOrder Read(int key)
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

        public static IEnumerable<ProductOrder> ReadAll()
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

        public static void Update(ProductOrder productOrder)
        {
            try
            {
                manager.Update(productOrder);
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
