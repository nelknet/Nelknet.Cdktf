using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationPowershell72Module
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHash")]
    public class AutomationPowershell72ModuleModuleLinkHash : azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#algorithm AutomationPowershell72Module#algorithm}.</summary>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string Algorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#value AutomationPowershell72Module#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
