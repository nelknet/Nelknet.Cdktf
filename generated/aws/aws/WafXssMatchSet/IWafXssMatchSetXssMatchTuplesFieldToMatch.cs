using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafXssMatchSet
{
    [JsiiInterface(nativeType: typeof(IWafXssMatchSetXssMatchTuplesFieldToMatch), fullyQualifiedName: "aws.wafXssMatchSet.WafXssMatchSetXssMatchTuplesFieldToMatch")]
    public interface IWafXssMatchSetXssMatchTuplesFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#type WafXssMatchSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#data WafXssMatchSet#data}.</summary>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Data
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafXssMatchSetXssMatchTuplesFieldToMatch), fullyQualifiedName: "aws.wafXssMatchSet.WafXssMatchSetXssMatchTuplesFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.WafXssMatchSet.IWafXssMatchSetXssMatchTuplesFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#type WafXssMatchSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_xss_match_set#data WafXssMatchSet#data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Data
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
