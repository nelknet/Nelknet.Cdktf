using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiInterface(nativeType: typeof(IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver")]
    public interface IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#entry_point EmrcontainersJobTemplate#entry_point}.</summary>
        [JsiiProperty(name: "entryPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EntryPoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_sql_parameters EmrcontainersJobTemplate#spark_sql_parameters}.</summary>
        [JsiiProperty(name: "sparkSqlParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SparkSqlParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver")]
        internal sealed class _Proxy : DeputyBase, aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#entry_point EmrcontainersJobTemplate#entry_point}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entryPoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EntryPoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_sql_parameters EmrcontainersJobTemplate#spark_sql_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sparkSqlParameters", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SparkSqlParameters
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
