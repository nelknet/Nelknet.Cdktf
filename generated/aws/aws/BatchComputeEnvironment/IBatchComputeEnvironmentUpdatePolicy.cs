using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchComputeEnvironment
{
    [JsiiInterface(nativeType: typeof(IBatchComputeEnvironmentUpdatePolicy), fullyQualifiedName: "aws.batchComputeEnvironment.BatchComputeEnvironmentUpdatePolicy")]
    public interface IBatchComputeEnvironmentUpdatePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#job_execution_timeout_minutes BatchComputeEnvironment#job_execution_timeout_minutes}.</summary>
        [JsiiProperty(name: "jobExecutionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double JobExecutionTimeoutMinutes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#terminate_jobs_on_update BatchComputeEnvironment#terminate_jobs_on_update}.</summary>
        [JsiiProperty(name: "terminateJobsOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object TerminateJobsOnUpdate
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchComputeEnvironmentUpdatePolicy), fullyQualifiedName: "aws.batchComputeEnvironment.BatchComputeEnvironmentUpdatePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.BatchComputeEnvironment.IBatchComputeEnvironmentUpdatePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#job_execution_timeout_minutes BatchComputeEnvironment#job_execution_timeout_minutes}.</summary>
            [JsiiProperty(name: "jobExecutionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double JobExecutionTimeoutMinutes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#terminate_jobs_on_update BatchComputeEnvironment#terminate_jobs_on_update}.</summary>
            [JsiiProperty(name: "terminateJobsOnUpdate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object TerminateJobsOnUpdate
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
