using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterWebAppRouting")]
    public class KubernetesClusterWebAppRouting : azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_zone_ids KubernetesCluster#dns_zone_ids}.</summary>
        [JsiiProperty(name: "dnsZoneIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DnsZoneIds
        {
            get;
            set;
        }
    }
}
