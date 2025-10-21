using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeTargetParametersBatchJobParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeTargetParametersBatchJobParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeTargetParametersBatchJobParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeTargetParametersBatchJobParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putArrayProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersArrayProperties\"}}]")]
        public virtual void PutArrayProperties(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContainerOverrides", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverrides\"}}]")]
        public virtual void PutContainerOverrides(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDependsOn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDependsOn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersDependsOn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersDependsOn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersDependsOn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryStrategy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategy\"}}]")]
        public virtual void PutRetryStrategy(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArrayProperties")]
        public virtual void ResetArrayProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerOverrides")]
        public virtual void ResetContainerOverrides()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDependsOn")]
        public virtual void ResetDependsOn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryStrategy")]
        public virtual void ResetRetryStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "arrayProperties", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersArrayPropertiesOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersArrayPropertiesOutputReference ArrayProperties
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersArrayPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "containerOverrides", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference ContainerOverrides
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference>()!;
        }

        [JsiiProperty(name: "dependsOn", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOnList\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOnList DependsOn
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOnList>()!;
        }

        [JsiiProperty(name: "retryStrategy", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategyOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategyOutputReference RetryStrategy
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arrayPropertiesInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersArrayProperties\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties? ArrayPropertiesInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerOverridesInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverrides\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides? ContainerOverridesInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dependsOnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DependsOnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryStrategyInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategy\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy? RetryStrategyInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy?>();
        }

        [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
