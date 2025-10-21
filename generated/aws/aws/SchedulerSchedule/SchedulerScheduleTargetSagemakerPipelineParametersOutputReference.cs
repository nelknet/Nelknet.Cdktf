using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiClass(nativeType: typeof(aws.SchedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersOutputReference), fullyQualifiedName: "aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SchedulerScheduleTargetSagemakerPipelineParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SchedulerScheduleTargetSagemakerPipelineParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SchedulerScheduleTargetSagemakerPipelineParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SchedulerScheduleTargetSagemakerPipelineParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPipelineParameter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPipelineParameter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPipelineParameter")]
        public virtual void ResetPipelineParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "pipelineParameter", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameterList\"}")]
        public virtual aws.SchedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameterList PipelineParameter
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineParameterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PipelineParameterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters\"}", isOptional: true)]
        public virtual aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters? InternalValue
        {
            get => GetInstanceProperty<aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
