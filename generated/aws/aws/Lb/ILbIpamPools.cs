using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lb
{
    [JsiiInterface(nativeType: typeof(ILbIpamPools), fullyQualifiedName: "aws.lb.LbIpamPools")]
    public interface ILbIpamPools
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#ipv4_ipam_pool_id Lb#ipv4_ipam_pool_id}.</summary>
        [JsiiProperty(name: "ipv4IpamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string Ipv4IpamPoolId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbIpamPools), fullyQualifiedName: "aws.lb.LbIpamPools")]
        internal sealed class _Proxy : DeputyBase, aws.Lb.ILbIpamPools
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#ipv4_ipam_pool_id Lb#ipv4_ipam_pool_id}.</summary>
            [JsiiProperty(name: "ipv4IpamPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string Ipv4IpamPoolId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
