using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterNodePool
{
    [JsiiByValue(fqn: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolKubeletConfig")]
    public class KubernetesClusterNodePoolKubeletConfig : azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolKubeletConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#allowed_unsafe_sysctls KubernetesClusterNodePool#allowed_unsafe_sysctls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedUnsafeSysctls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedUnsafeSysctls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#container_log_max_line KubernetesClusterNodePool#container_log_max_line}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerLogMaxLine", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ContainerLogMaxLine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#container_log_max_size_mb KubernetesClusterNodePool#container_log_max_size_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerLogMaxSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ContainerLogMaxSizeMb
        {
            get;
            set;
        }

        private object? _cpuCfsQuotaEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#cpu_cfs_quota_enabled KubernetesClusterNodePool#cpu_cfs_quota_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuCfsQuotaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CpuCfsQuotaEnabled
        {
            get => _cpuCfsQuotaEnabled;
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
                _cpuCfsQuotaEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#cpu_cfs_quota_period KubernetesClusterNodePool#cpu_cfs_quota_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuCfsQuotaPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuCfsQuotaPeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#cpu_manager_policy KubernetesClusterNodePool#cpu_manager_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuManagerPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuManagerPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#image_gc_high_threshold KubernetesClusterNodePool#image_gc_high_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageGcHighThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImageGcHighThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#image_gc_low_threshold KubernetesClusterNodePool#image_gc_low_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageGcLowThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImageGcLowThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#pod_max_pid KubernetesClusterNodePool#pod_max_pid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "podMaxPid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PodMaxPid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#topology_manager_policy KubernetesClusterNodePool#topology_manager_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topologyManagerPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TopologyManagerPolicy
        {
            get;
            set;
        }
    }
}
