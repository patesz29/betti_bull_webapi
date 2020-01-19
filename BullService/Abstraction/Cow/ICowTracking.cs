using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Abstraction.Cow
{
    public interface ICowTracking
    {
        /// <summary>
        /// 60.napi Vemhesség vizsgálat eredménye
        /// </summary>
        string PregnancyDetectionResult30Day { get; }
        /// <summary>
        /// 60.napi Vemhesség vizsgálat eredménye
        /// </summary>
        string PregnancyDetectionResult60Day { get; }
        /// <summary>
        /// Első sikeres megtermékenyítés dátuma
        /// </summary>
        DateTime FirstSuccessfulFertilizationDate { get; }
        /// <summary>
        /// Sikeres Termékenyítés sorszáma
        /// </summary>
        int SuccessfulFertilizationNumber { get; }
    }
}
