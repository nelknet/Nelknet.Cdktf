using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermElasticCloudElasticsearch
{
    [JsiiByValue(fqn: "azurerm.dataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchTimeouts")]
    public class DataAzurermElasticCloudElasticsearchTimeouts : azurerm.DataAzurermElasticCloudElasticsearch.IDataAzurermElasticCloudElasticsearchTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch#read DataAzurermElasticCloudElasticsearch#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
