using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermHdinsightCluster
{
    [JsiiInterface(nativeType: typeof(IDataAzurermHdinsightClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermHdinsightCluster.DataAzurermHdinsightClusterTimeouts")]
    public interface IDataAzurermHdinsightClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/hdinsight_cluster#read DataAzurermHdinsightCluster#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermHdinsightClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermHdinsightCluster.DataAzurermHdinsightClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermHdinsightCluster.IDataAzurermHdinsightClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/hdinsight_cluster#read DataAzurermHdinsightCluster#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
