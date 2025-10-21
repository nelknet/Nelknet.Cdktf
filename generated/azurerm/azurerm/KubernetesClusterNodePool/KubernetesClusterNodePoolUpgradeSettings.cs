using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterNodePool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolUpgradeSettings")]
    public class KubernetesClusterNodePoolUpgradeSettings : azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolUpgradeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#max_surge KubernetesClusterNodePool#max_surge}.</summary>
        [JsiiProperty(name: "maxSurge", typeJson: "{\"primitive\":\"string\"}")]
        public string MaxSurge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#drain_timeout_in_minutes KubernetesClusterNodePool#drain_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drainTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DrainTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#node_soak_duration_in_minutes KubernetesClusterNodePool#node_soak_duration_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeSoakDurationInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NodeSoakDurationInMinutes
        {
            get;
            set;
        }
    }
}
