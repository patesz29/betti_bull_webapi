using BullService.Abstraction;
using BullService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Repository
{
    public class BullRepository : IBullRepository
    {
        public Task<IEnumerable<BaseModel>> GetBulls()
        {
            throw new NotImplementedException();
        }
    }
}
