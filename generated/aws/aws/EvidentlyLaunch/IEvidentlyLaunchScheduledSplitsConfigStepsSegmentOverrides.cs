using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    [JsiiInterface(nativeType: typeof(IEvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides")]
    public interface IEvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#evaluation_order EvidentlyLaunch#evaluation_order}.</summary>
        [JsiiProperty(name: "evaluationOrder", typeJson: "{\"primitive\":\"number\"}")]
        double EvaluationOrder
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#segment EvidentlyLaunch#segment}.</summary>
        [JsiiProperty(name: "segment", typeJson: "{\"primitive\":\"string\"}")]
        string Segment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#weights EvidentlyLaunch#weights}.</summary>
        [JsiiProperty(name: "weights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, double> Weights
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#evaluation_order EvidentlyLaunch#evaluation_order}.</summary>
            [JsiiProperty(name: "evaluationOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double EvaluationOrder
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#segment EvidentlyLaunch#segment}.</summary>
            [JsiiProperty(name: "segment", typeJson: "{\"primitive\":\"string\"}")]
            public string Segment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#weights EvidentlyLaunch#weights}.</summary>
            [JsiiProperty(name: "weights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, double> Weights
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>>()!;
            }
        }
    }
}
