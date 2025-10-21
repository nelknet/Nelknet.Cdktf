using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueJob
{
    [JsiiByValue(fqn: "aws.glueJob.GlueJobExecutionProperty")]
    public class GlueJobExecutionProperty : aws.GlueJob.IGlueJobExecutionProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#max_concurrent_runs GlueJob#max_concurrent_runs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentRuns
        {
            get;
            set;
        }
    }
}
