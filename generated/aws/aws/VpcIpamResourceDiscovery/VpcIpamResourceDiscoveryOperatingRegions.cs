using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpamResourceDiscovery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpcIpamResourceDiscovery.VpcIpamResourceDiscoveryOperatingRegions")]
    public class VpcIpamResourceDiscoveryOperatingRegions : aws.VpcIpamResourceDiscovery.IVpcIpamResourceDiscoveryOperatingRegions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#region_name VpcIpamResourceDiscovery#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        public string RegionName
        {
            get;
            set;
        }
    }
}
