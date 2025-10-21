using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationPowershell72Module
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLink")]
    public class AutomationPowershell72ModuleModuleLink : azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#uri AutomationPowershell72Module#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }

        /// <summary>hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#hash AutomationPowershell72Module#hash}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHash\"}", isOptional: true)]
        public azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash? Hash
        {
            get;
            set;
        }
    }
}
