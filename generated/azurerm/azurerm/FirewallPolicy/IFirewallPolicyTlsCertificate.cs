using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicy
{
    [JsiiInterface(nativeType: typeof(IFirewallPolicyTlsCertificate), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicyTlsCertificate")]
    public interface IFirewallPolicyTlsCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#key_vault_secret_id FirewallPolicy#key_vault_secret_id}.</summary>
        [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultSecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#name FirewallPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFirewallPolicyTlsCertificate), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicyTlsCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.FirewallPolicy.IFirewallPolicyTlsCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#key_vault_secret_id FirewallPolicy#key_vault_secret_id}.</summary>
            [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultSecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#name FirewallPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
