using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNatGateway
{
    [JsiiByValue(fqn: "aws.dataAwsNatGateway.DataAwsNatGatewayTimeouts")]
    public class DataAwsNatGatewayTimeouts : aws.DataAwsNatGateway.IDataAwsNatGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateway#read DataAwsNatGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
