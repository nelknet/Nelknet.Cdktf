using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeTargetParametersBatchJobParametersContainerOverridesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEnvironment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesEnvironment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnvironment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverridesEnvironment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverridesEnvironment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverridesEnvironment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceRequirement", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesResourceRequirement\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceRequirement(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverridesResourceRequirement[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverridesResourceRequirement).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverridesResourceRequirement).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCommand")]
        public virtual void ResetCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceRequirement")]
        public virtual void ResetResourceRequirement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesEnvironmentList\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesEnvironmentList Environment
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesEnvironmentList>()!;
        }

        [JsiiProperty(name: "resourceRequirement", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesResourceRequirementList\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesResourceRequirementList ResourceRequirement
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesResourceRequirementList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CommandInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvironmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceRequirementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverridesResourceRequirement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceRequirementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Command
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverrides\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides?>();
            set => SetInstanceProperty(value);
        }
    }
}
