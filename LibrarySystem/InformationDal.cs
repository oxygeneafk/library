using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class InformationDal
    {
        public List<Information> GetAll()
        {
            using (LibraryContext context = new LibraryContext())
            {
                return context.Informations.ToList();
            }
        }

        public List<Information> GetByName(string key)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Informations.Where(p => p.Name.Contains(key)).ToList();
                return context.Informations.Where(p => p.Name.Contains(key)).ToList();

            }
        }
        public void Add(Information information)
        {
            using (LibraryContext context = new LibraryContext())
            {
                //context.Products.Ad(information);
                var entity = context.Entry(information);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Information information)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(information);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Information information)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var entity = context.Entry(information);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
