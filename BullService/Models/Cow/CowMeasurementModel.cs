using BullService.Abstraction;
using BullService.Abstraction.Cow;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BullService.Models.Cow
{
    public class CowMeasurementModel : ICowMeasurement, ICowTracking
    {
        [Key]
        public Guid Id { get; set; }

        public CowModel Cow { get; set; }
        public MeasurementTypeEnum MeasurementType { get; set; }

        public DateTime MeasurementDate { get; set; }

        public ICollection<PictureModel> MeasurementPictures { get; set; }

        public float Bcs { get; set; }

        public string Lesion { get; set; }

        public UterusStatusEnum UterusStatus { get ; set; }

        public float CervixDiameter { get ; set; }

        public float HornDiameter { get ; set; }

        public OvaryStateEnum RightOvaryState { get ; set; }

        public OvaryStateEnum LeftOvaryState { get ; set; }

        public int CitologyResultCervix { get ; set; }

        public int CitologyResultEndometrium { get ; set; }

        public float Nefa { get ; set; }

        public float Bhb { get ; set; }

        public float BetaKarotin { get ; set; }

        public QLazResultEnum QLazResult { get ; set; }

        public string PregnancyDetectionResult30Day { get; set; }

        public string PregnancyDetectionResult60Day { get; set; }

        public DateTime FirstSuccessfulFertilizationDate { get; set; }

        public int SuccessfulFertilizationNumber { get; set; }
    }
}
