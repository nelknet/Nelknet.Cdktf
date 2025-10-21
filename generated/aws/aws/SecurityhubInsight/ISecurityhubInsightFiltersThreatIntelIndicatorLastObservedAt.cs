using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt")]
    public interface ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt
    {
        /// <summary>date_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#date_range SecurityhubInsight#date_range}
        /// </remarks>
        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAtDateRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAtDateRange? DateRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#end SecurityhubInsight#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? End
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#start SecurityhubInsight#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Start
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>date_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#date_range SecurityhubInsight#date_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAtDateRange\"}", isOptional: true)]
            public aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAtDateRange? DateRange
            {
                get => GetInstanceProperty<aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAtDateRange?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#end SecurityhubInsight#end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? End
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#start SecurityhubInsight#start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Start
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
