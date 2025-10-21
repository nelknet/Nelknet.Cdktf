using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ElasticCloudElasticsearch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.elasticCloudElasticsearch.ElasticCloudElasticsearchLogsFilteringTag")]
    public class ElasticCloudElasticsearchLogsFilteringTag : azurerm.ElasticCloudElasticsearch.IElasticCloudElasticsearchLogsFilteringTag
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#action ElasticCloudElasticsearch#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#name ElasticCloudElasticsearch#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#value ElasticCloudElasticsearch#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
