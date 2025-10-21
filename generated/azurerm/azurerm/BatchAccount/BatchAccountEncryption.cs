using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchAccount
{
    [JsiiByValue(fqn: "azurerm.batchAccount.BatchAccountEncryption")]
    public class BatchAccountEncryption : azurerm.BatchAccount.IBatchAccountEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#key_vault_key_id BatchAccount#key_vault_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultKeyId
        {
            get;
            set;
        }
    }
}
