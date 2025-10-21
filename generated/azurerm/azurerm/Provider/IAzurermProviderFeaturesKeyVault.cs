using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesKeyVault), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesKeyVault")]
    public interface IAzurermProviderFeaturesKeyVault
    {
        /// <summary>When enabled soft-deleted `azurerm_key_vault_certificate` resources will be permanently deleted (e.g purged), when destroyed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_certificates_on_destroy AzurermProvider#purge_soft_deleted_certificates_on_destroy}
        /// </remarks>
        [JsiiProperty(name: "purgeSoftDeletedCertificatesOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeSoftDeletedCertificatesOnDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module_key` resources will be permanently deleted (e.g purged), when destroyed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_hardware_security_module_keys_on_destroy AzurermProvider#purge_soft_deleted_hardware_security_module_keys_on_destroy}
        /// </remarks>
        [JsiiProperty(name: "purgeSoftDeletedHardwareSecurityModuleKeysOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeSoftDeletedHardwareSecurityModuleKeysOnDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module` resources will be permanently deleted (e.g purged), when destroyed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_hardware_security_modules_on_destroy AzurermProvider#purge_soft_deleted_hardware_security_modules_on_destroy}
        /// </remarks>
        [JsiiProperty(name: "purgeSoftDeletedHardwareSecurityModulesOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeSoftDeletedHardwareSecurityModulesOnDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault_key` resources will be permanently deleted (e.g purged), when destroyed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_keys_on_destroy AzurermProvider#purge_soft_deleted_keys_on_destroy}
        /// </remarks>
        [JsiiProperty(name: "purgeSoftDeletedKeysOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeSoftDeletedKeysOnDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault_secret` resources will be permanently deleted (e.g purged), when destroyed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_secrets_on_destroy AzurermProvider#purge_soft_deleted_secrets_on_destroy}
        /// </remarks>
        [JsiiProperty(name: "purgeSoftDeletedSecretsOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeSoftDeletedSecretsOnDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault` resources will be permanently deleted (e.g purged), when destroyed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_delete_on_destroy AzurermProvider#purge_soft_delete_on_destroy}
        /// </remarks>
        [JsiiProperty(name: "purgeSoftDeleteOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PurgeSoftDeleteOnDestroy
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault_certificate` resources will be restored, instead of creating new ones.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_certificates AzurermProvider#recover_soft_deleted_certificates}
        /// </remarks>
        [JsiiProperty(name: "recoverSoftDeletedCertificates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoverSoftDeletedCertificates
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module_key` resources will be restored, instead of creating new ones.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_hardware_security_module_keys AzurermProvider#recover_soft_deleted_hardware_security_module_keys}
        /// </remarks>
        [JsiiProperty(name: "recoverSoftDeletedHardwareSecurityModuleKeys", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoverSoftDeletedHardwareSecurityModuleKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault_key` resources will be restored, instead of creating new ones.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_keys AzurermProvider#recover_soft_deleted_keys}
        /// </remarks>
        [JsiiProperty(name: "recoverSoftDeletedKeys", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoverSoftDeletedKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault` resources will be restored, instead of creating new ones.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_key_vaults AzurermProvider#recover_soft_deleted_key_vaults}
        /// </remarks>
        [JsiiProperty(name: "recoverSoftDeletedKeyVaults", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoverSoftDeletedKeyVaults
        {
            get
            {
                return null;
            }
        }

        /// <summary>When enabled soft-deleted `azurerm_key_vault_secret` resources will be restored, instead of creating new ones.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_secrets AzurermProvider#recover_soft_deleted_secrets}
        /// </remarks>
        [JsiiProperty(name: "recoverSoftDeletedSecrets", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoverSoftDeletedSecrets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesKeyVault), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesKeyVault")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesKeyVault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_certificate` resources will be permanently deleted (e.g purged), when destroyed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_certificates_on_destroy AzurermProvider#purge_soft_deleted_certificates_on_destroy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purgeSoftDeletedCertificatesOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PurgeSoftDeletedCertificatesOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module_key` resources will be permanently deleted (e.g purged), when destroyed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_hardware_security_module_keys_on_destroy AzurermProvider#purge_soft_deleted_hardware_security_module_keys_on_destroy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purgeSoftDeletedHardwareSecurityModuleKeysOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PurgeSoftDeletedHardwareSecurityModuleKeysOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module` resources will be permanently deleted (e.g purged), when destroyed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_hardware_security_modules_on_destroy AzurermProvider#purge_soft_deleted_hardware_security_modules_on_destroy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purgeSoftDeletedHardwareSecurityModulesOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PurgeSoftDeletedHardwareSecurityModulesOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_key` resources will be permanently deleted (e.g purged), when destroyed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_keys_on_destroy AzurermProvider#purge_soft_deleted_keys_on_destroy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purgeSoftDeletedKeysOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PurgeSoftDeletedKeysOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_secret` resources will be permanently deleted (e.g purged), when destroyed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_deleted_secrets_on_destroy AzurermProvider#purge_soft_deleted_secrets_on_destroy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purgeSoftDeletedSecretsOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PurgeSoftDeletedSecretsOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault` resources will be permanently deleted (e.g purged), when destroyed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#purge_soft_delete_on_destroy AzurermProvider#purge_soft_delete_on_destroy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "purgeSoftDeleteOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PurgeSoftDeleteOnDestroy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_certificate` resources will be restored, instead of creating new ones.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_certificates AzurermProvider#recover_soft_deleted_certificates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoverSoftDeletedCertificates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RecoverSoftDeletedCertificates
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_managed_hardware_security_module_key` resources will be restored, instead of creating new ones.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_hardware_security_module_keys AzurermProvider#recover_soft_deleted_hardware_security_module_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoverSoftDeletedHardwareSecurityModuleKeys", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RecoverSoftDeletedHardwareSecurityModuleKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_key` resources will be restored, instead of creating new ones.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_keys AzurermProvider#recover_soft_deleted_keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoverSoftDeletedKeys", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RecoverSoftDeletedKeys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault` resources will be restored, instead of creating new ones.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_key_vaults AzurermProvider#recover_soft_deleted_key_vaults}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoverSoftDeletedKeyVaults", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RecoverSoftDeletedKeyVaults
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>When enabled soft-deleted `azurerm_key_vault_secret` resources will be restored, instead of creating new ones.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_secrets AzurermProvider#recover_soft_deleted_secrets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoverSoftDeletedSecrets", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RecoverSoftDeletedSecrets
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
