using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerGroup.ContainerGroupContainer")]
    public class ContainerGroupContainer : azurerm.ContainerGroup.IContainerGroupContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#cpu ContainerGroup#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        public double Cpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#image ContainerGroup#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public string Image
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#memory ContainerGroup#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public double Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#name ContainerGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#commands ContainerGroup#commands}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Commands
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#cpu_limit ContainerGroup#cpu_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#environment_variables ContainerGroup#environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>liveness_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#liveness_probe ContainerGroup#liveness_probe}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "livenessProbe", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerLivenessProbe\"}", isOptional: true)]
        public azurerm.ContainerGroup.IContainerGroupContainerLivenessProbe? LivenessProbe
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#memory_limit ContainerGroup#memory_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryLimit
        {
            get;
            set;
        }

        private object? _ports;

        /// <summary>ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#ports ContainerGroup#ports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ports", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ports
        {
            get => _ports;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerGroup.IContainerGroupContainerPorts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerGroup.IContainerGroupContainerPorts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ports = value;
            }
        }

        /// <summary>readiness_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#readiness_probe ContainerGroup#readiness_probe}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readinessProbe", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerReadinessProbe\"}", isOptional: true)]
        public azurerm.ContainerGroup.IContainerGroupContainerReadinessProbe? ReadinessProbe
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#secure_environment_variables ContainerGroup#secure_environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secureEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SecureEnvironmentVariables
        {
            get;
            set;
        }

        private object? _security;

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#security ContainerGroup#security}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "security", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerSecurity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Security
        {
            get => _security;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerGroup.IContainerGroupContainerSecurity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerGroup.IContainerGroupContainerSecurity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _security = value;
            }
        }

        private object? _volume;

        /// <summary>volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#volume ContainerGroup#volume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volume", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerVolume\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Volume
        {
            get => _volume;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ContainerGroup.IContainerGroupContainerVolume[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerGroup.IContainerGroupContainerVolume).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _volume = value;
            }
        }
    }
}
