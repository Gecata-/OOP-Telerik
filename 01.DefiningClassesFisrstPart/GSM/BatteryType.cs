namespace GSM
{
    using System.ComponentModel;

    public enum BatteryType
    {
        NiMH,
        LiPo,
        NiCd,       
        [Description("Li-Ion")]
        LiIon
    }
}
