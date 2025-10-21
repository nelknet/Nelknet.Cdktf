using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiByValue(fqn: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver")]
    public class EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver : aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#entry_point EmrcontainersJobTemplate#entry_point}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entryPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntryPoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_sql_parameters EmrcontainersJobTemplate#spark_sql_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sparkSqlParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SparkSqlParameters
        {
            get;
            set;
        }
    }
}
