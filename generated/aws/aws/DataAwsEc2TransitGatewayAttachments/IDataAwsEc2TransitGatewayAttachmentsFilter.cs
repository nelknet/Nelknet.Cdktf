using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2TransitGatewayAttachments
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2TransitGatewayAttachmentsFilter), fullyQualifiedName: "aws.dataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsFilter")]
    public interface IDataAwsEc2TransitGatewayAttachmentsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#name DataAwsEc2TransitGatewayAttachments#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#values DataAwsEc2TransitGatewayAttachments#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2TransitGatewayAttachmentsFilter), fullyQualifiedName: "aws.dataAwsEc2TransitGatewayAttachments.DataAwsEc2TransitGatewayAttachmentsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2TransitGatewayAttachments.IDataAwsEc2TransitGatewayAttachmentsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#name DataAwsEc2TransitGatewayAttachments#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_transit_gateway_attachments#values DataAwsEc2TransitGatewayAttachments#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
