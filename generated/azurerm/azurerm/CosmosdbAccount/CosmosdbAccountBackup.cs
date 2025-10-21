using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cosmosdbAccount.CosmosdbAccountBackup")]
    public class CosmosdbAccountBackup : azurerm.CosmosdbAccount.ICosmosdbAccountBackup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#type CosmosdbAccount#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#interval_in_minutes CosmosdbAccount#interval_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#retention_in_hours CosmosdbAccount#retention_in_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionInHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#storage_redundancy CosmosdbAccount#storage_redundancy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageRedundancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageRedundancy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#tier CosmosdbAccount#tier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Tier
        {
            get;
            set;
        }
    }
}
