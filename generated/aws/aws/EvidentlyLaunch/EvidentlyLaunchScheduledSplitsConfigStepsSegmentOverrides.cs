using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides")]
    public class EvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides : aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#evaluation_order EvidentlyLaunch#evaluation_order}.</summary>
        [JsiiProperty(name: "evaluationOrder", typeJson: "{\"primitive\":\"number\"}")]
        public double EvaluationOrder
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#segment EvidentlyLaunch#segment}.</summary>
        [JsiiProperty(name: "segment", typeJson: "{\"primitive\":\"string\"}")]
        public string Segment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#weights EvidentlyLaunch#weights}.</summary>
        [JsiiProperty(name: "weights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, double> Weights
        {
            get;
            set;
        }
    }
}
