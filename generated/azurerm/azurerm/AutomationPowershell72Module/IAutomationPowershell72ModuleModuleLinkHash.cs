using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationPowershell72Module
{
    [JsiiInterface(nativeType: typeof(IAutomationPowershell72ModuleModuleLinkHash), fullyQualifiedName: "azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHash")]
    public interface IAutomationPowershell72ModuleModuleLinkHash
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#algorithm AutomationPowershell72Module#algorithm}.</summary>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        string Algorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#value AutomationPowershell72Module#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationPowershell72ModuleModuleLinkHash), fullyQualifiedName: "azurerm.automationPowershell72Module.AutomationPowershell72ModuleModuleLinkHash")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationPowershell72Module.IAutomationPowershell72ModuleModuleLinkHash
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#algorithm AutomationPowershell72Module#algorithm}.</summary>
            [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string Algorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_powershell72_module#value AutomationPowershell72Module#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
