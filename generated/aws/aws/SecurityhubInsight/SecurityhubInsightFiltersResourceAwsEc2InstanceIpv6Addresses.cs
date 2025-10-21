using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses")]
    public class SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses : aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#cidr SecurityhubInsight#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        public string Cidr
        {
            get;
            set;
        }
    }
}
