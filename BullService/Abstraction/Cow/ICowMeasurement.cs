using BullService.Models.Cow;

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

    public enum QLazResultEnum
    {
        Positive = 0,
        Negative = 1
    }
}
