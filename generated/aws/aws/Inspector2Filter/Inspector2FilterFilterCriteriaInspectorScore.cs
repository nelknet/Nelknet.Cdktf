using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.inspector2Filter.Inspector2FilterFilterCriteriaInspectorScore")]
    public class Inspector2FilterFilterCriteriaInspectorScore : aws.Inspector2Filter.IInspector2FilterFilterCriteriaInspectorScore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lower_inclusive Inspector2Filter#lower_inclusive}.</summary>
        [JsiiProperty(name: "lowerInclusive", typeJson: "{\"primitive\":\"number\"}")]
        public double LowerInclusive
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#upper_inclusive Inspector2Filter#upper_inclusive}.</summary>
        [JsiiProperty(name: "upperInclusive", typeJson: "{\"primitive\":\"number\"}")]
        public double UpperInclusive
        {
            get;
            set;
        }
    }
}
