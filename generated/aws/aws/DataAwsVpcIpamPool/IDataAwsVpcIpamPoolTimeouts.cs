using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcIpamPool
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpcIpamPoolTimeouts), fullyQualifiedName: "aws.dataAwsVpcIpamPool.DataAwsVpcIpamPoolTimeouts")]
    public interface IDataAwsVpcIpamPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#read DataAwsVpcIpamPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpcIpamPoolTimeouts), fullyQualifiedName: "aws.dataAwsVpcIpamPool.DataAwsVpcIpamPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsVpcIpamPool.IDataAwsVpcIpamPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#read DataAwsVpcIpamPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
