using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeGroupSapHana
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappVolumeGroupSapHanaTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaTimeouts")]
    public interface IDataAzurermNetappVolumeGroupSapHanaTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana#read DataAzurermNetappVolumeGroupSapHana#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappVolumeGroupSapHanaTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappVolumeGroupSapHana.IDataAzurermNetappVolumeGroupSapHanaTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana#read DataAzurermNetappVolumeGroupSapHana#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
