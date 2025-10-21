using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightSparkClusterComponentVersion), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterComponentVersion")]
    public interface IHdinsightSparkClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#spark HdinsightSparkCluster#spark}.</summary>
        [JsiiProperty(name: "spark", typeJson: "{\"primitive\":\"string\"}")]
        string Spark
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightSparkClusterComponentVersion), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterComponentVersion")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComponentVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#spark HdinsightSparkCluster#spark}.</summary>
            [JsiiProperty(name: "spark", typeJson: "{\"primitive\":\"string\"}")]
            public string Spark
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
