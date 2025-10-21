using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcDhcpOptions
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsVpcDhcpOptions.DataAwsVpcDhcpOptionsFilter")]
    public class DataAwsVpcDhcpOptionsFilter : aws.DataAwsVpcDhcpOptions.IDataAwsVpcDhcpOptionsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#name DataAwsVpcDhcpOptions#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#values DataAwsVpcDhcpOptions#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
