using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionRetryStrategy), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionRetryStrategy")]
    public interface IBatchJobDefinitionRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#attempts BatchJobDefinition#attempts}.</summary>
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Attempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>evaluate_on_exit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#evaluate_on_exit BatchJobDefinition#evaluate_on_exit}
        /// </remarks>
        [JsiiProperty(name: "evaluateOnExit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EvaluateOnExit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionRetryStrategy), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionRetryStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#attempts BatchJobDefinition#attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Attempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>evaluate_on_exit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#evaluate_on_exit BatchJobDefinition#evaluate_on_exit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "evaluateOnExit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EvaluateOnExit
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
