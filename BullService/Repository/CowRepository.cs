using BullService.Abstraction;
using BullService.Filters;
using BullService.Models;
using BullService.Models.Cow;
using BullService.Models.DbContexts;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public Task<IEnumerable<CowMeasurementModel>> GetMeasurements(CowMeasurementFilter filter)
        {
            IEnumerable<CowMeasurementModel> cows = _cowContext.CowMeasurements.OrderBy(x=>x.MeasurementDate);

            //Add filtering
            var pb = PredicateBuilder.New<CowMeasurementModel>().DefaultExpression = (p=>true);

            pb = filter?.Bcs?.CheckAndBuild(pb) ?? pb;
            pb = filter?.BetaKarotin?.CheckAndBuild(pb) ?? pb;
            pb = filter?.Bhb?.CheckAndBuild(pb) ?? pb;
            pb = filter?.CervixDiameter?.CheckAndBuild(pb) ?? pb;
            pb = filter?.CitologyResultCervix?.CheckAndBuild(pb) ?? pb;
            pb = filter?.CitologyResultEndometrium?.CheckAndBuild(pb) ?? pb;
            pb = filter?.HornDiameter?.CheckAndBuild(pb) ?? pb;
            pb = filter?.Nefa?.CheckAndBuild(pb) ?? pb;
            pb = filter?.SuccessfulFertilizationNumber?.CheckAndBuild(pb) ?? pb;


            var filteredMeasurements = _cowContext.CowMeasurements.AsExpandable().Where(pb.Compile()).AsEnumerable();



            return Task.FromResult(filteredMeasurements as IEnumerable<CowMeasurementModel>);
        }
    }
}
