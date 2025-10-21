using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfile")]
    public class KubernetesClusterNetworkProfileNatGatewayProfile : azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#idle_timeout_in_minutes KubernetesCluster#idle_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IdleTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#managed_outbound_ip_count KubernetesCluster#managed_outbound_ip_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedOutboundIpCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ManagedOutboundIpCount
        {
            get;
            set;
        }
    }
}
