using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightInteractiveQueryClusterMetastores), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastores")]
    public interface IHdinsightInteractiveQueryClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#ambari HdinsightInteractiveQueryCluster#ambari}
        /// </remarks>
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresAmbari\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresAmbari? Ambari
        {
            get
            {
                return null;
            }
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#hive HdinsightInteractiveQueryCluster#hive}
        /// </remarks>
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresHive\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresHive? Hive
        {
            get
            {
                return null;
            }
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#oozie HdinsightInteractiveQueryCluster#oozie}
        /// </remarks>
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresOozie\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresOozie? Oozie
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightInteractiveQueryClusterMetastores), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastores")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ambari block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#ambari HdinsightInteractiveQueryCluster#ambari}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresAmbari\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresAmbari? Ambari
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresAmbari?>();
            }

            /// <summary>hive block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#hive HdinsightInteractiveQueryCluster#hive}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresHive\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresHive? Hive
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresHive?>();
            }

            /// <summary>oozie block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#oozie HdinsightInteractiveQueryCluster#oozie}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresOozie\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresOozie? Oozie
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresOozie?>();
            }
        }
    }
}
