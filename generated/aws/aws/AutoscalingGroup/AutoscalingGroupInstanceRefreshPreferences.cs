using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences")]
    public class AutoscalingGroupInstanceRefreshPreferences : aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences
    {
        /// <summary>alarm_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#alarm_specification AutoscalingGroup#alarm_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alarmSpecification", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification? AlarmSpecification
        {
            get;
            set;
        }

        private object? _autoRollback;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#auto_rollback AutoscalingGroup#auto_rollback}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoRollback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoRollback
        {
            get => _autoRollback;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autoRollback = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#checkpoint_delay AutoscalingGroup#checkpoint_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "checkpointDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CheckpointDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#checkpoint_percentages AutoscalingGroup#checkpoint_percentages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "checkpointPercentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? CheckpointPercentages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_warmup AutoscalingGroup#instance_warmup}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceWarmup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceWarmup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_healthy_percentage AutoscalingGroup#max_healthy_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxHealthyPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinHealthyPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#scale_in_protected_instances AutoscalingGroup#scale_in_protected_instances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleInProtectedInstances", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleInProtectedInstances
        {
            get;
            set;
        }

        private object? _skipMatching;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#skip_matching AutoscalingGroup#skip_matching}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipMatching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SkipMatching
        {
            get => _skipMatching;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _skipMatching = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#standby_instances AutoscalingGroup#standby_instances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "standbyInstances", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StandbyInstances
        {
            get;
            set;
        }
    }
}
