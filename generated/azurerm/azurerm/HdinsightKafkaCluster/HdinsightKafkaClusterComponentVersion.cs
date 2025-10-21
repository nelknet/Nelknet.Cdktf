using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterComponentVersion")]
    public class HdinsightKafkaClusterComponentVersion : azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#kafka HdinsightKafkaCluster#kafka}.</summary>
        [JsiiProperty(name: "kafka", typeJson: "{\"primitive\":\"string\"}")]
        public string Kafka
        {
            get;
            set;
        }
    }
}
