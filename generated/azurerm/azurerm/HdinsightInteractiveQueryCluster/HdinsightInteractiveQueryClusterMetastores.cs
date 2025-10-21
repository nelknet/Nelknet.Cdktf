using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastores")]
    public class HdinsightInteractiveQueryClusterMetastores : azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores
    {
        /// <summary>ambari block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#ambari HdinsightInteractiveQueryCluster#ambari}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ambari", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresAmbari\"}", isOptional: true)]
        public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresAmbari? Ambari
        {
            get;
            set;
        }

        /// <summary>hive block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#hive HdinsightInteractiveQueryCluster#hive}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hive", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresHive\"}", isOptional: true)]
        public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresHive? Hive
        {
            get;
            set;
        }

        /// <summary>oozie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#oozie HdinsightInteractiveQueryCluster#oozie}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oozie", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastoresOozie\"}", isOptional: true)]
        public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastoresOozie? Oozie
        {
            get;
            set;
        }
    }
}
