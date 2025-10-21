using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ElasticSan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.elasticSan.ElasticSanSku")]
    public class ElasticSanSku : azurerm.ElasticSan.IElasticSanSku
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#name ElasticSan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_san#tier ElasticSan#tier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tier
        {
            get;
            set;
        }
    }
}
