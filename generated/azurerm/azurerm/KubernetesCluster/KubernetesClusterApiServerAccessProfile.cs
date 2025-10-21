using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterApiServerAccessProfile")]
    public class KubernetesClusterApiServerAccessProfile : azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#authorized_ip_ranges KubernetesCluster#authorized_ip_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizedIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AuthorizedIpRanges
        {
            get;
            set;
        }
    }
}
