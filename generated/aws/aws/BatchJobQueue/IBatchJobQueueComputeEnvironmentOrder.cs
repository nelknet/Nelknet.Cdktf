using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobQueue
{
    [JsiiInterface(nativeType: typeof(IBatchJobQueueComputeEnvironmentOrder), fullyQualifiedName: "aws.batchJobQueue.BatchJobQueueComputeEnvironmentOrder")]
    public interface IBatchJobQueueComputeEnvironmentOrder
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#compute_environment BatchJobQueue#compute_environment}.</summary>
        [JsiiProperty(name: "computeEnvironment", typeJson: "{\"primitive\":\"string\"}")]
        string ComputeEnvironment
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#order BatchJobQueue#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        double Order
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobQueueComputeEnvironmentOrder), fullyQualifiedName: "aws.batchJobQueue.BatchJobQueueComputeEnvironmentOrder")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobQueue.IBatchJobQueueComputeEnvironmentOrder
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#compute_environment BatchJobQueue#compute_environment}.</summary>
            [JsiiProperty(name: "computeEnvironment", typeJson: "{\"primitive\":\"string\"}")]
            public string ComputeEnvironment
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#order BatchJobQueue#order}.</summary>
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
            public double Order
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
