using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpam
{
    [JsiiInterface(nativeType: typeof(IVpcIpamOperatingRegions), fullyQualifiedName: "aws.vpcIpam.VpcIpamOperatingRegions")]
    public interface IVpcIpamOperatingRegions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#region_name VpcIpam#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcIpamOperatingRegions), fullyQualifiedName: "aws.vpcIpam.VpcIpamOperatingRegions")]
        internal sealed class _Proxy : DeputyBase, aws.VpcIpam.IVpcIpamOperatingRegions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam#region_name VpcIpam#region_name}.</summary>
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
