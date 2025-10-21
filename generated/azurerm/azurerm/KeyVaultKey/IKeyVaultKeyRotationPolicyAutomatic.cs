using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultKey
{
    [JsiiInterface(nativeType: typeof(IKeyVaultKeyRotationPolicyAutomatic), fullyQualifiedName: "azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic")]
    public interface IKeyVaultKeyRotationPolicyAutomatic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#time_after_creation KeyVaultKey#time_after_creation}.</summary>
        [JsiiProperty(name: "timeAfterCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeAfterCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#time_before_expiry KeyVaultKey#time_before_expiry}.</summary>
        [JsiiProperty(name: "timeBeforeExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeBeforeExpiry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultKeyRotationPolicyAutomatic), fullyQualifiedName: "azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#time_after_creation KeyVaultKey#time_after_creation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeAfterCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeAfterCreation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#time_before_expiry KeyVaultKey#time_before_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeBeforeExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeBeforeExpiry
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
