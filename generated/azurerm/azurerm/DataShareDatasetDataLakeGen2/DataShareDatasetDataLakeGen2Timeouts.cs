using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataShareDatasetDataLakeGen2
{
    [JsiiByValue(fqn: "azurerm.dataShareDatasetDataLakeGen2.DataShareDatasetDataLakeGen2Timeouts")]
    public class DataShareDatasetDataLakeGen2Timeouts : azurerm.DataShareDatasetDataLakeGen2.IDataShareDatasetDataLakeGen2Timeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#create DataShareDatasetDataLakeGen2#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#delete DataShareDatasetDataLakeGen2#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_dataset_data_lake_gen2#read DataShareDatasetDataLakeGen2#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
