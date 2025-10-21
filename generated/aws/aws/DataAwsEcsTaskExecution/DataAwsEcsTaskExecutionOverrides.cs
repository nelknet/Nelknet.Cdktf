using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcsTaskExecution
{
    [JsiiByValue(fqn: "aws.dataAwsEcsTaskExecution.DataAwsEcsTaskExecutionOverrides")]
    public class DataAwsEcsTaskExecutionOverrides : aws.DataAwsEcsTaskExecution.IDataAwsEcsTaskExecutionOverrides
    {
        private object? _containerOverrides;

        /// <summary>container_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#container_overrides DataAwsEcsTaskExecution#container_overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsEcsTaskExecution.DataAwsEcsTaskExecutionOverridesContainerOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ContainerOverrides
        {
            get => _containerOverrides;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsEcsTaskExecution.IDataAwsEcsTaskExecutionOverridesContainerOverrides[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsEcsTaskExecution.IDataAwsEcsTaskExecutionOverridesContainerOverrides).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _containerOverrides = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#cpu DataAwsEcsTaskExecution#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#execution_role_arn DataAwsEcsTaskExecution#execution_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutionRoleArn
        {
            get;
            set;
        }

        private object? _inferenceAcceleratorOverrides;

        /// <summary>inference_accelerator_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#inference_accelerator_overrides DataAwsEcsTaskExecution#inference_accelerator_overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceAcceleratorOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsEcsTaskExecution.DataAwsEcsTaskExecutionOverridesInferenceAcceleratorOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InferenceAcceleratorOverrides
        {
            get => _inferenceAcceleratorOverrides;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsEcsTaskExecution.IDataAwsEcsTaskExecutionOverridesInferenceAcceleratorOverrides[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsEcsTaskExecution.IDataAwsEcsTaskExecutionOverridesInferenceAcceleratorOverrides).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inferenceAcceleratorOverrides = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#memory DataAwsEcsTaskExecution#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#task_role_arn DataAwsEcsTaskExecution#task_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaskRoleArn
        {
            get;
            set;
        }
    }
}
