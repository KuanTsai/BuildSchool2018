using BizDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BizDataLibrary.Repositories
{
    public class BizRepository<T> where T : class
    {
        private BizModel _context;

        public BizRepository(BizModel context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            _context = context;
        }

        public void Create(T value)
        {
            _context.Entry(value).State = EntityState.Added;
        }

        public void Update(T value)
        {
            _context.Entry(value).State = EntityState.Modified;
        }

        public void Delete(T value)
        {
            _context.Entry(value).State = EntityState.Deleted;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

    }
}
