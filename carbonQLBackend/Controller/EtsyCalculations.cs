/// https://www.etsy.com/codeascraft/cloud-jewels-estimating-kwh-in-the-cloud/
/// https://github.com/etsy/cloud-jewels
namespace carbonQLBackend;

public class EtsyCalculations
{
    public decimal CalculateServerEmissions(int cpuHours)
    {
        /// Calculate the server emissions
        /// 2.10 Watt hours per vCPU hours
        decimal conversionfactor = 2.10M;
        EtsyModels.VCPUHours = cpuHours;
        /// output is in Watthours
        decimal emissions = conversionfactor * EtsyModels.VCPUHours;
        return emissions;
    }

    public decimal CalculateSSDStorageEmissions (int  terrabytehours)
    {
        /// Calculate the SSD Storage emissions
        /// 0.89 Watt hours per TB hours
        decimal conversionfactor = 0.89M;
        EtsyModels.SSDTerrabytehours = terrabytehours;
        /// output is in Watthours
        decimal emissions = conversionfactor * EtsyModels.SSDTerrabytehours;
        return emissions;
    }

    public decimal CalculateHDDStorageEmissions (int  terrabytehours)
    {
        /// Calculate the HDD Storage emissions
        /// 1.52 Watt hours per TB hours
        decimal conversionfactor = 1.52M;
        EtsyModels.HDDTerrabytehours = terrabytehours;
        /// output is in Watthours
        decimal emissions = conversionfactor * EtsyModels.HDDTerrabytehours;
        return emissions;
    }

}