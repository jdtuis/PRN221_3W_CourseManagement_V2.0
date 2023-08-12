using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.IRepository;
using System;
namespace Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly CourseManagementContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(CourseManagementContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public GenericRepository()
        {
            _context = new CourseManagementContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void DeleteById(object id)
        {
            T entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                Save();
            }
        }

        public IEnumerable<T> GetAll()

        {
            return _dbSet.ToList();
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }
    }
}
