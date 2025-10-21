using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationModule
{
    [JsiiInterface(nativeType: typeof(IAutomationModuleModuleLink), fullyQualifiedName: "azurerm.automationModule.AutomationModuleModuleLink")]
    public interface IAutomationModuleModuleLink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#uri AutomationModule#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        /// <summary>hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#hash AutomationModule#hash}
        /// </remarks>
        [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationModule.AutomationModuleModuleLinkHash\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomationModule.IAutomationModuleModuleLinkHash? Hash
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationModuleModuleLink), fullyQualifiedName: "azurerm.automationModule.AutomationModuleModuleLink")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationModule.IAutomationModuleModuleLink
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#uri AutomationModule#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>hash block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_module#hash AutomationModule#hash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hash", typeJson: "{\"fqn\":\"azurerm.automationModule.AutomationModuleModuleLinkHash\"}", isOptional: true)]
            public azurerm.AutomationModule.IAutomationModuleModuleLinkHash? Hash
            {
                get => GetInstanceProperty<azurerm.AutomationModule.IAutomationModuleModuleLinkHash?>();
            }
        }
    }
}
