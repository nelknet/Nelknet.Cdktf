using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNatGateway
{
    [JsiiInterface(nativeType: typeof(IDataAwsNatGatewayTimeouts), fullyQualifiedName: "aws.dataAwsNatGateway.DataAwsNatGatewayTimeouts")]
    public interface IDataAwsNatGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#read DataAwsNatGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNatGatewayTimeouts), fullyQualifiedName: "aws.dataAwsNatGateway.DataAwsNatGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNatGateway.IDataAwsNatGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#read DataAwsNatGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
