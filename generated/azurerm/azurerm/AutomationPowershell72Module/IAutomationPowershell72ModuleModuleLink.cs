using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationPowershell72Module
{
    [JsiiInterface(nativeType: typeof(IAutomationPowershell72ModuleModuleLink), fullyQualifiedName: "azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLink")]
    public interface IAutomationPowershell72ModuleModuleLink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#uri AutomationPowershell72Module#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        /// <summary>hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#hash AutomationPowershell72Module#hash}
        /// </remarks>
        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHash\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash? Hash
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationPowershell72ModuleModuleLink), fullyQualifiedName: "azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLink")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLink
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#uri AutomationPowershell72Module#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>hash block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#hash AutomationPowershell72Module#hash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHash\"}", isOptional: true)]
            public azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash? Hash
            {
                get => GetInstanceProperty<azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash?>();
            }
        }
    }
}
