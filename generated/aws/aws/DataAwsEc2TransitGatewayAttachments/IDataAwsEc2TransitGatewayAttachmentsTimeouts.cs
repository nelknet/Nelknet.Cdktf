using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayAttachments
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2TransitGatewayAttachmentsTimeouts), fullyQualifiedName: "aws.dataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsTimeouts")]
    public interface IDataAwsEc2TransitGatewayAttachmentsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#read DataAwsEc2TransitGatewayAttachments#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2TransitGatewayAttachmentsTimeouts), fullyQualifiedName: "aws.dataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2TransitGatewayAttachments.IDataAwsEc2TransitGatewayAttachmentsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#read DataAwsEc2TransitGatewayAttachments#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
