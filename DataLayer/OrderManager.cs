using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;

namespace DataLayer
{
    public class OrderManager : IDB<Order, int>
    {
        public void Create(Order item)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    context.Orders.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Order Read(int key)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    return context.Orders.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Order> ReadAll()
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    return context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Order item)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    Order order = context.Orders.Find(item.Id);
                    context.Entry(order).CurrentValues.SetValues(item);
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
                    Order order = context.Orders.Find(key);
                    context.Orders.Remove(order);
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
