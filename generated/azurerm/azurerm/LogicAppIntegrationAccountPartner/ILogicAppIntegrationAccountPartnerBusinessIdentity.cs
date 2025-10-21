using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppIntegrationAccountPartner
{
    [JsiiInterface(nativeType: typeof(ILogicAppIntegrationAccountPartnerBusinessIdentity), fullyQualifiedName: "azurerm.logicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartnerBusinessIdentity")]
    public interface ILogicAppIntegrationAccountPartnerBusinessIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#qualifier LogicAppIntegrationAccountPartner#qualifier}.</summary>
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
        string Qualifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#value LogicAppIntegrationAccountPartner#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILogicAppIntegrationAccountPartnerBusinessIdentity), fullyQualifiedName: "azurerm.logicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartnerBusinessIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.LogicAppIntegrationAccountPartner.ILogicAppIntegrationAccountPartnerBusinessIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#qualifier LogicAppIntegrationAccountPartner#qualifier}.</summary>
            [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
            public string Qualifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#value LogicAppIntegrationAccountPartner#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
