using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobQueue
{
    [JsiiInterface(nativeType: typeof(IBatchJobQueueJobStateTimeLimitAction), fullyQualifiedName: "aws.batchJobQueue.BatchJobQueueJobStateTimeLimitAction")]
    public interface IBatchJobQueueJobStateTimeLimitAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#action BatchJobQueue#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#max_time_seconds BatchJobQueue#max_time_seconds}.</summary>
        [JsiiProperty(name: "maxTimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double MaxTimeSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#reason BatchJobQueue#reason}.</summary>
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        string Reason
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#state BatchJobQueue#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        string State
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobQueueJobStateTimeLimitAction), fullyQualifiedName: "aws.batchJobQueue.BatchJobQueueJobStateTimeLimitAction")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobQueue.IBatchJobQueueJobStateTimeLimitAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#action BatchJobQueue#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#max_time_seconds BatchJobQueue#max_time_seconds}.</summary>
            [JsiiProperty(name: "maxTimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxTimeSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#reason BatchJobQueue#reason}.</summary>
            [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
            public string Reason
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_queue#state BatchJobQueue#state}.</summary>
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
            public string State
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
