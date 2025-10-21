using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappSnapshot
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNetappSnapshot.DataAzurermNetappSnapshotTimeouts")]
    public class DataAzurermNetappSnapshotTimeouts : azurerm.DataAzurermNetappSnapshot.IDataAzurermNetappSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#read DataAzurermNetappSnapshot#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
