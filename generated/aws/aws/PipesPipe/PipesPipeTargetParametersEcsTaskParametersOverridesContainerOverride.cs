using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride")]
    public class PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride : aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#command PipesPipe#command}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Command
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#cpu PipesPipe#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Cpu
        {
            get;
            set;
        }

        private object? _environment;

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#environment PipesPipe#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Environment
        {
            get => _environment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _environment = value;
            }
        }

        private object? _environmentFile;

        /// <summary>environment_file block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#environment_file PipesPipe#environment_file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentFile", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EnvironmentFile
        {
            get => _environmentFile;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideEnvironmentFile).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _environmentFile = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#memory PipesPipe#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#memory_reservation PipesPipe#memory_reservation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryReservation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryReservation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#name PipesPipe#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        private object? _resourceRequirement;

        /// <summary>resource_requirement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#resource_requirement PipesPipe#resource_requirement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRequirement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceRequirement
        {
            get => _resourceRequirement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesContainerOverrideResourceRequirement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceRequirement = value;
            }
        }
    }
}
