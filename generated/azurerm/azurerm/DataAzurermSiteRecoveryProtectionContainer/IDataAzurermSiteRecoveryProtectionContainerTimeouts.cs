using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSiteRecoveryProtectionContainer
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSiteRecoveryProtectionContainerTimeouts), fullyQualifiedName: "azurerm.dataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainerTimeouts")]
    public interface IDataAzurermSiteRecoveryProtectionContainerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container#read DataAzurermSiteRecoveryProtectionContainer#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSiteRecoveryProtectionContainerTimeouts), fullyQualifiedName: "azurerm.dataAzurermSiteRecoveryProtectionContainer.DataAzurermSiteRecoveryProtectionContainerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSiteRecoveryProtectionContainer.IDataAzurermSiteRecoveryProtectionContainerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/site_recovery_protection_container#read DataAzurermSiteRecoveryProtectionContainer#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
