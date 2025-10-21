using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryTaskRegistryCredential), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredential")]
    public interface IContainerRegistryTaskRegistryCredential
    {
        /// <summary>custom block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#custom ContainerRegistryTask#custom}
        /// </remarks>
        [JsiiProperty(name: "custom", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialCustom\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Custom
        {
            get
            {
                return null;
            }
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#source ContainerRegistryTask#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryTaskRegistryCredential), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredential")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#custom ContainerRegistryTask#custom}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "custom", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialCustom\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Custom
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#source ContainerRegistryTask#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource\"}", isOptional: true)]
            public azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource? Source
            {
                get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource?>();
            }
        }
    }
}
