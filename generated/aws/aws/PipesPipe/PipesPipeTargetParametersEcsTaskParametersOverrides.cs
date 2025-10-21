using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverrides")]
    public class PipesPipeTargetParametersEcsTaskParametersOverrides : aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverrides
    {
        private object? _containerOverride;

        /// <summary>container_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#container_override PipesPipe#container_override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ContainerOverride
        {
            get => _containerOverride;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _containerOverride = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cpu PipesPipe#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cpu
        {
            get;
            set;
        }

        /// <summary>ephemeral_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#ephemeral_storage PipesPipe#ephemeral_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage? EphemeralStorage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#execution_role_arn PipesPipe#execution_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutionRoleArn
        {
            get;
            set;
        }

        private object? _inferenceAcceleratorOverride;

        /// <summary>inference_accelerator_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#inference_accelerator_override PipesPipe#inference_accelerator_override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceAcceleratorOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InferenceAcceleratorOverride
        {
            get => _inferenceAcceleratorOverride;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inferenceAcceleratorOverride = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#memory PipesPipe#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#task_role_arn PipesPipe#task_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaskRoleArn
        {
            get;
            set;
        }
    }
}
