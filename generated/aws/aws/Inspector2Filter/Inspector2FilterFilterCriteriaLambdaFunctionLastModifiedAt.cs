using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiByValue(fqn: "aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt")]
    public class Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt : aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#end_inclusive Inspector2Filter#end_inclusive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endInclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndInclusive
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#start_inclusive Inspector2Filter#start_inclusive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startInclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartInclusive
        {
            get;
            set;
        }
    }
}
