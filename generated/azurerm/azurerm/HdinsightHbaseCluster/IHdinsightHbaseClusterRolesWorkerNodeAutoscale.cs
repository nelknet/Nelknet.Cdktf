using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHbaseCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHbaseClusterRolesWorkerNodeAutoscale), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeAutoscale")]
    public interface IHdinsightHbaseClusterRolesWorkerNodeAutoscale
    {
        /// <summary>recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#recurrence HdinsightHbaseCluster#recurrence}
        /// </remarks>
        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeAutoscaleRecurrence\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNodeAutoscaleRecurrence? Recurrence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHbaseClusterRolesWorkerNodeAutoscale), fullyQualifiedName: "azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeAutoscale")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNodeAutoscale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>recurrence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#recurrence HdinsightHbaseCluster#recurrence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.hdinsightHbaseCluster.HdinsightHbaseClusterRolesWorkerNodeAutoscaleRecurrence\"}", isOptional: true)]
            public azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNodeAutoscaleRecurrence? Recurrence
            {
                get => GetInstanceProperty<azurerm.HdinsightHbaseCluster.IHdinsightHbaseClusterRolesWorkerNodeAutoscaleRecurrence?>();
            }
        }
    }
}
