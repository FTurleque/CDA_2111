using System.ComponentModel;

namespace TrouveEmploi.Lib
{
    public enum Levels
    {
        [Description("InfBac")]
        InfBac = 30,
        [Description("Bac")]
        Bac = 40,
        [Description("Bac +1")]
        BacPlus1 = 50,
        [Description("Bac +2")]
        BacPlus2 = 60,
        [Description("Bac +3")]
        BacPlus3 = 70,
        [Description("Bac +4")]
        BacPlus4 = 80,
        [Description("Bac +5")]
        BacPlus5 = 90,
        [Description("SupBac +5")]
        SupBacPlus5 = 100
    }
}
