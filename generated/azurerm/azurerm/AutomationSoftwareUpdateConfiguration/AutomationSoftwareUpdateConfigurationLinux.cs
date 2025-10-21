using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationLinux")]
    public class AutomationSoftwareUpdateConfigurationLinux : azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationLinux
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#classifications_included AutomationSoftwareUpdateConfiguration#classifications_included}.</summary>
        [JsiiProperty(name: "classificationsIncluded", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ClassificationsIncluded
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#excluded_packages AutomationSoftwareUpdateConfiguration#excluded_packages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedPackages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedPackages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#included_packages AutomationSoftwareUpdateConfiguration#included_packages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedPackages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedPackages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#reboot AutomationSoftwareUpdateConfiguration#reboot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reboot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reboot
        {
            get;
            set;
        }
    }
}
