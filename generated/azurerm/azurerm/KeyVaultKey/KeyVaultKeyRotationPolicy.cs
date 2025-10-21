using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultKey
{
    [JsiiByValue(fqn: "azurerm.keyVaultKey.KeyVaultKeyRotationPolicy")]
    public class KeyVaultKeyRotationPolicy : azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicy
    {
        /// <summary>automatic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#automatic KeyVaultKey#automatic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automatic", typeJson: "{\"fqn\":\"azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic\"}", isOptional: true)]
        public azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic? Automatic
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#expire_after KeyVaultKey#expire_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpireAfter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#notify_before_expiry KeyVaultKey#notify_before_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notifyBeforeExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotifyBeforeExpiry
        {
            get;
            set;
        }
    }
}
