using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceConfiguration
{
    [JsiiByValue(fqn: "azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinux")]
    public class MaintenanceConfigurationInstallPatchesLinux : azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesLinux
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#classifications_to_include MaintenanceConfiguration#classifications_to_include}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "classificationsToInclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ClassificationsToInclude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#package_names_mask_to_exclude MaintenanceConfiguration#package_names_mask_to_exclude}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "packageNamesMaskToExclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PackageNamesMaskToExclude
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#package_names_mask_to_include MaintenanceConfiguration#package_names_mask_to_include}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "packageNamesMaskToInclude", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PackageNamesMaskToInclude
        {
            get;
            set;
        }
    }
}
