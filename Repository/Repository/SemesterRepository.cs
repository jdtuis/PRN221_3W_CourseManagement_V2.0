using Repository.Entities;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class SemesterRepository : GenericRepository<Semester>, ISemesterRepository
    {
    }
}
