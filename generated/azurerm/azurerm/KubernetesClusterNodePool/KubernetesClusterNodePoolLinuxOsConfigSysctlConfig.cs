using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterNodePool
{
    [JsiiByValue(fqn: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfigSysctlConfig")]
    public class KubernetesClusterNodePoolLinuxOsConfigSysctlConfig : azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolLinuxOsConfigSysctlConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#fs_aio_max_nr KubernetesClusterNodePool#fs_aio_max_nr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fsAioMaxNr", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FsAioMaxNr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#fs_file_max KubernetesClusterNodePool#fs_file_max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fsFileMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FsFileMax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#fs_inotify_max_user_watches KubernetesClusterNodePool#fs_inotify_max_user_watches}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fsInotifyMaxUserWatches", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FsInotifyMaxUserWatches
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#fs_nr_open KubernetesClusterNodePool#fs_nr_open}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fsNrOpen", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FsNrOpen
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#kernel_threads_max KubernetesClusterNodePool#kernel_threads_max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kernelThreadsMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KernelThreadsMax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_core_netdev_max_backlog KubernetesClusterNodePool#net_core_netdev_max_backlog}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netCoreNetdevMaxBacklog", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetCoreNetdevMaxBacklog
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_core_optmem_max KubernetesClusterNodePool#net_core_optmem_max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netCoreOptmemMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetCoreOptmemMax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_core_rmem_default KubernetesClusterNodePool#net_core_rmem_default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netCoreRmemDefault", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetCoreRmemDefault
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_core_rmem_max KubernetesClusterNodePool#net_core_rmem_max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netCoreRmemMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetCoreRmemMax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_core_somaxconn KubernetesClusterNodePool#net_core_somaxconn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netCoreSomaxconn", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetCoreSomaxconn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_core_wmem_default KubernetesClusterNodePool#net_core_wmem_default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netCoreWmemDefault", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetCoreWmemDefault
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_core_wmem_max KubernetesClusterNodePool#net_core_wmem_max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netCoreWmemMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetCoreWmemMax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_ip_local_port_range_max KubernetesClusterNodePool#net_ipv4_ip_local_port_range_max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4IpLocalPortRangeMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4IpLocalPortRangeMax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_ip_local_port_range_min KubernetesClusterNodePool#net_ipv4_ip_local_port_range_min}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4IpLocalPortRangeMin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4IpLocalPortRangeMin
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_neigh_default_gc_thresh1 KubernetesClusterNodePool#net_ipv4_neigh_default_gc_thresh1}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh1", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4NeighDefaultGcThresh1
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_neigh_default_gc_thresh2 KubernetesClusterNodePool#net_ipv4_neigh_default_gc_thresh2}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh2", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4NeighDefaultGcThresh2
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_neigh_default_gc_thresh3 KubernetesClusterNodePool#net_ipv4_neigh_default_gc_thresh3}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4NeighDefaultGcThresh3", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4NeighDefaultGcThresh3
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_tcp_fin_timeout KubernetesClusterNodePool#net_ipv4_tcp_fin_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpFinTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4TcpFinTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_tcp_keepalive_intvl KubernetesClusterNodePool#net_ipv4_tcp_keepalive_intvl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpKeepaliveIntvl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4TcpKeepaliveIntvl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_tcp_keepalive_probes KubernetesClusterNodePool#net_ipv4_tcp_keepalive_probes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpKeepaliveProbes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4TcpKeepaliveProbes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_tcp_keepalive_time KubernetesClusterNodePool#net_ipv4_tcp_keepalive_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpKeepaliveTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4TcpKeepaliveTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_tcp_max_syn_backlog KubernetesClusterNodePool#net_ipv4_tcp_max_syn_backlog}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpMaxSynBacklog", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4TcpMaxSynBacklog
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_tcp_max_tw_buckets KubernetesClusterNodePool#net_ipv4_tcp_max_tw_buckets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpMaxTwBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetIpv4TcpMaxTwBuckets
        {
            get;
            set;
        }

        private object? _netIpv4TcpTwReuse;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_ipv4_tcp_tw_reuse KubernetesClusterNodePool#net_ipv4_tcp_tw_reuse}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netIpv4TcpTwReuse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? NetIpv4TcpTwReuse
        {
            get => _netIpv4TcpTwReuse;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _netIpv4TcpTwReuse = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_netfilter_nf_conntrack_buckets KubernetesClusterNodePool#net_netfilter_nf_conntrack_buckets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netNetfilterNfConntrackBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetNetfilterNfConntrackBuckets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#net_netfilter_nf_conntrack_max KubernetesClusterNodePool#net_netfilter_nf_conntrack_max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netNetfilterNfConntrackMax", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NetNetfilterNfConntrackMax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#vm_max_map_count KubernetesClusterNodePool#vm_max_map_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmMaxMapCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VmMaxMapCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#vm_swappiness KubernetesClusterNodePool#vm_swappiness}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmSwappiness", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VmSwappiness
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#vm_vfs_cache_pressure KubernetesClusterNodePool#vm_vfs_cache_pressure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmVfsCachePressure", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VmVfsCachePressure
        {
            get;
            set;
        }
    }
}
