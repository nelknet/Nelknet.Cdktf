using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHadoopClusterMetastores), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastores")]
    public interface IHdinsightHadoopClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#ambari HdinsightHadoopCluster#ambari}
        /// </remarks>
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresAmbari\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresAmbari? Ambari
        {
            get
            {
                return null;
            }
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#hive HdinsightHadoopCluster#hive}
        /// </remarks>
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresHive\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresHive? Hive
        {
            get
            {
                return null;
            }
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#oozie HdinsightHadoopCluster#oozie}
        /// </remarks>
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresOozie\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresOozie? Oozie
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHadoopClusterMetastores), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastores")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastores
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ambari block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#ambari HdinsightHadoopCluster#ambari}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresAmbari\"}", isOptional: true)]
            public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresAmbari? Ambari
            {
                get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresAmbari?>();
            }

            /// <summary>hive block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#hive HdinsightHadoopCluster#hive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresHive\"}", isOptional: true)]
            public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresHive? Hive
            {
                get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresHive?>();
            }

            /// <summary>oozie block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#oozie HdinsightHadoopCluster#oozie}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterMetastoresOozie\"}", isOptional: true)]
            public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresOozie? Oozie
            {
                get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterMetastoresOozie?>();
            }
        }
    }
}
