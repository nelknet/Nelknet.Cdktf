using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SchedulerSchedule
{
    [JsiiByValue(fqn: "aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParameters")]
    public class SchedulerScheduleTargetSagemakerPipelineParameters : aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParameters
    {
        private object? _pipelineParameter;

        /// <summary>pipeline_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/scheduler_schedule#pipeline_parameter SchedulerSchedule#pipeline_parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.schedulerSchedule.SchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PipelineParameter
        {
            get => _pipelineParameter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SchedulerSchedule.ISchedulerScheduleTargetSagemakerPipelineParametersPipelineParameter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pipelineParameter = value;
            }
        }
    }
}
