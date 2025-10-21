using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpam
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpcIpam.VpcIpamOperatingRegions")]
    public class VpcIpamOperatingRegions : aws.VpcIpam.IVpcIpamOperatingRegions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#region_name VpcIpam#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        public string RegionName
        {
            get;
            set;
        }
    }
}
