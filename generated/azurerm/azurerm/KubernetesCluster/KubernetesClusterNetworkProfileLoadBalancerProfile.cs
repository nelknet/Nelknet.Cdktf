using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfile")]
    public class KubernetesClusterNetworkProfileLoadBalancerProfile : azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#managed_outbound_ipv6_count KubernetesCluster#managed_outbound_ipv6_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedOutboundIpv6Count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ManagedOutboundIpv6Count
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#outbound_ip_address_ids KubernetesCluster#outbound_ip_address_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundIpAddressIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OutboundIpAddressIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#outbound_ip_prefix_ids KubernetesCluster#outbound_ip_prefix_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundIpPrefixIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OutboundIpPrefixIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#outbound_ports_allocated KubernetesCluster#outbound_ports_allocated}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundPortsAllocated", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OutboundPortsAllocated
        {
            get;
            set;
        }
    }
}
