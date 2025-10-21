using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGateway
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2TransitGatewayTimeouts), fullyQualifiedName: "aws.dataAwsEc2TransitGateway.DataAwsEc2TransitGatewayTimeouts")]
    public interface IDataAwsEc2TransitGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway#read DataAwsEc2TransitGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2TransitGatewayTimeouts), fullyQualifiedName: "aws.dataAwsEc2TransitGateway.DataAwsEc2TransitGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2TransitGateway.IDataAwsEc2TransitGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway#read DataAwsEc2TransitGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
