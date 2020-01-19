using BullService.Models.Cow;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BullService.Models
{
    public class PictureModel
    {
        [Key]
        public Guid PictureId { get; set; }
        public CowMeasurementModel CowMeasurement { get; set; }
        public string PictureDescription { get; set; }

        public string[] PicturePaths { get; set; }
    }
}
