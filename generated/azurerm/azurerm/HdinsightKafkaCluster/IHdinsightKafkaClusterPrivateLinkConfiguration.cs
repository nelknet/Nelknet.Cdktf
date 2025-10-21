using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightKafkaClusterPrivateLinkConfiguration), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration")]
    public interface IHdinsightKafkaClusterPrivateLinkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#group_id HdinsightKafkaCluster#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        string GroupId
        {
            get;
        }

        /// <summary>ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#ip_configuration HdinsightKafkaCluster#ip_configuration}
        /// </remarks>
        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration\"}")]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration IpConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#name HdinsightKafkaCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightKafkaClusterPrivateLinkConfiguration), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#group_id HdinsightKafkaCluster#group_id}.</summary>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ip_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#ip_configuration HdinsightKafkaCluster#ip_configuration}
            /// </remarks>
            [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration\"}")]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration IpConfiguration
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterPrivateLinkConfigurationIpConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#name HdinsightKafkaCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
