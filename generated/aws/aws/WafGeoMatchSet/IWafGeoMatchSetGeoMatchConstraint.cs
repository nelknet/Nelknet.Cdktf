using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafGeoMatchSet
{
    [JsiiInterface(nativeType: typeof(IWafGeoMatchSetGeoMatchConstraint), fullyQualifiedName: "aws.wafGeoMatchSet.WafGeoMatchSetGeoMatchConstraint")]
    public interface IWafGeoMatchSetGeoMatchConstraint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_geo_match_set#type WafGeoMatchSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_geo_match_set#value WafGeoMatchSet#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafGeoMatchSetGeoMatchConstraint), fullyQualifiedName: "aws.wafGeoMatchSet.WafGeoMatchSetGeoMatchConstraint")]
        internal sealed class _Proxy : DeputyBase, aws.WafGeoMatchSet.IWafGeoMatchSetGeoMatchConstraint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_geo_match_set#type WafGeoMatchSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_geo_match_set#value WafGeoMatchSet#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
