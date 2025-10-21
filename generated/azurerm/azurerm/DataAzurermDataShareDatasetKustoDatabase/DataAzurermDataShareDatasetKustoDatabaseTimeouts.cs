using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataShareDatasetKustoDatabase
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDataShareDatasetKustoDatabase.DataAzurermDataShareDatasetKustoDatabaseTimeouts")]
    public class DataAzurermDataShareDatasetKustoDatabaseTimeouts : azurerm.DataAzurermDataShareDatasetKustoDatabase.IDataAzurermDataShareDatasetKustoDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_database#read DataAzurermDataShareDatasetKustoDatabase#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
