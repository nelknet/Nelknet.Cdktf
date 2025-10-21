using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultKey
{
    [JsiiByValue(fqn: "azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic")]
    public class KeyVaultKeyRotationPolicyAutomatic : azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#time_after_creation KeyVaultKey#time_after_creation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeAfterCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeAfterCreation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#time_before_expiry KeyVaultKey#time_before_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeBeforeExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeBeforeExpiry
        {
            get;
            set;
        }
    }
}
