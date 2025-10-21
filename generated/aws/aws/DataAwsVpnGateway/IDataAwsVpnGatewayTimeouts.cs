using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpnGateway
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpnGatewayTimeouts), fullyQualifiedName: "aws.dataAwsVpnGateway.DataAwsVpnGatewayTimeouts")]
    public interface IDataAwsVpnGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#read DataAwsVpnGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpnGatewayTimeouts), fullyQualifiedName: "aws.dataAwsVpnGateway.DataAwsVpnGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsVpnGateway.IDataAwsVpnGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#read DataAwsVpnGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
