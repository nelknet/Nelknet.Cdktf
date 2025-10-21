using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKustoCluster
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKustoClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermKustoCluster.DataAzurermKustoClusterTimeouts")]
    public interface IDataAzurermKustoClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_cluster#read DataAzurermKustoCluster#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKustoClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermKustoCluster.DataAzurermKustoClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKustoCluster.IDataAzurermKustoClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_cluster#read DataAzurermKustoCluster#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
