using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHbaseClusterExtension), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterExtension")]
    public interface IHdinsightHbaseClusterExtension
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#log_analytics_workspace_id HdinsightHbaseCluster#log_analytics_workspace_id}.</summary>
        [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
        string LogAnalyticsWorkspaceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#primary_key HdinsightHbaseCluster#primary_key}.</summary>
        [JsiiProperty(name: "primaryKey", typeJson: "{\"primitive\":\"string\"}")]
        string PrimaryKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHbaseClusterExtension), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterExtension")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterExtension
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#log_analytics_workspace_id HdinsightHbaseCluster#log_analytics_workspace_id}.</summary>
            [JsiiProperty(name: "logAnalyticsWorkspaceId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogAnalyticsWorkspaceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#primary_key HdinsightHbaseCluster#primary_key}.</summary>
            [JsiiProperty(name: "primaryKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PrimaryKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
