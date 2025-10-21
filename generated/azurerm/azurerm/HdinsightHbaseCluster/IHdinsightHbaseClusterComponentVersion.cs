using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHbaseClusterComponentVersion), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComponentVersion")]
    public interface IHdinsightHbaseClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#hbase HdinsightHbaseCluster#hbase}.</summary>
        [JsiiProperty(name: "hbase", typeJson: "{\"primitive\":\"string\"}")]
        string Hbase
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHbaseClusterComponentVersion), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterComponentVersion")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterComponentVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#hbase HdinsightHbaseCluster#hbase}.</summary>
            [JsiiProperty(name: "hbase", typeJson: "{\"primitive\":\"string\"}")]
            public string Hbase
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
