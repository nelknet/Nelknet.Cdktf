using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVault
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.keyVault.KeyVaultNetworkAcls")]
    public class KeyVaultNetworkAcls : azurerm.KeyVault.IKeyVaultNetworkAcls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#bypass KeyVault#bypass}.</summary>
        [JsiiProperty(name: "bypass", typeJson: "{\"primitive\":\"string\"}")]
        public string Bypass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#default_action KeyVault#default_action}.</summary>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#ip_rules KeyVault#ip_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpRules
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#virtual_network_subnet_ids KeyVault#virtual_network_subnet_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkSubnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VirtualNetworkSubnetIds
        {
            get;
            set;
        }
    }
}
