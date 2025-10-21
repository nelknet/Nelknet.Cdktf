using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobQueue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchJobQueue.BatchJobQueueComputeEnvironmentOrder")]
    public class BatchJobQueueComputeEnvironmentOrder : aws.BatchJobQueue.IBatchJobQueueComputeEnvironmentOrder
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#compute_environment BatchJobQueue#compute_environment}.</summary>
        [JsiiProperty(name: "computeEnvironment", typeJson: "{\"primitive\":\"string\"}")]
        public string ComputeEnvironment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#order BatchJobQueue#order}.</summary>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public double Order
        {
            get;
            set;
        }
    }
}
