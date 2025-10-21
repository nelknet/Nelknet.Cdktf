using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightFiltersSourceUrl), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFiltersSourceUrl")]
    public interface ISecurityhubInsightFiltersSourceUrl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#comparison SecurityhubInsight#comparison}.</summary>
        [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
        string Comparison
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#value SecurityhubInsight#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightFiltersSourceUrl), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFiltersSourceUrl")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubInsight.ISecurityhubInsightFiltersSourceUrl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#comparison SecurityhubInsight#comparison}.</summary>
            [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
            public string Comparison
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#value SecurityhubInsight#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
