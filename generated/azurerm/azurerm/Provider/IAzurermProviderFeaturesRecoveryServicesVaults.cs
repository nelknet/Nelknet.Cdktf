using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeaturesRecoveryServicesVaults), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults")]
    public interface IAzurermProviderFeaturesRecoveryServicesVaults
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_backup_protected_vm AzurermProvider#recover_soft_deleted_backup_protected_vm}.</summary>
        [JsiiProperty(name: "recoverSoftDeletedBackupProtectedVm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoverSoftDeletedBackupProtectedVm
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeaturesRecoveryServicesVaults), fullyQualifiedName: "azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recover_soft_deleted_backup_protected_vm AzurermProvider#recover_soft_deleted_backup_protected_vm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recoverSoftDeletedBackupProtectedVm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RecoverSoftDeletedBackupProtectedVm
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
