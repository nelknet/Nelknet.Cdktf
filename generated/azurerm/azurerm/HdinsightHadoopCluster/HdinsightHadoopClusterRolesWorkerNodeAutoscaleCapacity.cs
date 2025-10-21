using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity")]
    public class HdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesWorkerNodeAutoscaleCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#max_instance_count HdinsightHadoopCluster#max_instance_count}.</summary>
        [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxInstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#min_instance_count HdinsightHadoopCluster#min_instance_count}.</summary>
        [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinInstanceCount
        {
            get;
            set;
        }
    }
}
