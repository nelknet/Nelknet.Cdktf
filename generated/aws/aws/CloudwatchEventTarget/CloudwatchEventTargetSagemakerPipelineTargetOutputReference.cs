using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetOutputReference), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventTargetSagemakerPipelineTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventTargetSagemakerPipelineTargetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchEventTargetSagemakerPipelineTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTargetSagemakerPipelineTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPipelineParameterList", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPipelineParameterList(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPipelineParameterList")]
        public virtual void ResetPipelineParameterList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "pipelineParameterList", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStructList\"}")]
        public virtual aws.CloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStructList PipelineParameterList
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStructList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineParameterListInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTargetPipelineParameterListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PipelineParameterListInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetSagemakerPipelineTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetSagemakerPipelineTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
