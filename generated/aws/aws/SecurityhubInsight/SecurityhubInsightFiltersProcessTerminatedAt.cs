using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiByValue(fqn: "aws.securityhubInsight.SecurityhubInsightFiltersProcessTerminatedAt")]
    public class SecurityhubInsightFiltersProcessTerminatedAt : aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessTerminatedAt
    {
        /// <summary>date_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#date_range SecurityhubInsight#date_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessTerminatedAtDateRange\"}", isOptional: true)]
        public aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessTerminatedAtDateRange? DateRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#end SecurityhubInsight#end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#start SecurityhubInsight#start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Start
        {
            get;
            set;
        }
    }
}
