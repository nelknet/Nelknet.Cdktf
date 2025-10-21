using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterNetworkProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterNetworkProfile")]
    public interface IKubernetesClusterNetworkProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_plugin KubernetesCluster#network_plugin}.</summary>
        [JsiiProperty(name: "networkPlugin", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkPlugin
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_service_ip KubernetesCluster#dns_service_ip}.</summary>
        [JsiiProperty(name: "dnsServiceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsServiceIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ip_versions KubernetesCluster#ip_versions}.</summary>
        [JsiiProperty(name: "ipVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpVersions
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancer_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#load_balancer_profile KubernetesCluster#load_balancer_profile}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile? LoadBalancerProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#load_balancer_sku KubernetesCluster#load_balancer_sku}.</summary>
        [JsiiProperty(name: "loadBalancerSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancerSku
        {
            get
            {
                return null;
            }
        }

        /// <summary>nat_gateway_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#nat_gateway_profile KubernetesCluster#nat_gateway_profile}
        /// </remarks>
        [JsiiProperty(name: "natGatewayProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile? NatGatewayProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_data_plane KubernetesCluster#network_data_plane}.</summary>
        [JsiiProperty(name: "networkDataPlane", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkDataPlane
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_mode KubernetesCluster#network_mode}.</summary>
        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_plugin_mode KubernetesCluster#network_plugin_mode}.</summary>
        [JsiiProperty(name: "networkPluginMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkPluginMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_policy KubernetesCluster#network_policy}.</summary>
        [JsiiProperty(name: "networkPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#outbound_type KubernetesCluster#outbound_type}.</summary>
        [JsiiProperty(name: "outboundType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_cidr KubernetesCluster#pod_cidr}.</summary>
        [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PodCidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_cidrs KubernetesCluster#pod_cidrs}.</summary>
        [JsiiProperty(name: "podCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PodCidrs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_cidr KubernetesCluster#service_cidr}.</summary>
        [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceCidr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_cidrs KubernetesCluster#service_cidrs}.</summary>
        [JsiiProperty(name: "serviceCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ServiceCidrs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterNetworkProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterNetworkProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_plugin KubernetesCluster#network_plugin}.</summary>
            [JsiiProperty(name: "networkPlugin", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkPlugin
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_service_ip KubernetesCluster#dns_service_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsServiceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsServiceIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ip_versions KubernetesCluster#ip_versions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpVersions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>load_balancer_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#load_balancer_profile KubernetesCluster#load_balancer_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile? LoadBalancerProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#load_balancer_sku KubernetesCluster#load_balancer_sku}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancerSku
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>nat_gateway_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#nat_gateway_profile KubernetesCluster#nat_gateway_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "natGatewayProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile? NatGatewayProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_data_plane KubernetesCluster#network_data_plane}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkDataPlane", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkDataPlane
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_mode KubernetesCluster#network_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_plugin_mode KubernetesCluster#network_plugin_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkPluginMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkPluginMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_policy KubernetesCluster#network_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#outbound_type KubernetesCluster#outbound_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_cidr KubernetesCluster#pod_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PodCidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_cidrs KubernetesCluster#pod_cidrs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "podCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PodCidrs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_cidr KubernetesCluster#service_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceCidr
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_cidrs KubernetesCluster#service_cidrs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ServiceCidrs
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
