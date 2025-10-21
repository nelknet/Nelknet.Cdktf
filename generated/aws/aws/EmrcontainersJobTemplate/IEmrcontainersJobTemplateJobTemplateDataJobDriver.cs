using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiInterface(nativeType: typeof(IEmrcontainersJobTemplateJobTemplateDataJobDriver), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriver")]
    public interface IEmrcontainersJobTemplateJobTemplateDataJobDriver
    {
        /// <summary>spark_sql_job_driver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_sql_job_driver EmrcontainersJobTemplate#spark_sql_job_driver}
        /// </remarks>
        [JsiiProperty(name: "sparkSqlJobDriver", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver? SparkSqlJobDriver
        {
            get
            {
                return null;
            }
        }

        /// <summary>spark_submit_job_driver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_submit_job_driver EmrcontainersJobTemplate#spark_submit_job_driver}
        /// </remarks>
        [JsiiProperty(name: "sparkSubmitJobDriver", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver? SparkSubmitJobDriver
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrcontainersJobTemplateJobTemplateDataJobDriver), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriver")]
        internal sealed class _Proxy : DeputyBase, aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>spark_sql_job_driver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_sql_job_driver EmrcontainersJobTemplate#spark_sql_job_driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sparkSqlJobDriver", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver\"}", isOptional: true)]
            public aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver? SparkSqlJobDriver
            {
                get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSqlJobDriver?>();
            }

            /// <summary>spark_submit_job_driver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#spark_submit_job_driver EmrcontainersJobTemplate#spark_submit_job_driver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sparkSubmitJobDriver", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver\"}", isOptional: true)]
            public aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver? SparkSubmitJobDriver
            {
                get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataJobDriverSparkSubmitJobDriver?>();
            }
        }
    }
}
