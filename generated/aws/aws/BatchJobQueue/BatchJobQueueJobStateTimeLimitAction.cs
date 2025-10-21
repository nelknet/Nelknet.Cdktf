using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobQueue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchJobQueue.BatchJobQueueJobStateTimeLimitAction")]
    public class BatchJobQueueJobStateTimeLimitAction : aws.BatchJobQueue.IBatchJobQueueJobStateTimeLimitAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#action BatchJobQueue#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#max_time_seconds BatchJobQueue#max_time_seconds}.</summary>
        [JsiiProperty(name: "maxTimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxTimeSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#reason BatchJobQueue#reason}.</summary>
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public string Reason
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#state BatchJobQueue#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public string State
        {
            get;
            set;
        }
    }
}
