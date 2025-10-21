using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigSteps")]
    public class EvidentlyLaunchScheduledSplitsConfigSteps : aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigSteps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#group_weights EvidentlyLaunch#group_weights}.</summary>
        [JsiiProperty(name: "groupWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, double> GroupWeights
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#start_time EvidentlyLaunch#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public string StartTime
        {
            get;
            set;
        }

        private object? _segmentOverrides;

        /// <summary>segment_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#segment_overrides EvidentlyLaunch#segment_overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "segmentOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SegmentOverrides
        {
            get => _segmentOverrides;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigStepsSegmentOverrides).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _segmentOverrides = value;
            }
        }
    }
}
