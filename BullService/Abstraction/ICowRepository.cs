using BullService.Models;
using BullService.Models.Cow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Abstraction
{
    public interface ICowRepository
    {
        Task<IEnumerable<CowMeasurementModel>> GetMeasurements();
    }
}
