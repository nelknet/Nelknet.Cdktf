using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightKafkaClusterComponentVersion), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComponentVersion")]
    public interface IHdinsightKafkaClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#kafka HdinsightKafkaCluster#kafka}.</summary>
        [JsiiProperty(name: "kafka", typeJson: "{\"primitive\":\"string\"}")]
        string Kafka
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightKafkaClusterComponentVersion), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComponentVersion")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#kafka HdinsightKafkaCluster#kafka}.</summary>
            [JsiiProperty(name: "kafka", typeJson: "{\"primitive\":\"string\"}")]
            public string Kafka
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
