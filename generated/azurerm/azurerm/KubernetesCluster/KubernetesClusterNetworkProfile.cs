using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterNetworkProfile")]
    public class KubernetesClusterNetworkProfile : azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_plugin KubernetesCluster#network_plugin}.</summary>
        [JsiiProperty(name: "networkPlugin", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkPlugin
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_service_ip KubernetesCluster#dns_service_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsServiceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsServiceIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ip_versions KubernetesCluster#ip_versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpVersions
        {
            get;
            set;
        }

        /// <summary>load_balancer_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#load_balancer_profile KubernetesCluster#load_balancer_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile? LoadBalancerProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#load_balancer_sku KubernetesCluster#load_balancer_sku}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancerSku
        {
            get;
            set;
        }

        /// <summary>nat_gateway_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#nat_gateway_profile KubernetesCluster#nat_gateway_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "natGatewayProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile? NatGatewayProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_data_plane KubernetesCluster#network_data_plane}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkDataPlane", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkDataPlane
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_mode KubernetesCluster#network_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_plugin_mode KubernetesCluster#network_plugin_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkPluginMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkPluginMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_policy KubernetesCluster#network_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#outbound_type KubernetesCluster#outbound_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_cidr KubernetesCluster#pod_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PodCidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_cidrs KubernetesCluster#pod_cidrs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "podCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PodCidrs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_cidr KubernetesCluster#service_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceCidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_cidrs KubernetesCluster#service_cidrs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ServiceCidrs
        {
            get;
            set;
        }
    }
}
