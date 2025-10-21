using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSnapshot
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSnapshot.DataAzurermSnapshotTimeouts")]
    public class DataAzurermSnapshotTimeouts : azurerm.DataAzurermSnapshot.IDataAzurermSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/snapshot#read DataAzurermSnapshot#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
