using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BullService.Models.Cow
{
    public static class Extensions
    {
        internal static void Update(this CowMeasurementModel instance, CowMeasurementModel model)
        {            
            instance.Bcs = model.Bcs;
            instance.BetaKarotin = model.BetaKarotin;
            instance.Bhb = model.Bhb;
            instance.CervixDiameter = model.CervixDiameter;
            instance.CitologyResultCervix = model.CitologyResultCervix;
            instance.CitologyResultEndometrium = model.CitologyResultEndometrium;
            instance.CowId = model.CowId;
            instance.FirstSuccessfulFertilizationDate = model.FirstSuccessfulFertilizationDate;
            instance.HornDiameter = model.HornDiameter;
            instance.LeftOvaryState = model.LeftOvaryState;
            instance.Lesion = model.Lesion;
            instance.MeasurementDate = model.MeasurementDate;
            instance.MeasurementType = model.MeasurementType;
            instance.Nefa = model.Nefa;
            instance.PregnancyDetectionResult30Day = model.PregnancyDetectionResult30Day;
            instance.PregnancyDetectionResult60Day = model.PregnancyDetectionResult60Day;
            instance.QLazResult = model.QLazResult;
            instance.RightOvaryState = model.RightOvaryState;
            instance.SuccessfulFertilizationNumber = model.SuccessfulFertilizationNumber;
            instance.UterusStatus = model.UterusStatus;
        }

        internal static void Update(this CowModel instance, CowModel model)
        {
            instance.CalfSex = model.CalfSex;
            instance.CalfWeight = model.CalfWeight;
            instance.CalvingNumber = model.CalvingNumber;
            instance.ClosedLactationMilkProd = model.ClosedLactationMilkProd;
            instance.CourseOfCalving = model.CourseOfCalving;
            instance.DateOfBirth = model.DateOfBirth;
            instance.DaysOfGestations = model.DaysOfGestations;
            instance.EarNumber = model.EarNumber;
            instance.EnarNumber = model.EnarNumber;
            instance.LastCalvingDate = model.LastCalvingDate;
            instance.LastFertilizationDate = model.LastFertilizationDate;
            instance.LastMilkingResult = model.LastMilkingResult;
            instance.Site = model.Site;
            instance.Treatment = model.Treatment;
        }
    }
}
