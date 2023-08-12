using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public abstract class GenericService<T, V>
    {
        public abstract void Add(T entity);
        public abstract void DeleteById(object id);
        public abstract IEnumerable<T> GetAll();
        public abstract T GetById(object id);
        public abstract void Update(T entity);
        public abstract V Mapper(T entity);
        public abstract T Value (V entity);
    }
}
