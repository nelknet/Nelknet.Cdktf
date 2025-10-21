using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersOverrides), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverrides")]
    public interface IPipesPipeTargetParametersEcsTaskParametersOverrides
    {
        /// <summary>container_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#container_override PipesPipe#container_override}
        /// </remarks>
        [JsiiProperty(name: "containerOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContainerOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cpu PipesPipe#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cpu
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#ephemeral_storage PipesPipe#ephemeral_storage}
        /// </remarks>
        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage? EphemeralStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#execution_role_arn PipesPipe#execution_role_arn}.</summary>
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>inference_accelerator_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#inference_accelerator_override PipesPipe#inference_accelerator_override}
        /// </remarks>
        [JsiiProperty(name: "inferenceAcceleratorOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InferenceAcceleratorOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#memory PipesPipe#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Memory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#task_role_arn PipesPipe#task_role_arn}.</summary>
        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaskRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersOverrides), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverrides")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>container_override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#container_override PipesPipe#container_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ContainerOverride
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cpu PipesPipe#cpu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cpu
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ephemeral_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#ephemeral_storage PipesPipe#ephemeral_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage? EphemeralStorage
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#execution_role_arn PipesPipe#execution_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>inference_accelerator_override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#inference_accelerator_override PipesPipe#inference_accelerator_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceAcceleratorOverride", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesInferenceAcceleratorOverride\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InferenceAcceleratorOverride
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#memory PipesPipe#memory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Memory
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#task_role_arn PipesPipe#task_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaskRoleArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
