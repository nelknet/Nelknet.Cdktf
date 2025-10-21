using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionRetryStrategy")]
    public class BatchJobDefinitionRetryStrategy : aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#attempts BatchJobDefinition#attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Attempts
        {
            get;
            set;
        }

        private object? _evaluateOnExit;

        /// <summary>evaluate_on_exit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#evaluate_on_exit BatchJobDefinition#evaluate_on_exit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evaluateOnExit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EvaluateOnExit
        {
            get => _evaluateOnExit;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategyEvaluateOnExit[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategyEvaluateOnExit).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _evaluateOnExit = value;
            }
        }
    }
}
