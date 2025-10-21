using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KeyVaultKey
{
    [JsiiInterface(nativeType: typeof(IKeyVaultKeyRotationPolicy), fullyQualifiedName: "azurerm.keyVaultKey.KeyVaultKeyRotationPolicy")]
    public interface IKeyVaultKeyRotationPolicy
    {
        /// <summary>automatic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#automatic KeyVaultKey#automatic}
        /// </remarks>
        [JsiiProperty(name: "automatic", typeJson: "{\"fqn\":\"azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic? Automatic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#expire_after KeyVaultKey#expire_after}.</summary>
        [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpireAfter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#notify_before_expiry KeyVaultKey#notify_before_expiry}.</summary>
        [JsiiProperty(name: "notifyBeforeExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotifyBeforeExpiry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyVaultKeyRotationPolicy), fullyQualifiedName: "azurerm.keyVaultKey.KeyVaultKeyRotationPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>automatic block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#automatic KeyVaultKey#automatic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automatic", typeJson: "{\"fqn\":\"azurerm.keyVaultKey.KeyVaultKeyRotationPolicyAutomatic\"}", isOptional: true)]
            public azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic? Automatic
            {
                get => GetInstanceProperty<azurerm.KeyVaultKey.IKeyVaultKeyRotationPolicyAutomatic?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#expire_after KeyVaultKey#expire_after}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpireAfter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_key#notify_before_expiry KeyVaultKey#notify_before_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notifyBeforeExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotifyBeforeExpiry
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
