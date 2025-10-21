using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeGroupSapHana
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappVolumeGroupSapHana.DataAzurermNetappVolumeGroupSapHanaTimeouts")]
    public class DataAzurermNetappVolumeGroupSapHanaTimeouts : azurerm.DataAzurermNetappVolumeGroupSapHana.IDataAzurermNetappVolumeGroupSapHanaTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume_group_sap_hana#read DataAzurermNetappVolumeGroupSapHana#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
