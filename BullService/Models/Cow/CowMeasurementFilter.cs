using BullService.Abstraction;
using BullService.Abstraction.Cow;
using BullService.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel.DataAnnotations;

namespace BullService.Models.Cow
{
    public class CowMeasurementFilter
    {
        #region MeasurementTypeFilter
        public MeasurementTypeEnum? MeasurementTypeFilter { get; set; }
        #endregion

        #region MeasurementDateFilter
        public DateTime? MeasurementDateFilterFrom { get; set; }
        public DateTime? MeasurementDateFilterTo { get; set; }
        #endregion

        #region BcsFilter
        public BcsFilter Bcs { get; set; }
        #endregion

        #region LesionFilter
        public string Lesion { get; set; }
        #endregion

        #region UterusStatusFilter
        public UterusStatusEnum[] UterusStatusFilter { get; set; }
        #endregion

        #region CervixDiameterFilter
        public CervixDiameterFilter CervixDiameter { get; set; }
        #endregion

        #region HornDiameterFilter
        public HornDiameterFilter HornDiameter { get; set; }
        #endregion

        #region RightOvaryStateFilter
        public OvaryStateEnum[] RightOvaryStateFilter { get; set; }
        #endregion

        #region LeftOvaryStateFilter
        public OvaryStateEnum[] LeftOvaryStateFilter { get; set; }
        #endregion

        #region CitologyResultCervixFilter
        public CitologyResultCervixFilter CitologyResultCervix { get; set; }
        #endregion

        #region CitologyResultEndometriumFilter
        public CitologyResultEndometriumFilter CitologyResultEndometrium { get; set; }
        #endregion

        #region NefaFilter
        public NefaFilter Nefa { get; set; }
        #endregion

        #region BhbFilter
        public BhbFilter Bhb { get; set; }
        #endregion

        #region BetaKarotinFilter
        public BetaKarotinFilter BetaKarotin { get; set; }
        #endregion

        #region QLazResultFilter
        [JsonConverter(typeof(StringEnumConverter))]
        public QLazResultEnum QLazResultFilter { get; set; }
        #endregion

        #region PregnancyDetectionResult30DayFilter
        public string PregnancyDetectionResult30DayFilter { get; set; }
        #endregion

        #region PregnancyDetectionResult60DayFilter
        public string PregnancyDetectionResult60DayFilter { get; set; }
        #endregion

        #region FirstSuccessfulFertilizationDateFilter
        public DateTime? FirstSuccessfulFertilizationDateFilterFrom { get; set; }
        public DateTime? FirstSuccessfulFertilizationDateFilterTo { get; set; }
        #endregion

        #region SuccessfulFertilizationNumberFilter
        public SuccessfulFertilizationNumberFilter SuccessfulFertilizationNumber { get; set; }
        #endregion
    }
}
