using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    [JsiiInterface(nativeType: typeof(IAutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence), fullyQualifiedName: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence")]
    public interface IAutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#day AutomationSoftwareUpdateConfiguration#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        string Day
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#occurrence AutomationSoftwareUpdateConfiguration#occurrence}.</summary>
        [JsiiProperty(name: "occurrence", typeJson: "{\"primitive\":\"number\"}")]
        double Occurrence
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence), fullyQualifiedName: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationScheduleMonthlyOccurrence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#day AutomationSoftwareUpdateConfiguration#day}.</summary>
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
            public string Day
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#occurrence AutomationSoftwareUpdateConfiguration#occurrence}.</summary>
            [JsiiProperty(name: "occurrence", typeJson: "{\"primitive\":\"number\"}")]
            public double Occurrence
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
