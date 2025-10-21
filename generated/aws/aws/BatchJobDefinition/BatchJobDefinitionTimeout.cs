using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionTimeout")]
    public class BatchJobDefinitionTimeout : aws.BatchJobDefinition.IBatchJobDefinitionTimeout
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#attempt_duration_seconds BatchJobDefinition#attempt_duration_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attemptDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AttemptDurationSeconds
        {
            get;
            set;
        }
    }
}
