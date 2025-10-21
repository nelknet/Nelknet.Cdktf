using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerGroup
{
    [JsiiInterface(nativeType: typeof(IContainerGroupContainer), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupContainer")]
    public interface IContainerGroupContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#cpu ContainerGroup#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        double Cpu
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#image ContainerGroup#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#memory ContainerGroup#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        double Memory
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#name ContainerGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#commands ContainerGroup#commands}.</summary>
        [JsiiProperty(name: "commands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Commands
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#cpu_limit ContainerGroup#cpu_limit}.</summary>
        [JsiiProperty(name: "cpuLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#environment_variables ContainerGroup#environment_variables}.</summary>
        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>liveness_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#liveness_probe ContainerGroup#liveness_probe}
        /// </remarks>
        [JsiiProperty(name: "livenessProbe", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerLivenessProbe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerGroup.IContainerGroupContainerLivenessProbe? LivenessProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#memory_limit ContainerGroup#memory_limit}.</summary>
        [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#ports ContainerGroup#ports}
        /// </remarks>
        [JsiiProperty(name: "ports", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ports
        {
            get
            {
                return null;
            }
        }

        /// <summary>readiness_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#readiness_probe ContainerGroup#readiness_probe}
        /// </remarks>
        [JsiiProperty(name: "readinessProbe", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerReadinessProbe\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerGroup.IContainerGroupContainerReadinessProbe? ReadinessProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#secure_environment_variables ContainerGroup#secure_environment_variables}.</summary>
        [JsiiProperty(name: "secureEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? SecureEnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#security ContainerGroup#security}
        /// </remarks>
        [JsiiProperty(name: "security", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerSecurity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Security
        {
            get
            {
                return null;
            }
        }

        /// <summary>volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#volume ContainerGroup#volume}
        /// </remarks>
        [JsiiProperty(name: "volume", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerVolume\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Volume
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerGroupContainer), fullyQualifiedName: "azurerm.containerGroup.ContainerGroupContainer")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerGroup.IContainerGroupContainer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#cpu ContainerGroup#cpu}.</summary>
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
            public double Cpu
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#image ContainerGroup#image}.</summary>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#memory ContainerGroup#memory}.</summary>
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
            public double Memory
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#name ContainerGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#commands ContainerGroup#commands}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Commands
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#cpu_limit ContainerGroup#cpu_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#environment_variables ContainerGroup#environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? EnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>liveness_probe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#liveness_probe ContainerGroup#liveness_probe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "livenessProbe", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerLivenessProbe\"}", isOptional: true)]
            public azurerm.ContainerGroup.IContainerGroupContainerLivenessProbe? LivenessProbe
            {
                get => GetInstanceProperty<azurerm.ContainerGroup.IContainerGroupContainerLivenessProbe?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#memory_limit ContainerGroup#memory_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ports block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#ports ContainerGroup#ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ports
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>readiness_probe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#readiness_probe ContainerGroup#readiness_probe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readinessProbe", typeJson: "{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerReadinessProbe\"}", isOptional: true)]
            public azurerm.ContainerGroup.IContainerGroupContainerReadinessProbe? ReadinessProbe
            {
                get => GetInstanceProperty<azurerm.ContainerGroup.IContainerGroupContainerReadinessProbe?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#secure_environment_variables ContainerGroup#secure_environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secureEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? SecureEnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>security block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#security ContainerGroup#security}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "security", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerSecurity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Security
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>volume block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_group#volume ContainerGroup#volume}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volume", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerGroup.ContainerGroupContainerVolume\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Volume
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
