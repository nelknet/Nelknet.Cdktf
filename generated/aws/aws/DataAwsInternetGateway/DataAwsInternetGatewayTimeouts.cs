using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsInternetGateway
{
    [JsiiByValue(fqn: "aws.dataAwsInternetGateway.DataAwsInternetGatewayTimeouts")]
    public class DataAwsInternetGatewayTimeouts : aws.DataAwsInternetGateway.IDataAwsInternetGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway#read DataAwsInternetGateway#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
