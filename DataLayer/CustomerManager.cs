using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;

namespace DataLayer
{
    public class CustomerManager : IDB<Customer, int>
    {
        public void Create(Customer item)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    context.Customers.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer Read(int key)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    return context.Customers.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Customer> ReadAll()
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    return context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Customer item)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    Customer customer = context.Customers.Find(item.Id);
                    context.Entry(customer).CurrentValues.SetValues(item);
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
                    Customer customer = context.Customers.Find(key);
                    context.Customers.Remove(customer);
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
