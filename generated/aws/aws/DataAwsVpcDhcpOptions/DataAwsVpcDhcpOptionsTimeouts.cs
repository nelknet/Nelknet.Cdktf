using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcDhcpOptions
{
    [JsiiByValue(fqn: "aws.dataAwsVpcDhcpOptions.DataAwsVpcDhcpOptionsTimeouts")]
    public class DataAwsVpcDhcpOptionsTimeouts : aws.DataAwsVpcDhcpOptions.IDataAwsVpcDhcpOptionsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#read DataAwsVpcDhcpOptions#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
