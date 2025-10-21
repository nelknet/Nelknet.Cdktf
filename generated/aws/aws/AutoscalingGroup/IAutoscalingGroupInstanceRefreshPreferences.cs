using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupInstanceRefreshPreferences), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences")]
    public interface IAutoscalingGroupInstanceRefreshPreferences
    {
        /// <summary>alarm_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#alarm_specification AutoscalingGroup#alarm_specification}
        /// </remarks>
        [JsiiProperty(name: "alarmSpecification", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification? AlarmSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#auto_rollback AutoscalingGroup#auto_rollback}.</summary>
        [JsiiProperty(name: "autoRollback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoRollback
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#checkpoint_delay AutoscalingGroup#checkpoint_delay}.</summary>
        [JsiiProperty(name: "checkpointDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CheckpointDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#checkpoint_percentages AutoscalingGroup#checkpoint_percentages}.</summary>
        [JsiiProperty(name: "checkpointPercentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? CheckpointPercentages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_warmup AutoscalingGroup#instance_warmup}.</summary>
        [JsiiProperty(name: "instanceWarmup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceWarmup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_healthy_percentage AutoscalingGroup#max_healthy_percentage}.</summary>
        [JsiiProperty(name: "maxHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxHealthyPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
        [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinHealthyPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#scale_in_protected_instances AutoscalingGroup#scale_in_protected_instances}.</summary>
        [JsiiProperty(name: "scaleInProtectedInstances", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleInProtectedInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#skip_matching AutoscalingGroup#skip_matching}.</summary>
        [JsiiProperty(name: "skipMatching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipMatching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#standby_instances AutoscalingGroup#standby_instances}.</summary>
        [JsiiProperty(name: "standbyInstances", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StandbyInstances
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupInstanceRefreshPreferences), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>alarm_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#alarm_specification AutoscalingGroup#alarm_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alarmSpecification", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification\"}", isOptional: true)]
            public aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification? AlarmSpecification
            {
                get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#auto_rollback AutoscalingGroup#auto_rollback}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoRollback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoRollback
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#checkpoint_delay AutoscalingGroup#checkpoint_delay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "checkpointDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CheckpointDelay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#checkpoint_percentages AutoscalingGroup#checkpoint_percentages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "checkpointPercentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? CheckpointPercentages
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_warmup AutoscalingGroup#instance_warmup}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceWarmup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceWarmup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_healthy_percentage AutoscalingGroup#max_healthy_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxHealthyPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinHealthyPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#scale_in_protected_instances AutoscalingGroup#scale_in_protected_instances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleInProtectedInstances", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleInProtectedInstances
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#skip_matching AutoscalingGroup#skip_matching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipMatching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipMatching
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#standby_instances AutoscalingGroup#standby_instances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "standbyInstances", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StandbyInstances
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
