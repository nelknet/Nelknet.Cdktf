using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchComputeEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchComputeEnvironment.BatchComputeEnvironmentUpdatePolicy")]
    public class BatchComputeEnvironmentUpdatePolicy : aws.BatchComputeEnvironment.IBatchComputeEnvironmentUpdatePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#job_execution_timeout_minutes BatchComputeEnvironment#job_execution_timeout_minutes}.</summary>
        [JsiiProperty(name: "jobExecutionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double JobExecutionTimeoutMinutes
        {
            get;
            set;
        }

        private object _terminateJobsOnUpdate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#terminate_jobs_on_update BatchComputeEnvironment#terminate_jobs_on_update}.</summary>
        [JsiiProperty(name: "terminateJobsOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object TerminateJobsOnUpdate
        {
            get => _terminateJobsOnUpdate;
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
                _terminateJobsOnUpdate = value;
            }
        }
    }
}
