using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionTimeout), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionTimeout")]
    public interface IBatchJobDefinitionTimeout
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#attempt_duration_seconds BatchJobDefinition#attempt_duration_seconds}.</summary>
        [JsiiProperty(name: "attemptDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AttemptDurationSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionTimeout), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobDefinition.IBatchJobDefinitionTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#attempt_duration_seconds BatchJobDefinition#attempt_duration_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attemptDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AttemptDurationSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
