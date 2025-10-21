using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildFleet
{
    [JsiiByValue(fqn: "aws.codebuildFleet.CodebuildFleetScalingConfiguration")]
    public class CodebuildFleetScalingConfiguration : aws.CodebuildFleet.ICodebuildFleetScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#max_capacity CodebuildFleet#max_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#scaling_type CodebuildFleet#scaling_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScalingType
        {
            get;
            set;
        }

        private object? _targetTrackingScalingConfigs;

        /// <summary>target_tracking_scaling_configs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#target_tracking_scaling_configs CodebuildFleet#target_tracking_scaling_configs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingScalingConfigs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildFleet.CodebuildFleetScalingConfigurationTargetTrackingScalingConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetTrackingScalingConfigs
        {
            get => _targetTrackingScalingConfigs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CodebuildFleet.ICodebuildFleetScalingConfigurationTargetTrackingScalingConfigs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildFleet.ICodebuildFleetScalingConfigurationTargetTrackingScalingConfigs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetTrackingScalingConfigs = value;
            }
        }
    }
}
