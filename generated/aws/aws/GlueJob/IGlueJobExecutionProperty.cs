using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueJob
{
    [JsiiInterface(nativeType: typeof(IGlueJobExecutionProperty), fullyQualifiedName: "aws.glueJob.GlueJobExecutionProperty")]
    public interface IGlueJobExecutionProperty
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#max_concurrent_runs GlueJob#max_concurrent_runs}.</summary>
        [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentRuns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueJobExecutionProperty), fullyQualifiedName: "aws.glueJob.GlueJobExecutionProperty")]
        internal sealed class _Proxy : DeputyBase, aws.GlueJob.IGlueJobExecutionProperty
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#max_concurrent_runs GlueJob#max_concurrent_runs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentRuns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentRuns
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
