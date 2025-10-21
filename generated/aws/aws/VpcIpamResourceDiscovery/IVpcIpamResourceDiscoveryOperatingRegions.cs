using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpamResourceDiscovery
{
    [JsiiInterface(nativeType: typeof(IVpcIpamResourceDiscoveryOperatingRegions), fullyQualifiedName: "aws.vpcIpamResourceDiscovery.VpcIpamResourceDiscoveryOperatingRegions")]
    public interface IVpcIpamResourceDiscoveryOperatingRegions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#region_name VpcIpamResourceDiscovery#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcIpamResourceDiscoveryOperatingRegions), fullyQualifiedName: "aws.vpcIpamResourceDiscovery.VpcIpamResourceDiscoveryOperatingRegions")]
        internal sealed class _Proxy : DeputyBase, aws.VpcIpamResourceDiscovery.IVpcIpamResourceDiscoveryOperatingRegions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_resource_discovery#region_name VpcIpamResourceDiscovery#region_name}.</summary>
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
