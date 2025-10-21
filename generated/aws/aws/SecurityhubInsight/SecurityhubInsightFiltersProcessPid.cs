using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiByValue(fqn: "aws.securityhubInsight.SecurityhubInsightFiltersProcessPid")]
    public class SecurityhubInsightFiltersProcessPid : aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPid
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#eq SecurityhubInsight#eq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Eq
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#gte SecurityhubInsight#gte}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Gte
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#lte SecurityhubInsight#lte}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Lte
        {
            get;
            set;
        }
    }
}
