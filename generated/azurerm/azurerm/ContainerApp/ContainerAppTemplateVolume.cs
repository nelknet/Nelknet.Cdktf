using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.containerApp.ContainerAppTemplateVolume")]
    public class ContainerAppTemplateVolume : azurerm.ContainerApp.IContainerAppTemplateVolume
    {
        /// <summary>The name of the volume.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#storage_name ContainerApp#storage_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageName
        {
            get;
            set;
        }

        /// <summary>The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#storage_type ContainerApp#storage_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageType
        {
            get;
            set;
        }
    }
}
