using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    [JsiiInterface(nativeType: typeof(ICosmosdbAccountConsistencyPolicy), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountConsistencyPolicy")]
    public interface ICosmosdbAccountConsistencyPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#consistency_level CosmosdbAccount#consistency_level}.</summary>
        [JsiiProperty(name: "consistencyLevel", typeJson: "{\"primitive\":\"string\"}")]
        string ConsistencyLevel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#max_interval_in_seconds CosmosdbAccount#max_interval_in_seconds}.</summary>
        [JsiiProperty(name: "maxIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxIntervalInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#max_staleness_prefix CosmosdbAccount#max_staleness_prefix}.</summary>
        [JsiiProperty(name: "maxStalenessPrefix", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxStalenessPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbAccountConsistencyPolicy), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountConsistencyPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbAccount.ICosmosdbAccountConsistencyPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#consistency_level CosmosdbAccount#consistency_level}.</summary>
            [JsiiProperty(name: "consistencyLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsistencyLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#max_interval_in_seconds CosmosdbAccount#max_interval_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxIntervalInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#max_staleness_prefix CosmosdbAccount#max_staleness_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxStalenessPrefix", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxStalenessPrefix
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
