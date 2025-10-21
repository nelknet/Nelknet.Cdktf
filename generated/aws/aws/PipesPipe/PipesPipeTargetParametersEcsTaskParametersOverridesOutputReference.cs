using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeTargetParametersEcsTaskParametersOverridesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeTargetParametersEcsTaskParametersOverridesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeTargetParametersEcsTaskParametersOverridesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeTargetParametersEcsTaskParametersOverridesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContainerOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContainerOverride(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEphemeralStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage\"}}]")]
        public virtual void PutEphemeralStorage(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInferenceAcceleratorOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInferenceAcceleratorOverride(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerOverride")]
        public virtual void ResetContainerOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpu")]
        public virtual void ResetCpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEphemeralStorage")]
        public virtual void ResetEphemeralStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionRoleArn")]
        public virtual void ResetExecutionRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInferenceAcceleratorOverride")]
        public virtual void ResetInferenceAcceleratorOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemory")]
        public virtual void ResetMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskRoleArn")]
        public virtual void ResetTaskRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "containerOverride", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideList\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideList ContainerOverride
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideList>()!;
        }

        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorageOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorageOutputReference EphemeralStorage
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorageOutputReference>()!;
        }

        [JsiiProperty(name: "inferenceAcceleratorOverride", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverrideList\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverrideList InferenceAcceleratorOverride
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverrideList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerOverrideInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContainerOverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ephemeralStorageInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage? EphemeralStorageInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inferenceAcceleratorOverrideInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InferenceAcceleratorOverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MemoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cpu
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Memory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverrides\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverrides? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverrides?>();
            set => SetInstanceProperty(value);
        }
    }
}
