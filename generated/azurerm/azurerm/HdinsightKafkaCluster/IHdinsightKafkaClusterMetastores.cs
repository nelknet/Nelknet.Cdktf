using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightKafkaClusterMetastores), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastores")]
    public interface IHdinsightKafkaClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#ambari HdinsightKafkaCluster#ambari}
        /// </remarks>
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresAmbari\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresAmbari? Ambari
        {
            get
            {
                return null;
            }
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#hive HdinsightKafkaCluster#hive}
        /// </remarks>
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresHive\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresHive? Hive
        {
            get
            {
                return null;
            }
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#oozie HdinsightKafkaCluster#oozie}
        /// </remarks>
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOozie\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresOozie? Oozie
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightKafkaClusterMetastores), fullyQualifiedName: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastores")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastores
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ambari block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#ambari HdinsightKafkaCluster#ambari}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresAmbari\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresAmbari? Ambari
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresAmbari?>();
            }

            /// <summary>hive block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#hive HdinsightKafkaCluster#hive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresHive\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresHive? Hive
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresHive?>();
            }

            /// <summary>oozie block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#oozie HdinsightKafkaCluster#oozie}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterMetastoresOozie\"}", isOptional: true)]
            public azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresOozie? Oozie
            {
                get => GetInstanceProperty<azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterMetastoresOozie?>();
            }
        }
    }
}
