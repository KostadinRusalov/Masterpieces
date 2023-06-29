using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;

namespace DataLayer
{
    public class MasterpieceManager : IDB<Masterpiece, int>
    {
        public void Create(Masterpiece item)
        {
            try
            {
                using(MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    context.Masterpieces.Add(item);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Masterpiece Read(int key)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    return context.Masterpieces.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Masterpiece> ReadAll()
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    return context.Masterpieces.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Masterpiece item)
        {
            try
            {
                using (MasterpieceDbContext context = new MasterpieceDbContext())
                {
                    Masterpiece masterpiece = context.Masterpieces.Find(item.Id);
                    context.Entry(masterpiece).CurrentValues.SetValues(item);
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
                    Masterpiece masterpiece = context.Masterpieces.Find(key);
                    context.Masterpieces.Remove(masterpiece);
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
