using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightSparkClusterMetastores), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastores")]
    public interface IHdinsightSparkClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#ambari HdinsightSparkCluster#ambari}
        /// </remarks>
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresAmbari\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresAmbari? Ambari
        {
            get
            {
                return null;
            }
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#hive HdinsightSparkCluster#hive}
        /// </remarks>
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresHive\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresHive? Hive
        {
            get
            {
                return null;
            }
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#oozie HdinsightSparkCluster#oozie}
        /// </remarks>
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresOozie\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresOozie? Oozie
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightSparkClusterMetastores), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastores")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastores
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ambari block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#ambari HdinsightSparkCluster#ambari}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresAmbari\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresAmbari? Ambari
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresAmbari?>();
            }

            /// <summary>hive block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#hive HdinsightSparkCluster#hive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresHive\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresHive? Hive
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresHive?>();
            }

            /// <summary>oozie block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#oozie HdinsightSparkCluster#oozie}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastoresOozie\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresOozie? Oozie
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastoresOozie?>();
            }
        }
    }
}
