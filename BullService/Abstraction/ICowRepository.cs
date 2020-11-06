using BullService.Models.Cow;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BullService.Abstraction
{
    public interface ICowRepository
    {
        
        Task<IEnumerable<CowMeasurementModel>> GetMeasurements(CowMeasurementFilter filter, bool addCowInfo);

        Task<IOperationResult<CowMeasurementModel>> CreateOrUpdateMeasurement(CowMeasurementModel model);

        Task<IEnumerable<CowModel>> GetCows();

        Task<IOperationResult<CowModel>> CreateOrUpdateCow(CowModel model);
    }
}
