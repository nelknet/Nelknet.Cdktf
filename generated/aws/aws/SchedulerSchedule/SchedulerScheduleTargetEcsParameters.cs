using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleTargetEcsParameters")]
    public class SchedulerScheduleTargetEcsParameters : aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#task_definition_arn SchedulerSchedule#task_definition_arn}.</summary>
        [JsiiProperty(name: "taskDefinitionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskDefinitionArn
        {
            get;
            set;
        }

        private object? _capacityProviderStrategy;

        /// <summary>capacity_provider_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#capacity_provider_strategy SchedulerSchedule#capacity_provider_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityProviderStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParametersCapacityProviderStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CapacityProviderStrategy
        {
            get => _capacityProviderStrategy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParametersCapacityProviderStrategy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParametersCapacityProviderStrategy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _capacityProviderStrategy = value;
            }
        }

        private object? _enableEcsManagedTags;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#enable_ecs_managed_tags SchedulerSchedule#enable_ecs_managed_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableEcsManagedTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableEcsManagedTags
        {
            get => _enableEcsManagedTags;
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
                _enableEcsManagedTags = value;
            }
        }

        private object? _enableExecuteCommand;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#enable_execute_command SchedulerSchedule#enable_execute_command}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableExecuteCommand", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableExecuteCommand
        {
            get => _enableExecuteCommand;
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
                _enableExecuteCommand = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#group SchedulerSchedule#group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#launch_type SchedulerSchedule#launch_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LaunchType
        {
            get;
            set;
        }

        /// <summary>network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#network_configuration SchedulerSchedule#network_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParametersNetworkConfiguration\"}", isOptional: true)]
        public aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParametersNetworkConfiguration? NetworkConfiguration
        {
            get;
            set;
        }

        private object? _placementConstraints;

        /// <summary>placement_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#placement_constraints SchedulerSchedule#placement_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementConstraints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParametersPlacementConstraints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PlacementConstraints
        {
            get => _placementConstraints;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParametersPlacementConstraints[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParametersPlacementConstraints).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _placementConstraints = value;
            }
        }

        private object? _placementStrategy;

        /// <summary>placement_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#placement_strategy SchedulerSchedule#placement_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementStrategy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetEcsParametersPlacementStrategy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PlacementStrategy
        {
            get => _placementStrategy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParametersPlacementStrategy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetEcsParametersPlacementStrategy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _placementStrategy = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#platform_version SchedulerSchedule#platform_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platformVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlatformVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#propagate_tags SchedulerSchedule#propagate_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PropagateTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#reference_id SchedulerSchedule#reference_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "referenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferenceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#tags SchedulerSchedule#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#task_count SchedulerSchedule#task_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TaskCount
        {
            get;
            set;
        }
    }
}
