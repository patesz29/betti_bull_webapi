using BullService.Abstraction;
using BullService.Models;
using BullService.Models.Cow;
using BullService.Models.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Repository
{
    public class CowRepository : ICowRepository
    {
        private CowDbContext _cowContext;
        public CowRepository(CowDbContext cowContext)
        {
            _cowContext = cowContext;
        }
        public Task<IEnumerable<CowMeasurementModel>> GetMeasurements()
        {
            IEnumerable<CowMeasurementModel> cows = _cowContext.CowMeasurements.OrderBy(x=>x.MeasurementDate);
            return Task.FromResult(cows);
        }
    }
}
