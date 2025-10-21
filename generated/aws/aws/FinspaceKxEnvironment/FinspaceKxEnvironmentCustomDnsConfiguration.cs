using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxEnvironment.FinspaceKxEnvironmentCustomDnsConfiguration")]
    public class FinspaceKxEnvironmentCustomDnsConfiguration : aws.FinspaceKxEnvironment.IFinspaceKxEnvironmentCustomDnsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#custom_dns_server_ip FinspaceKxEnvironment#custom_dns_server_ip}.</summary>
        [JsiiProperty(name: "customDnsServerIp", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomDnsServerIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#custom_dns_server_name FinspaceKxEnvironment#custom_dns_server_name}.</summary>
        [JsiiProperty(name: "customDnsServerName", typeJson: "{\"primitive\":\"string\"}")]
        public string CustomDnsServerName
        {
            get;
            set;
        }
    }
}
