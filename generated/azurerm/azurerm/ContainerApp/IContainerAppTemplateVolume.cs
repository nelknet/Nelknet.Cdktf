using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppTemplateVolume), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateVolume")]
    public interface IContainerAppTemplateVolume
    {
        /// <summary>The name of the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#storage_name ContainerApp#storage_name}
        /// </remarks>
        [JsiiProperty(name: "storageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#storage_type ContainerApp#storage_type}
        /// </remarks>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppTemplateVolume), fullyQualifiedName: "azurerm.containerApp.ContainerAppTemplateVolume")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppTemplateVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the volume.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#storage_name ContainerApp#storage_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#storage_type ContainerApp#storage_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
