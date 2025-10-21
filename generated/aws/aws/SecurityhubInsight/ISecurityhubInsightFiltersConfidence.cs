using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightFiltersConfidence), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFiltersConfidence")]
    public interface ISecurityhubInsightFiltersConfidence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#eq SecurityhubInsight#eq}.</summary>
        [JsiiProperty(name: "eq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Eq
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#gte SecurityhubInsight#gte}.</summary>
        [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Gte
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#lte SecurityhubInsight#lte}.</summary>
        [JsiiProperty(name: "lte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Lte
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightFiltersConfidence), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFiltersConfidence")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubInsight.ISecurityhubInsightFiltersConfidence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#eq SecurityhubInsight#eq}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eq", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Eq
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#gte SecurityhubInsight#gte}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Gte
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#lte SecurityhubInsight#lte}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lte", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Lte
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
