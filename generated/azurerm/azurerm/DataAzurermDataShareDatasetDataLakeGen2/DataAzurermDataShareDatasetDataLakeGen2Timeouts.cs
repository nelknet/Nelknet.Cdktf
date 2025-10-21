using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataShareDatasetDataLakeGen2
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2Timeouts")]
    public class DataAzurermDataShareDatasetDataLakeGen2Timeouts : azurerm.DataAzurermDataShareDatasetDataLakeGen2.IDataAzurermDataShareDatasetDataLakeGen2Timeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_data_lake_gen2#read DataAzurermDataShareDatasetDataLakeGen2#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
