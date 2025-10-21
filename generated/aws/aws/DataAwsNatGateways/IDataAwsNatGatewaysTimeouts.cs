using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNatGateways
{
    [JsiiInterface(nativeType: typeof(IDataAwsNatGatewaysTimeouts), fullyQualifiedName: "aws.dataAwsNatGateways.DataAwsNatGatewaysTimeouts")]
    public interface IDataAwsNatGatewaysTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways#read DataAwsNatGateways#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNatGatewaysTimeouts), fullyQualifiedName: "aws.dataAwsNatGateways.DataAwsNatGatewaysTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNatGateways.IDataAwsNatGatewaysTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways#read DataAwsNatGateways#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
