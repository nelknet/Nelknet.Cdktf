using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppTemplateContainer), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateContainer")]
    public interface IContainerAppTemplateContainer
    {
        /// <summary>The amount of vCPU to allocate to the container.</summary>
        /// <remarks>
        /// Possible values include <c>0.25</c>, <c>0.5</c>, <c>0.75</c>, <c>1.0</c>, <c>1.25</c>, <c>1.5</c>, <c>1.75</c>, and <c>2.0</c>. <strong>NOTE:</strong> <c>cpu</c> and <c>memory</c> must be specified in <c>0.25'/'0.5Gi</c> combination increments. e.g. <c>1.0</c> / <c>2.0</c> or <c>0.5</c> / <c>1.0</c>. When there's a workload profile specified, there's no such constraint.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#cpu ContainerApp#cpu}
        /// </remarks>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        double Cpu
        {
            get;
        }

        /// <summary>The image to use to create the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#image ContainerApp#image}
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>The amount of memory to allocate to the container.</summary>
        /// <remarks>
        /// Possible values include <c>0.5Gi</c>, <c>1.0Gi</c>, <c>1.5Gi</c>, <c>2.0Gi</c>, <c>2.5Gi</c>, <c>3.0Gi</c>, <c>3.5Gi</c>, and <c>4.0Gi</c>. <strong>NOTE:</strong> <c>cpu</c> and <c>memory</c> must be specified in <c>0.25'/'0.5Gi</c> combination increments. e.g. <c>1.25</c> / <c>2.5Gi</c> or <c>0.75</c> / <c>1.5Gi</c>. When there's a workload profile specified, there's no such constraint.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#memory ContainerApp#memory}
        /// </remarks>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        string Memory
        {
            get;
        }

        /// <summary>The name of the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>A list of args to pass to the container.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#args ContainerApp#args}
        /// </remarks>
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Args
        {
            get
            {
                return null;
            }
        }

        /// <summary>A command to pass to the container to override the default.</summary>
        /// <remarks>
        /// This is provided as a list of command line elements without spaces.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#command ContainerApp#command}
        /// </remarks>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Command
        {
            get
            {
                return null;
            }
        }

        /// <summary>env block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#env ContainerApp#env}
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>liveness_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#liveness_probe ContainerApp#liveness_probe}
        /// </remarks>
        [JsiiProperty(name: "livenessProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerLivenessProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LivenessProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>readiness_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#readiness_probe ContainerApp#readiness_probe}
        /// </remarks>
        [JsiiProperty(name: "readinessProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerReadinessProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReadinessProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>startup_probe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#startup_probe ContainerApp#startup_probe}
        /// </remarks>
        [JsiiProperty(name: "startupProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerStartupProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StartupProbe
        {
            get
            {
                return null;
            }
        }

        /// <summary>volume_mounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#volume_mounts ContainerApp#volume_mounts}
        /// </remarks>
        [JsiiProperty(name: "volumeMounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerVolumeMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VolumeMounts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppTemplateContainer), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateContainer")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppTemplateContainer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The amount of vCPU to allocate to the container.</summary>
            /// <remarks>
            /// Possible values include <c>0.25</c>, <c>0.5</c>, <c>0.75</c>, <c>1.0</c>, <c>1.25</c>, <c>1.5</c>, <c>1.75</c>, and <c>2.0</c>. <strong>NOTE:</strong> <c>cpu</c> and <c>memory</c> must be specified in <c>0.25'/'0.5Gi</c> combination increments. e.g. <c>1.0</c> / <c>2.0</c> or <c>0.5</c> / <c>1.0</c>. When there's a workload profile specified, there's no such constraint.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#cpu ContainerApp#cpu}
            /// </remarks>
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
            public double Cpu
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The image to use to create the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#image ContainerApp#image}
            /// </remarks>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The amount of memory to allocate to the container.</summary>
            /// <remarks>
            /// Possible values include <c>0.5Gi</c>, <c>1.0Gi</c>, <c>1.5Gi</c>, <c>2.0Gi</c>, <c>2.5Gi</c>, <c>3.0Gi</c>, <c>3.5Gi</c>, and <c>4.0Gi</c>. <strong>NOTE:</strong> <c>cpu</c> and <c>memory</c> must be specified in <c>0.25'/'0.5Gi</c> combination increments. e.g. <c>1.25</c> / <c>2.5Gi</c> or <c>0.75</c> / <c>1.5Gi</c>. When there's a workload profile specified, there's no such constraint.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#memory ContainerApp#memory}
            /// </remarks>
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
            public string Memory
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A list of args to pass to the container.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#args ContainerApp#args}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Args
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A command to pass to the container to override the default.</summary>
            /// <remarks>
            /// This is provided as a list of command line elements without spaces.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#command ContainerApp#command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Command
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>env block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#env ContainerApp#env}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Env
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>liveness_probe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#liveness_probe ContainerApp#liveness_probe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "livenessProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerLivenessProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LivenessProbe
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>readiness_probe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#readiness_probe ContainerApp#readiness_probe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readinessProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerReadinessProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ReadinessProbe
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>startup_probe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#startup_probe ContainerApp#startup_probe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startupProbe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerStartupProbe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StartupProbe
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>volume_mounts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#volume_mounts ContainerApp#volume_mounts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeMounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerApp.ContainerAppTemplateContainerVolumeMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VolumeMounts
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
