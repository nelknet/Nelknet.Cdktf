using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesOutputReference), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupInstanceRefreshPreferencesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupInstanceRefreshPreferencesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceRefreshPreferencesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceRefreshPreferencesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAlarmSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification\"}}]")]
        public virtual void PutAlarmSpecification(aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlarmSpecification")]
        public virtual void ResetAlarmSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoRollback")]
        public virtual void ResetAutoRollback()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCheckpointDelay")]
        public virtual void ResetCheckpointDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCheckpointPercentages")]
        public virtual void ResetCheckpointPercentages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceWarmup")]
        public virtual void ResetInstanceWarmup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxHealthyPercentage")]
        public virtual void ResetMaxHealthyPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinHealthyPercentage")]
        public virtual void ResetMinHealthyPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleInProtectedInstances")]
        public virtual void ResetScaleInProtectedInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipMatching")]
        public virtual void ResetSkipMatching()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStandbyInstances")]
        public virtual void ResetStandbyInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "alarmSpecification", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecificationOutputReference\"}")]
        public virtual aws.AutoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecificationOutputReference AlarmSpecification
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferencesAlarmSpecification\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification? AlarmSpecificationInput
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferencesAlarmSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoRollbackInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkpointDelayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CheckpointDelayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkpointPercentagesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? CheckpointPercentagesInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceWarmupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceWarmupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxHealthyPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxHealthyPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minHealthyPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinHealthyPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInProtectedInstancesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleInProtectedInstancesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipMatchingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SkipMatchingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "standbyInstancesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StandbyInstancesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoRollback", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoRollback
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "checkpointDelay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckpointDelay
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "checkpointPercentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] CheckpointPercentages
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceWarmup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceWarmup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxHealthyPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinHealthyPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleInProtectedInstances", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleInProtectedInstances
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skipMatching", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SkipMatching
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "standbyInstances", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StandbyInstances
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences? InternalValue
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences?>();
            set => SetInstanceProperty(value);
        }
    }
}
