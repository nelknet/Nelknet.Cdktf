using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbAccount
{
    [JsiiInterface(nativeType: typeof(ICosmosdbAccountCapacity), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountCapacity")]
    public interface ICosmosdbAccountCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#total_throughput_limit CosmosdbAccount#total_throughput_limit}.</summary>
        [JsiiProperty(name: "totalThroughputLimit", typeJson: "{\"primitive\":\"number\"}")]
        double TotalThroughputLimit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICosmosdbAccountCapacity), fullyQualifiedName: "azurerm.cosmosdbAccount.CosmosdbAccountCapacity")]
        internal sealed class _Proxy : DeputyBase, azurerm.CosmosdbAccount.ICosmosdbAccountCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#total_throughput_limit CosmosdbAccount#total_throughput_limit}.</summary>
            [JsiiProperty(name: "totalThroughputLimit", typeJson: "{\"primitive\":\"number\"}")]
            public double TotalThroughputLimit
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
