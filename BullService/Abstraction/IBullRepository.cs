using BullService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Abstraction
{
    public interface IBullRepository
    {
        Task<IOperationResult<IEnumerable<BaseModel>>> GetBulls();
    }
}
