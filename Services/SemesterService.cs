using Repository.Entities;
using Repository.IRepository;
using Repository.Repository;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SemesterService : GenericService<SemesterVM, Semester>
    {
        protected readonly ISemesterRepository repository;

        public SemesterService(SemesterRepository repository)
        {
            this.repository = repository;
        }

        public override void Add(SemesterVM entity)
        {
            
        }

        public override void DeleteById(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<SemesterVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public override SemesterVM GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override Semester Mapper(SemesterVM entity)
        {
            return new Semester()
            {

            };
        }

        public override void Update(SemesterVM entity)
        {
            throw new NotImplementedException();
        }

        public override SemesterVM Value(Semester entity)
        {
            throw new NotImplementedException();
        }
    }
}
