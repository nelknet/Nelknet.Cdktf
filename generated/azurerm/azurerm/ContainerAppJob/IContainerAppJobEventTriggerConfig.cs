using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerAppJob
{
    [JsiiInterface(nativeType: typeof(IContainerAppJobEventTriggerConfig), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfig")]
    public interface IContainerAppJobEventTriggerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#parallelism ContainerAppJob#parallelism}.</summary>
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Parallelism
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#replica_completion_count ContainerAppJob#replica_completion_count}.</summary>
        [JsiiProperty(name: "replicaCompletionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicaCompletionCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#scale ContainerAppJob#scale}
        /// </remarks>
        [JsiiProperty(name: "scale", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScale\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Scale
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppJobEventTriggerConfig), fullyQualifiedName: "azurerm.containerAppJob.ContainerAppJobEventTriggerConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerAppJob.IContainerAppJobEventTriggerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#parallelism ContainerAppJob#parallelism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Parallelism
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#replica_completion_count ContainerAppJob#replica_completion_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicaCompletionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicaCompletionCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>scale block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#scale ContainerAppJob#scale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scale", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerAppJob.ContainerAppJobEventTriggerConfigScale\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Scale
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
