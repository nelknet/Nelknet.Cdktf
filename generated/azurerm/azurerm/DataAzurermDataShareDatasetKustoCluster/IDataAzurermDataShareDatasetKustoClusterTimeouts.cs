using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataShareDatasetKustoCluster
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataShareDatasetKustoClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoClusterTimeouts")]
    public interface IDataAzurermDataShareDatasetKustoClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_cluster#read DataAzurermDataShareDatasetKustoCluster#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataShareDatasetKustoClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataShareDatasetKustoCluster.DataAzurermDataShareDatasetKustoClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataShareDatasetKustoCluster.IDataAzurermDataShareDatasetKustoClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_kusto_cluster#read DataAzurermDataShareDatasetKustoCluster#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
