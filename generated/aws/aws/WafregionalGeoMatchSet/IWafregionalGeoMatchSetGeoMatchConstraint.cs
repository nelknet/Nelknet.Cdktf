using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalGeoMatchSet
{
    [JsiiInterface(nativeType: typeof(IWafregionalGeoMatchSetGeoMatchConstraint), fullyQualifiedName: "aws.wafregionalGeoMatchSet.WafregionalGeoMatchSetGeoMatchConstraint")]
    public interface IWafregionalGeoMatchSetGeoMatchConstraint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_geo_match_set#type WafregionalGeoMatchSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_geo_match_set#value WafregionalGeoMatchSet#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalGeoMatchSetGeoMatchConstraint), fullyQualifiedName: "aws.wafregionalGeoMatchSet.WafregionalGeoMatchSetGeoMatchConstraint")]
        internal sealed class _Proxy : DeputyBase, aws.WafregionalGeoMatchSet.IWafregionalGeoMatchSetGeoMatchConstraint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_geo_match_set#type WafregionalGeoMatchSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_geo_match_set#value WafregionalGeoMatchSet#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
