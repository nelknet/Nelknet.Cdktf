using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayMulticastDomain
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2TransitGatewayMulticastDomainTimeouts), fullyQualifiedName: "aws.dataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomainTimeouts")]
    public interface IDataAwsEc2TransitGatewayMulticastDomainTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#read DataAwsEc2TransitGatewayMulticastDomain#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2TransitGatewayMulticastDomainTimeouts), fullyQualifiedName: "aws.dataAwsEc2TransitGatewayMulticastDomain.DataAwsEc2TransitGatewayMulticastDomainTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2TransitGatewayMulticastDomain.IDataAwsEc2TransitGatewayMulticastDomainTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_multicast_domain#read DataAwsEc2TransitGatewayMulticastDomain#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
