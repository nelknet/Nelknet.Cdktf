using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    [JsiiInterface(nativeType: typeof(IEvidentlyLaunchScheduledSplitsConfigSteps), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigSteps")]
    public interface IEvidentlyLaunchScheduledSplitsConfigSteps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#group_weights EvidentlyLaunch#group_weights}.</summary>
        [JsiiProperty(name: "groupWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, double> GroupWeights
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#start_time EvidentlyLaunch#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        string StartTime
        {
            get;
        }

        /// <summary>segment_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#segment_overrides EvidentlyLaunch#segment_overrides}
        /// </remarks>
        [JsiiProperty(name: "segmentOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SegmentOverrides
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyLaunchScheduledSplitsConfigSteps), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigSteps")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigSteps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#group_weights EvidentlyLaunch#group_weights}.</summary>
            [JsiiProperty(name: "groupWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, double> GroupWeights
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#start_time EvidentlyLaunch#start_time}.</summary>
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
            public string StartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>segment_overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#segment_overrides EvidentlyLaunch#segment_overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "segmentOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SegmentOverrides
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
