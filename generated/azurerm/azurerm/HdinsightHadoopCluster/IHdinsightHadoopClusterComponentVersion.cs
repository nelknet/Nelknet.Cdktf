using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHadoopClusterComponentVersion), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComponentVersion")]
    public interface IHdinsightHadoopClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#hadoop HdinsightHadoopCluster#hadoop}.</summary>
        [JsiiProperty(name: "hadoop", typeJson: "{\"primitive\":\"string\"}")]
        string Hadoop
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHadoopClusterComponentVersion), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterComponentVersion")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterComponentVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#hadoop HdinsightHadoopCluster#hadoop}.</summary>
            [JsiiProperty(name: "hadoop", typeJson: "{\"primitive\":\"string\"}")]
            public string Hadoop
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
