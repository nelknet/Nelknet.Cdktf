using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2LocalGatewayVirtualInterfaceGroups
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2LocalGatewayVirtualInterfaceGroupsTimeouts), fullyQualifiedName: "aws.dataAwsEc2LocalGatewayVirtualInterfaceGroups.DataAwsEc2LocalGatewayVirtualInterfaceGroupsTimeouts")]
    public interface IDataAwsEc2LocalGatewayVirtualInterfaceGroupsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_groups#read DataAwsEc2LocalGatewayVirtualInterfaceGroups#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2LocalGatewayVirtualInterfaceGroupsTimeouts), fullyQualifiedName: "aws.dataAwsEc2LocalGatewayVirtualInterfaceGroups.DataAwsEc2LocalGatewayVirtualInterfaceGroupsTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2LocalGatewayVirtualInterfaceGroups.IDataAwsEc2LocalGatewayVirtualInterfaceGroupsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_local_gateway_virtual_interface_groups#read DataAwsEc2LocalGatewayVirtualInterfaceGroups#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
