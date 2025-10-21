using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubInsight.SecurityhubInsightFiltersKeyword")]
    public class SecurityhubInsightFiltersKeyword : aws.SecurityhubInsight.ISecurityhubInsightFiltersKeyword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#value SecurityhubInsight#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
