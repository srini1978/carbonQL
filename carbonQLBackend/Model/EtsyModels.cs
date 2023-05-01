/// Etsy model gives the cloud power used primarily in GCP environment
/// Based on energy used by CPUs, SSD, HDDs
// In Scope
// Out of scope - RAM and Networking
namespace carbonQLBackend;

public static class  EtsyModels
{
    public static int VCPUHours { get; set; }
    
    public static int HDDTerrabytehours { get; set; }

    public static int SSDTerrabytehours { get; set; }
}
