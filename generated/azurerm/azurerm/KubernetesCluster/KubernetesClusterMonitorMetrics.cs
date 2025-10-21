using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterMonitorMetrics")]
    public class KubernetesClusterMonitorMetrics : azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#annotations_allowed KubernetesCluster#annotations_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "annotationsAllowed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AnnotationsAllowed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#labels_allowed KubernetesCluster#labels_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labelsAllowed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LabelsAllowed
        {
            get;
            set;
        }
    }
}
