using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHbaseClusterMetastores), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastores")]
    public interface IHdinsightHbaseClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#ambari HdinsightHbaseCluster#ambari}
        /// </remarks>
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresAmbari\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresAmbari? Ambari
        {
            get
            {
                return null;
            }
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#hive HdinsightHbaseCluster#hive}
        /// </remarks>
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresHive\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresHive? Hive
        {
            get
            {
                return null;
            }
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#oozie HdinsightHbaseCluster#oozie}
        /// </remarks>
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOozie\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresOozie? Oozie
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHbaseClusterMetastores), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastores")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastores
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ambari block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#ambari HdinsightHbaseCluster#ambari}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresAmbari\"}", isOptional: true)]
            public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresAmbari? Ambari
            {
                get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresAmbari?>();
            }

            /// <summary>hive block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#hive HdinsightHbaseCluster#hive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresHive\"}", isOptional: true)]
            public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresHive? Hive
            {
                get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresHive?>();
            }

            /// <summary>oozie block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#oozie HdinsightHbaseCluster#oozie}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterMetastoresOozie\"}", isOptional: true)]
            public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresOozie? Oozie
            {
                get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterMetastoresOozie?>();
            }
        }
    }
}
