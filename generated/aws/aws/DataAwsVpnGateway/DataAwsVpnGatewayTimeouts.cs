using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpnGateway
{
    [JsiiByValue(fqn: "aws.dataAwsVpnGateway.DataAwsVpnGatewayTimeouts")]
    public class DataAwsVpnGatewayTimeouts : aws.DataAwsVpnGateway.IDataAwsVpnGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpn_gateway#read DataAwsVpnGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
