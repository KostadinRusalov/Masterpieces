using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;

namespace DataLayer
{
    public class ProductOrderManager : IDB<ProductOrder, int>
    {
        public void Create(ProductOrder item)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    context.ProductOrders.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductOrder Read(int key)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    return context.ProductOrders.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ProductOrder> ReadAll()
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    return context.ProductOrders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(ProductOrder item)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    ProductOrder productOrderQuantity = context.ProductOrders.Find(item.Id);
                    context.Entry(productOrderQuantity).CurrentValues.SetValues(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    ProductOrder productOrderQuantity = context.ProductOrders.Find(key);
                    context.ProductOrders.Remove(productOrderQuantity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
