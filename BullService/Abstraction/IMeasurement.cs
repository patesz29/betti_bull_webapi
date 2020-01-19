using BullService.Models;
using System;
using System.Collections.Generic;

namespace BullService.Abstraction
{
    interface IMeasurement
    {
        /// <summary>
        /// Measurement Id
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// Mérés típusa
        /// </summary>
        MeasurementTypeEnum MeasurementType { get; }
        /// <summary>
        /// Mérés dátuma
        /// </summary>
        DateTime MeasurementDate { get; }
        /// <summary>
        /// Mérési képek
        /// </summary>
        ICollection<PictureModel> MeasurementPictures { get; }
        /// <summary>
        /// Body Condition Score (tört 2 tizedessel)
        /// </summary>
        float Bcs { get; }
        /// <summary>
        /// Vizsgálat surán talált elváltozás
        /// </summary>
        string Lesion { get; }
    }

    public enum MeasurementTypeEnum
    {
        SubclinicEndomentritis = 1
    }
}
