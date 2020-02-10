using BullService.Abstraction.Cow;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BullService.Models.Cow
{
    public class CowModel : AnimalModel, ICowGeneralModel
    {
        public int CalvingNumber { get ; set; }
        public DateTime LastCalvingDate { get ; set; }
        public int DaysOfGestations { get ; set; }
        public DateTime LastFertilizationDate { get ; set; }
        public CourseOfCalvingEnum CourseOfCalving { get ; set; }
        public float ClosedLactationMilkProd { get ; set; }
        public float LastMilkingResult { get ; set; }
        public int Treatment { get ; set; }
        public CalfSexEnum CalfSex { get ; set; }
        public int CalfWeight { get ; set; }

 
    }
}
