using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDatasetSnowflake
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryDatasetSnowflake.DataFactoryDatasetSnowflakeSchemaColumn")]
    public class DataFactoryDatasetSnowflakeSchemaColumn : azurerm.DataFactoryDatasetSnowflake.IDataFactoryDatasetSnowflakeSchemaColumn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#name DataFactoryDatasetSnowflake#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#precision DataFactoryDatasetSnowflake#precision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "precision", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Precision
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#scale DataFactoryDatasetSnowflake#scale}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Scale
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_snowflake#type DataFactoryDatasetSnowflake#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
