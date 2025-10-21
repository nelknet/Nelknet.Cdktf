using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationModule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationModule.AutomationModuleModuleLink")]
    public class AutomationModuleModuleLink : azurerm.AutomationModule.IAutomationModuleModuleLink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#uri AutomationModule#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }

        /// <summary>hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#hash AutomationModule#hash}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationModule.AutomationModuleModuleLinkHash\"}", isOptional: true)]
        public azurerm.AutomationModule.IAutomationModuleModuleLinkHash? Hash
        {
            get;
            set;
        }
    }
}
