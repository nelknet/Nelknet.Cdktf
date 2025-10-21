using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNatGateways
{
    [JsiiByValue(fqn: "aws.dataAwsNatGateways.DataAwsNatGatewaysTimeouts")]
    public class DataAwsNatGatewaysTimeouts : aws.DataAwsNatGateways.IDataAwsNatGatewaysTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/nat_gateways#read DataAwsNatGateways#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
