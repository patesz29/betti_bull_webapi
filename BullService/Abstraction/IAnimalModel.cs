using System;
namespace BullService.Abstraction
{
    public interface IAnimalModel
    {
        /// <summary>
        /// EarNumber of the Bull or Cow
        /// </summary>
        int EarNumber { get; set; }
        /// <summary>
        /// ENAR number of the Bull or Cow
        /// </summary>
        int EnarNumber { get; set; }
        /// <summary>
        /// Date of Birth
        /// </summary>
        DateTime DateOfBirth { get; set; }
  
    }
}
