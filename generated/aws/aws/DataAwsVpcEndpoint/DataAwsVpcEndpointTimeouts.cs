using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcEndpoint
{
    [JsiiByValue(fqn: "aws.dataAwsVpcEndpoint.DataAwsVpcEndpointTimeouts")]
    public class DataAwsVpcEndpointTimeouts : aws.DataAwsVpcEndpoint.IDataAwsVpcEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#read DataAwsVpcEndpoint#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
