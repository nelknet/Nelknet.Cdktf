using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemHsmSetting")]
    public class ManagedLustreFileSystemHsmSetting : azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemHsmSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#container_id ManagedLustreFileSystem#container_id}.</summary>
        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
        public string ContainerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#logging_container_id ManagedLustreFileSystem#logging_container_id}.</summary>
        [JsiiProperty(name: "loggingContainerId", typeJson: "{\"primitive\":\"string\"}")]
        public string LoggingContainerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#import_prefix ManagedLustreFileSystem#import_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "importPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImportPrefix
        {
            get;
            set;
        }
    }
}
