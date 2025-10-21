using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbAccount.CosmosdbAccountConsistencyPolicy")]
    public class CosmosdbAccountConsistencyPolicy : azurerm.CosmosdbAccount.ICosmosdbAccountConsistencyPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#consistency_level CosmosdbAccount#consistency_level}.</summary>
        [JsiiProperty(name: "consistencyLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string ConsistencyLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#max_interval_in_seconds CosmosdbAccount#max_interval_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxIntervalInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#max_staleness_prefix CosmosdbAccount#max_staleness_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxStalenessPrefix", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxStalenessPrefix
        {
            get;
            set;
        }
    }
}
