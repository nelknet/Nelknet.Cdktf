using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightKafkaClusterRestProxy), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRestProxy")]
    public interface IHdinsightKafkaClusterRestProxy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#security_group_id HdinsightKafkaCluster#security_group_id}.</summary>
        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string SecurityGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#security_group_name HdinsightKafkaCluster#security_group_name}.</summary>
        [JsiiProperty(name: "securityGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string SecurityGroupName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightKafkaClusterRestProxy), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterRestProxy")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterRestProxy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#security_group_id HdinsightKafkaCluster#security_group_id}.</summary>
            [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecurityGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#security_group_name HdinsightKafkaCluster#security_group_name}.</summary>
            [JsiiProperty(name: "securityGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecurityGroupName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
