using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExit")]
    public class BatchJobDefinitionRetryStrategyEvaluateOnExit : aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategyEvaluateOnExit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#action BatchJobDefinition#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_exit_code BatchJobDefinition#on_exit_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onExitCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnExitCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_reason BatchJobDefinition#on_reason}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnReason
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_status_reason BatchJobDefinition#on_status_reason}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onStatusReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnStatusReason
        {
            get;
            set;
        }
    }
}
