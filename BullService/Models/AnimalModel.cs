using BullService.Abstraction;
using System;
using System.ComponentModel.DataAnnotations;

namespace BullService.Models
{
    public class AnimalModel : IAnimalModel
    {
        [Key]
        public string Id
        {
            get => Id; set => string.Concat(EnarNumber, "-", EarNumber);
        }
        public int EarNumber { get; set; }
        public int EnarNumber { get; set; }
        /// <summary>
        /// Telep
        /// </summary>
        public SiteEnum Site { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public enum SiteEnum
    {
        UnDefined = 0,
        Telep1 = 1,
        Telep2 = 2,
        Telep3 = 3,
        Telep4 = 4,
        Telep5 = 5,
        Telep6 = 6,
        Telep7 = 7,
        Telep8 = 8,
        Telep9 = 9,
        Telep10 = 10
    }
}
