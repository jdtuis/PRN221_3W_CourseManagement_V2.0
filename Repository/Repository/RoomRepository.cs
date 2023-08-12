using Repository.Entities;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class RoomRepository: GenericRepository<Room>, IRoomRepository
    {
    }
}
