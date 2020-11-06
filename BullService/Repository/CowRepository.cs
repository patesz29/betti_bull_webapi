using BullService.Abstraction;
using BullService.Helpers;
using BullService.Models.Cow;
using BullService.Models.DbContexts;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Repository
{
    public class CowRepository : ICowRepository
    {
        private readonly CowDbContext _cowContext;
        public CowRepository(CowDbContext cowContext)
        {
            _cowContext = cowContext;
        }


        public Task<IEnumerable<CowMeasurementModel>> GetMeasurements(CowMeasurementFilter filter, bool addCowInfo)
        {
            var set = addCowInfo ? _cowContext.CowMeasurements.AsExpandable() : _cowContext.CowMeasurements.Include(x=>x.Cow).AsExpandable();
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

            var filteredMeasurements = set.Where(pb.Compile()).AsEnumerable();

            return Task.FromResult(filteredMeasurements as IEnumerable<CowMeasurementModel>);
        }


        public async Task<IOperationResult<CowMeasurementModel>> CreateOrUpdateMeasurement(CowMeasurementModel model)
        {
            var measurement = _cowContext.CowMeasurements.FirstOrDefault(x => x.Id == model.Id);
            if (measurement == null)
                _cowContext.CowMeasurements.Add(model);

            else
            {
                measurement.Update(model);
                _cowContext.CowMeasurements.Update(measurement);
            }
            if (await _cowContext.SaveChangesAsync() > 0)
            {
                return new OperationResult<CowMeasurementModel>(true,model);
            }
            return new OperationResult<CowMeasurementModel>(false, null);
        }

        public Task<IEnumerable<CowModel>> GetCows()
        {
            var set = _cowContext.Cows.AsEnumerable();
            
            return Task.FromResult(set);
        }

        public async Task<IOperationResult<CowModel>> CreateOrUpdateCow(CowModel model)
        {
            model.Id = string.Concat(model.EnarNumber, "-", model.EarNumber);
            var cow = _cowContext.Cows.FirstOrDefault(x => x.Id == model.Id);
            if (cow == null)
                _cowContext.Cows.Add(model);
            else
            {
                cow.Update(model);
                _cowContext.Cows.Update(cow);
            }
            if (await _cowContext.SaveChangesAsync() > 0)
            {
                return new OperationResult<CowModel>(true, model);
            }
            return new OperationResult<CowModel>(false, null);
        }
    }
}
