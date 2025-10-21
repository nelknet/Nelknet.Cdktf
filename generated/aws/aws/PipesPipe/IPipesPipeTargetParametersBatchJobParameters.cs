using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersBatchJobParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters")]
    public interface IPipesPipeTargetParametersBatchJobParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#job_definition PipesPipe#job_definition}.</summary>
        [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
        string JobDefinition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#job_name PipesPipe#job_name}.</summary>
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        string JobName
        {
            get;
        }

        /// <summary>array_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#array_properties PipesPipe#array_properties}
        /// </remarks>
        [JsiiProperty(name: "arrayProperties", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersArrayProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties? ArrayProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>container_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#container_overrides PipesPipe#container_overrides}
        /// </remarks>
        [JsiiProperty(name: "containerOverrides", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverrides\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides? ContainerOverrides
        {
            get
            {
                return null;
            }
        }

        /// <summary>depends_on block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#depends_on PipesPipe#depends_on}
        /// </remarks>
        [JsiiProperty(name: "dependsOn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DependsOn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#parameters PipesPipe#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_strategy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#retry_strategy PipesPipe#retry_strategy}
        /// </remarks>
        [JsiiProperty(name: "retryStrategy", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy? RetryStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersBatchJobParameters), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersBatchJobParameters")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersBatchJobParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#job_definition PipesPipe#job_definition}.</summary>
            [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
            public string JobDefinition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#job_name PipesPipe#job_name}.</summary>
            [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
            public string JobName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>array_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#array_properties PipesPipe#array_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "arrayProperties", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersArrayProperties\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties? ArrayProperties
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersArrayProperties?>();
            }

            /// <summary>container_overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#container_overrides PipesPipe#container_overrides}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerOverrides", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersContainerOverrides\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides? ContainerOverrides
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersContainerOverrides?>();
            }

            /// <summary>depends_on block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#depends_on PipesPipe#depends_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersDependsOn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DependsOn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#parameters PipesPipe#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>retry_strategy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#retry_strategy PipesPipe#retry_strategy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryStrategy", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersBatchJobParametersRetryStrategy\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy? RetryStrategy
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersBatchJobParametersRetryStrategy?>();
            }
        }
    }
}
