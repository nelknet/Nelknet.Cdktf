using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence")]
    public class AutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence : azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#day AutomationSoftwareUpdateConfiguration#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        public string Day
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#occurrence AutomationSoftwareUpdateConfiguration#occurrence}.</summary>
        [JsiiProperty(name: "occurrence", typeJson: "{\"primitive\":\"number\"}")]
        public double Occurrence
        {
            get;
            set;
        }
    }
}
