using System;
using System.Collections.Generic;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public static class MasterpiecesManager
    {
        private static MasterpieceManager manager = new MasterpieceManager();

        public static void Create(Masterpiece masterpiece)
        {
            try
            {
                manager.Create(masterpiece);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Masterpiece Read(int key)
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

        public static IEnumerable<Masterpiece> ReadAll()
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

        public static void Update(Masterpiece masterpiece)
        {
            try
            {
                manager.Update(masterpiece);
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
