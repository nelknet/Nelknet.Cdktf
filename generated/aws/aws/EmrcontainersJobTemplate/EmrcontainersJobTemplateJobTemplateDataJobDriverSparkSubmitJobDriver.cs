using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver")]
    public class EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver : aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#entry_point EmrcontainersJobTemplate#entry_point}.</summary>
        [JsiiProperty(name: "entryPoint", typeJson: "{\"primitive\":\"string\"}")]
        public string EntryPoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#entry_point_arguments EmrcontainersJobTemplate#entry_point_arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entryPointArguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? EntryPointArguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_submit_parameters EmrcontainersJobTemplate#spark_submit_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sparkSubmitParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SparkSubmitParameters
        {
            get;
            set;
        }
    }
}
