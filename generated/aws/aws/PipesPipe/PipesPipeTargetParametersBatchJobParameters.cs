using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters")]
    public class PipesPipeTargetParametersBatchJobParameters : aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#job_definition PipesPipe#job_definition}.</summary>
        [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public string JobDefinition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#job_name PipesPipe#job_name}.</summary>
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public string JobName
        {
            get;
            set;
        }

        /// <summary>array_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#array_properties PipesPipe#array_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "arrayProperties", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersArrayProperties\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties? ArrayProperties
        {
            get;
            set;
        }

        /// <summary>container_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#container_overrides PipesPipe#container_overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerOverrides", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverrides\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides? ContainerOverrides
        {
            get;
            set;
        }

        private object? _dependsOn;

        /// <summary>depends_on block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#depends_on PipesPipe#depends_on}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DependsOn
        {
            get => _dependsOn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersDependsOn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersDependsOn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dependsOn = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#parameters PipesPipe#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>retry_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#retry_strategy PipesPipe#retry_strategy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryStrategy", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategy\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy? RetryStrategy
        {
            get;
            set;
        }
    }
}
