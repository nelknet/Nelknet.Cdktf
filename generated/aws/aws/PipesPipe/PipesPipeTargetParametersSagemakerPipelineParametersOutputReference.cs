using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeTargetParametersSagemakerPipelineParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeTargetParametersSagemakerPipelineParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeTargetParametersSagemakerPipelineParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeTargetParametersSagemakerPipelineParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPipelineParameter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPipelineParameter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParametersPipelineParameter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParametersPipelineParameter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParametersPipelineParameter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPipelineParameter")]
        public virtual void ResetPipelineParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "pipelineParameter", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersPipelineParameterList\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersPipelineParameterList PipelineParameter
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersPipelineParameterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineParameterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PipelineParameterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersSagemakerPipelineParameters\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersSagemakerPipelineParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
