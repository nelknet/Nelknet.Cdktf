using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRange")]
    public class Inspector2FilterFilterCriteriaPortRange : aws.Inspector2Filter.IInspector2FilterFilterCriteriaPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#begin_inclusive Inspector2Filter#begin_inclusive}.</summary>
        [JsiiProperty(name: "beginInclusive", typeJson: "{\"primitive\":\"number\"}")]
        public double BeginInclusive
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#end_inclusive Inspector2Filter#end_inclusive}.</summary>
        [JsiiProperty(name: "endInclusive", typeJson: "{\"primitive\":\"number\"}")]
        public double EndInclusive
        {
            get;
            set;
        }
    }
}
