using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcDhcpOptions
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpcDhcpOptionsTimeouts), fullyQualifiedName: "aws.dataAwsVpcDhcpOptions.DataAwsVpcDhcpOptionsTimeouts")]
    public interface IDataAwsVpcDhcpOptionsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#read DataAwsVpcDhcpOptions#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpcDhcpOptionsTimeouts), fullyQualifiedName: "aws.dataAwsVpcDhcpOptions.DataAwsVpcDhcpOptionsTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsVpcDhcpOptions.IDataAwsVpcDhcpOptionsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#read DataAwsVpcDhcpOptions#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
