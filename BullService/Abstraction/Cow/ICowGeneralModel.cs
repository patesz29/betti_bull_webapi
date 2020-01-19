using System;

namespace BullService.Abstraction.Cow
{
    interface ICowGeneralModel
    {
        /// <summary>
        /// Ellés sorszáma (max 2 számjegy)
        /// </summary>
        int CalvingNumber { get; set; }
        /// <summary>
        /// Utolsó ellés dátuma
        /// </summary>
        DateTime LastCalvingDate { get; set; }
        /// <summary>
        /// Vemhességi napok száma (3karakter)
        /// </summary>
        int DaysOfGestations { get; set; }
        /// <summary>
        /// Előző termékenyítés dátuma
        /// </summary>
        DateTime LastFertilizationDate { get; set; }

        CourseOfCalvingEnum CourseOfCalving { get; set; }
        /// <summary>
        /// Zárt laktáció tejtermelése (tört szám 2 tizedessel)
        /// </summary>
        float ClosedLactationMilkProd { get; set; }
        /// <summary>
        /// Utolsó próbafejés eredménye
        /// </summary>
        float LastMilkingResult { get; set; }

        /// <summary>
        /// Kezelés
        /// </summary>
        int Treatment { get; set; }
        /// <summary>
        /// Borjú neme (1-hím, 2-nőstény)
        /// </summary>
        CalfSexEnum CalfSex { get; set; }

        int CalfWeight { get; set; }
    }
    /// <summary>
    /// Ellés lefolyása
    /// </summary>
    public enum CourseOfCalvingEnum //ToDo: Extend this with valid values
    {
        Gyors = 1
    }

    public enum CalfSexEnum
    {
        Male = 1,
        Female = 2
    }
}
