using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRecoveryServicesVault
{
    [JsiiInterface(nativeType: typeof(IDataAzurermRecoveryServicesVaultTimeouts), fullyQualifiedName: "azurerm.dataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVaultTimeouts")]
    public interface IDataAzurermRecoveryServicesVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/recovery_services_vault#read DataAzurermRecoveryServicesVault#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermRecoveryServicesVaultTimeouts), fullyQualifiedName: "azurerm.dataAzurermRecoveryServicesVault.DataAzurermRecoveryServicesVaultTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermRecoveryServicesVault.IDataAzurermRecoveryServicesVaultTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/recovery_services_vault#read DataAzurermRecoveryServicesVault#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
