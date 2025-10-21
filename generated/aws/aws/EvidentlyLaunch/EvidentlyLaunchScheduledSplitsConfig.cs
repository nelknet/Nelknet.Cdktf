using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfig")]
    public class EvidentlyLaunchScheduledSplitsConfig : aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfig
    {
        private object _steps;

        /// <summary>steps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#steps EvidentlyLaunch#steps}
        /// </remarks>
        [JsiiProperty(name: "steps", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchScheduledSplitsConfigSteps\"},\"kind\":\"array\"}}]}}")]
        public object Steps
        {
            get => _steps;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigSteps[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigSteps).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EvidentlyLaunch.IEvidentlyLaunchScheduledSplitsConfigSteps).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _steps = value;
            }
        }
    }
}
