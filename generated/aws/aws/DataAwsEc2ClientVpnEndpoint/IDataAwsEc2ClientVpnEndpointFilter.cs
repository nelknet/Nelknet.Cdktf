using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ClientVpnEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2ClientVpnEndpointFilter), fullyQualifiedName: "aws.dataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointFilter")]
    public interface IDataAwsEc2ClientVpnEndpointFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#name DataAwsEc2ClientVpnEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#values DataAwsEc2ClientVpnEndpoint#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2ClientVpnEndpointFilter), fullyQualifiedName: "aws.dataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2ClientVpnEndpoint.IDataAwsEc2ClientVpnEndpointFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#name DataAwsEc2ClientVpnEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#values DataAwsEc2ClientVpnEndpoint#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
