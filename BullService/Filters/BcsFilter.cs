using BullService.Models.Cow;
using LinqKit;

namespace BullService.Filters
{
    #region FloatFilters
    public class BcsFilter : FloatFilter
    {
        public override string Name { get; set; } = "Bcs";
    }
    public class CervixDiameterFilter : FloatFilter
    {
        public override string Name { get; set; } = "CervixDiameter";
    }
    public class HornDiameterFilter : FloatFilter
    {
        public override string Name { get; set; } = "HornDiameter";
    }
    public class NefaFilter : FloatFilter
    {
        public override string Name { get; set; } = "Nefa";
    }
    public class BhbFilter : FloatFilter
    {
        public override string Name { get; set; } = "Bhb";
    }
    public class BetaKarotinFilter : FloatFilter
    {
        public override string Name { get; set; } = "BetaKarotin";
    }

    public abstract class FloatFilter
    {
        public virtual string Name { get; set; }
        public float? Equal { get; set; }
        public float? HigherThan { get; set; }
        public float? LowerThan { get; set; }
        public virtual ExpressionStarter<CowMeasurementModel> CheckAndBuild(ExpressionStarter<CowMeasurementModel> pb)
        {
            if (Equal != null)
                pb = pb.And(p => (float)(p.GetType().GetProperty(Name).GetValue(p)) == Equal);
            if (HigherThan != null)
                pb = pb.And(p => (float)(p.GetType().GetProperty(Name).GetValue(p)) >= HigherThan);
            if (LowerThan != null)
                pb = pb.And(p => (float)(p.GetType().GetProperty(Name).GetValue(p)) <= LowerThan);
            
            return pb;
        }
    }
    #endregion

    #region IntFilters
    public class CitologyResultCervixFilter : IntFilter
    {
        public override string Name { get; set; } = "CitologyResultCervix";
    }
    public class CitologyResultEndometriumFilter : IntFilter
    {
        public override string Name { get; set; } = "CitologyResultEndometrium";
    }
    public class SuccessfulFertilizationNumberFilter : IntFilter
    {
        public override string Name { get; set; } = "SuccessfulFertilizationNumber";
    }

    public abstract class IntFilter : IBaseFilter
    {
        public virtual string Name { get; set; }
        public int? Equal { get; set; }
        public int? HigherThan { get; set; }
        public int? LowerThan { get; set; }
        public virtual ExpressionStarter<CowMeasurementModel> CheckAndBuild(ExpressionStarter<CowMeasurementModel> pb)
        {
            if (Equal != null)
                pb = pb.And(p => (int)p.GetType().GetProperty(Name).GetValue(p) == Equal);
            if (HigherThan != null)
                pb = pb.And(p => (int)p.GetType().GetProperty(Name).GetValue(p) >= HigherThan);
            if (LowerThan != null)
                pb = pb.And(p => (int)p.GetType().GetProperty(Name).GetValue(p) <= LowerThan);
            
            return pb;
        }
    }

    public interface IBaseFilter
    {
        string Name { get; set; }
    }
    #endregion
}
