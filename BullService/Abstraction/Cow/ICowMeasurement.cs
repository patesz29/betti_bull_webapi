using BullService.Models.Cow;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace BullService.Abstraction.Cow
{
    interface ICowMeasurement : IMeasurement
    {
        /// <summary>
        /// Méh állapota
        /// </summary>
        UterusStatusEnum UterusStatus { get; }
        /// <summary>
        /// Méhnyak átmérő
        /// </summary>
        float CervixDiameter { get; }
        /// <summary>
        /// Méhszarv átmérő
        /// </summary>
        float HornDiameter { get; }
        /// <summary>
        /// Jobb petefészek állapot
        /// </summary>
        OvaryStateEnum RightOvaryState { get; }
        /// <summary>
        /// Bal petefészek állapot
        /// </summary>
        OvaryStateEnum LeftOvaryState { get; }
        /// <summary>
        /// Citológia eredménye Méhnyak (%)
        /// </summary>
        int CitologyResultCervix { get; }

        /// <summary>
        /// Citológia eredménye Endometrium (%)
        /// </summary>
        int CitologyResultEndometrium { get; }
        float Nefa { get; }

        float Bhb { get; }

        float BetaKarotin { get; }

        QLazResultEnum QLazResult { get; }
    }

    public enum UterusStatusEnum
    {
        Normal = 0
    }

    public enum OvaryStateEnum
    {
        Normal = 0
    }
    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public enum QLazResultEnum
    {
        Positive,
        Negative
    }
}
