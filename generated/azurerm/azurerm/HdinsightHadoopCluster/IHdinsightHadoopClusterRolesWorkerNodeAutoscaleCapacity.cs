using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity")]
    public interface IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#max_instance_count HdinsightHadoopCluster#max_instance_count}.</summary>
        [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaxInstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#min_instance_count HdinsightHadoopCluster#min_instance_count}.</summary>
        [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinInstanceCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#max_instance_count HdinsightHadoopCluster#max_instance_count}.</summary>
            [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#min_instance_count HdinsightHadoopCluster#min_instance_count}.</summary>
            [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
