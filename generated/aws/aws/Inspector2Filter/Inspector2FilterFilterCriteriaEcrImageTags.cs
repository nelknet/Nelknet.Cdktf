using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTags")]
    public class Inspector2FilterFilterCriteriaEcrImageTags : aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#comparison Inspector2Filter#comparison}.</summary>
        [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
        public string Comparison
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#value Inspector2Filter#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
