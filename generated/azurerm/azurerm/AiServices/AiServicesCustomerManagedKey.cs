using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AiServices
{
    [JsiiByValue(fqn: "azurerm.aiServices.AiServicesCustomerManagedKey")]
    public class AiServicesCustomerManagedKey : azurerm.AiServices.IAiServicesCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#identity_client_id AiServices#identity_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#key_vault_key_id AiServices#key_vault_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#managed_hsm_key_id AiServices#managed_hsm_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedHsmKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedHsmKeyId
        {
            get;
            set;
        }
    }
}
