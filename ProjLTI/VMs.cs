using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLTI
{
    public class Metadata
    {
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class ImageList
    {
        public string id { get; set; }
        public List<Link> links { get; set; }
    }

    public class FlavorList
    {
        public string id { get; set; }
        public List<Link> links { get; set; }
    }

    public class Shared
    {
        public int version { get; set; }
        public string addr { get; set; }

        [JsonProperty("OS-EXT-IPS:type")]
        public string OSEXTIPSType { get; set; }

        [JsonProperty("OS-EXT-IPS-MAC:mac_addr")]
        public string OSEXTIPSMACMacAddr { get; set; }
    }

    public class Addresses
    {
        public List<Shared> shared { get; set; }
    }

    public class SecurityGroup
    {
        public string name { get; set; }
    }

    public class Server
    {
        public string id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string tenant_id { get; set; }
        public string user_id { get; set; }
        public Metadata metadata { get; set; }
        public string hostId { get; set; }
        public ImageList image { get; set; }
        public FlavorList flavor { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public Addresses addresses { get; set; }
        public string accessIPv4 { get; set; }
        public string accessIPv6 { get; set; }
        public List<Link> links { get; set; }

        [JsonProperty("OS-DCF:diskConfig")]
        public string OSDCFDiskConfig { get; set; }
        public int progress { get; set; }

        [JsonProperty("OS-EXT-AZ:availability_zone")]
        public string OSEXTAZAvailabilityZone { get; set; }
        public string config_drive { get; set; }
        public object key_name { get; set; }

        [JsonProperty("OS-SRV-USG:terminated_at")]
        public object OSSRVUSGTerminatedAt { get; set; }

        [JsonProperty("OS-EXT-STS:task_state")]
        public object OSEXTSTSTaskState { get; set; }

        [JsonProperty("OS-EXT-STS:vm_state")]
        public string OSEXTSTSVmState { get; set; }

        [JsonProperty("OS-EXT-STS:power_state")]
        public int OSEXTSTSPowerState { get; set; }

        [JsonProperty("os-extended-volumes:volumes_attached")]
        public List<object> OsExtendedVolumesVolumesAttached { get; set; }
        public List<SecurityGroup> security_groups { get; set; }
    }

    public class AllVirtualMachines
    {
        public List<Server> servers { get; set; }
    }
}
