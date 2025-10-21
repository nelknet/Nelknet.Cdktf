using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryTaskPlatform), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskPlatform")]
    public interface IContainerRegistryTaskPlatform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#os ContainerRegistryTask#os}.</summary>
        [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}")]
        string Os
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#architecture ContainerRegistryTask#architecture}.</summary>
        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Architecture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#variant ContainerRegistryTask#variant}.</summary>
        [JsiiProperty(name: "variant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Variant
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryTaskPlatform), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskPlatform")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryTask.IContainerRegistryTaskPlatform
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#os ContainerRegistryTask#os}.</summary>
            [JsiiProperty(name: "os", typeJson: "{\"primitive\":\"string\"}")]
            public string Os
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#architecture ContainerRegistryTask#architecture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Architecture
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#variant ContainerRegistryTask#variant}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "variant", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Variant
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
