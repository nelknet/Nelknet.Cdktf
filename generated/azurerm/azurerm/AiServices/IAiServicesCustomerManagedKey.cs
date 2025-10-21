using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AiServices
{
    [JsiiInterface(nativeType: typeof(IAiServicesCustomerManagedKey), fullyQualifiedName: "azurerm.aiServices.AiServicesCustomerManagedKey")]
    public interface IAiServicesCustomerManagedKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#identity_client_id AiServices#identity_client_id}.</summary>
        [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentityClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#key_vault_key_id AiServices#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#managed_hsm_key_id AiServices#managed_hsm_key_id}.</summary>
        [JsiiProperty(name: "managedHsmKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedHsmKeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiServicesCustomerManagedKey), fullyQualifiedName: "azurerm.aiServices.AiServicesCustomerManagedKey")]
        internal sealed class _Proxy : DeputyBase, azurerm.AiServices.IAiServicesCustomerManagedKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#identity_client_id AiServices#identity_client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentityClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#key_vault_key_id AiServices#key_vault_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#managed_hsm_key_id AiServices#managed_hsm_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedHsmKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedHsmKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
