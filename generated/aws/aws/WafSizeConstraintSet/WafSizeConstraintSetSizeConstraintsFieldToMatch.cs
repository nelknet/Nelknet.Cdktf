using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafSizeConstraintSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafSizeConstraintSet.WafSizeConstraintSetSizeConstraintsFieldToMatch")]
    public class WafSizeConstraintSetSizeConstraintsFieldToMatch : aws.WafSizeConstraintSet.IWafSizeConstraintSetSizeConstraintsFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#type WafSizeConstraintSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_size_constraint_set#data WafSizeConstraintSet#data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Data
        {
            get;
            set;
        }
    }
}
