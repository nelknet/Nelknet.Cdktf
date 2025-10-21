using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ElasticCloudElasticsearch
{
    [JsiiInterface(nativeType: typeof(IElasticCloudElasticsearchLogsFilteringTag), fullyQualifiedName: "azurerm.elasticCloudElasticsearch.ElasticCloudElasticsearchLogsFilteringTag")]
    public interface IElasticCloudElasticsearchLogsFilteringTag
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#action ElasticCloudElasticsearch#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#name ElasticCloudElasticsearch#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#value ElasticCloudElasticsearch#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticCloudElasticsearchLogsFilteringTag), fullyQualifiedName: "azurerm.elasticCloudElasticsearch.ElasticCloudElasticsearchLogsFilteringTag")]
        internal sealed class _Proxy : DeputyBase, azurerm.ElasticCloudElasticsearch.IElasticCloudElasticsearchLogsFilteringTag
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#action ElasticCloudElasticsearch#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#name ElasticCloudElasticsearch#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#value ElasticCloudElasticsearch#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
