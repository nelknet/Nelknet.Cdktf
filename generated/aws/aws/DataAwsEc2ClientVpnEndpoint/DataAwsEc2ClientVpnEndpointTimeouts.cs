using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ClientVpnEndpoint
{
    [JsiiByValue(fqn: "aws.dataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointTimeouts")]
    public class DataAwsEc2ClientVpnEndpointTimeouts : aws.DataAwsEc2ClientVpnEndpoint.IDataAwsEc2ClientVpnEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_client_vpn_endpoint#read DataAwsEc2ClientVpnEndpoint#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
