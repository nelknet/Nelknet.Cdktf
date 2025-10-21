using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiByValue(fqn: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriver")]
    public class EmrcontainersJobTemplateJobTemplateDataJobDriver : aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriver
    {
        /// <summary>spark_sql_job_driver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_sql_job_driver EmrcontainersJobTemplate#spark_sql_job_driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sparkSqlJobDriver", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver\"}", isOptional: true)]
        public aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver? SparkSqlJobDriver
        {
            get;
            set;
        }

        /// <summary>spark_submit_job_driver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_submit_job_driver EmrcontainersJobTemplate#spark_submit_job_driver}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sparkSubmitJobDriver", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver\"}", isOptional: true)]
        public aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver? SparkSubmitJobDriver
        {
            get;
            set;
        }
    }
}
