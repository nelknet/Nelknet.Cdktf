using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration")]
    public class HdinsightKafkaClusterPrivateLinkConfiguration : azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#group_id HdinsightKafkaCluster#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupId
        {
            get;
            set;
        }

        /// <summary>ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#ip_configuration HdinsightKafkaCluster#ip_configuration}
        /// </remarks>
        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration\"}")]
        public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration IpConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#name HdinsightKafkaCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
