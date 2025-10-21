using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerAdminRule
{
    [JsiiInterface(nativeType: typeof(INetworkManagerAdminRuleSource), fullyQualifiedName: "azurerm.networkManagerAdminRule.NetworkManagerAdminRuleSource")]
    public interface INetworkManagerAdminRuleSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#address_prefix NetworkManagerAdminRule#address_prefix}.</summary>
        [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        string AddressPrefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#address_prefix_type NetworkManagerAdminRule#address_prefix_type}.</summary>
        [JsiiProperty(name: "addressPrefixType", typeJson: "{\"primitive\":\"string\"}")]
        string AddressPrefixType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkManagerAdminRuleSource), fullyQualifiedName: "azurerm.networkManagerAdminRule.NetworkManagerAdminRuleSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkManagerAdminRule.INetworkManagerAdminRuleSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#address_prefix NetworkManagerAdminRule#address_prefix}.</summary>
            [JsiiProperty(name: "addressPrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressPrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#address_prefix_type NetworkManagerAdminRule#address_prefix_type}.</summary>
            [JsiiProperty(name: "addressPrefixType", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressPrefixType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
