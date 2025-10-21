using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Alb
{
    [JsiiInterface(nativeType: typeof(IAlbIpamPools), fullyQualifiedName: "aws.alb.AlbIpamPools")]
    public interface IAlbIpamPools
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#ipv4_ipam_pool_id Alb#ipv4_ipam_pool_id}.</summary>
        [JsiiProperty(name: "ipv4IpamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string Ipv4IpamPoolId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbIpamPools), fullyQualifiedName: "aws.alb.AlbIpamPools")]
        internal sealed class _Proxy : DeputyBase, aws.Alb.IAlbIpamPools
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#ipv4_ipam_pool_id Alb#ipv4_ipam_pool_id}.</summary>
            [JsiiProperty(name: "ipv4IpamPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string Ipv4IpamPoolId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
