using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ClientVpnEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointFilter")]
    public class DataAwsEc2ClientVpnEndpointFilter : aws.DataAwsEc2ClientVpnEndpoint.IDataAwsEc2ClientVpnEndpointFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#name DataAwsEc2ClientVpnEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#values DataAwsEc2ClientVpnEndpoint#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
