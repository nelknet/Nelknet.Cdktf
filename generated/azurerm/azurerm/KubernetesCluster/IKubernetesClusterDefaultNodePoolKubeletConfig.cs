using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterDefaultNodePoolKubeletConfig), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfig")]
    public interface IKubernetesClusterDefaultNodePoolKubeletConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#allowed_unsafe_sysctls KubernetesCluster#allowed_unsafe_sysctls}.</summary>
        [JsiiProperty(name: "allowedUnsafeSysctls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedUnsafeSysctls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#container_log_max_line KubernetesCluster#container_log_max_line}.</summary>
        [JsiiProperty(name: "containerLogMaxLine", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ContainerLogMaxLine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#container_log_max_size_mb KubernetesCluster#container_log_max_size_mb}.</summary>
        [JsiiProperty(name: "containerLogMaxSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ContainerLogMaxSizeMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cpu_cfs_quota_enabled KubernetesCluster#cpu_cfs_quota_enabled}.</summary>
        [JsiiProperty(name: "cpuCfsQuotaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CpuCfsQuotaEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cpu_cfs_quota_period KubernetesCluster#cpu_cfs_quota_period}.</summary>
        [JsiiProperty(name: "cpuCfsQuotaPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpuCfsQuotaPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cpu_manager_policy KubernetesCluster#cpu_manager_policy}.</summary>
        [JsiiProperty(name: "cpuManagerPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpuManagerPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_gc_high_threshold KubernetesCluster#image_gc_high_threshold}.</summary>
        [JsiiProperty(name: "imageGcHighThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ImageGcHighThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_gc_low_threshold KubernetesCluster#image_gc_low_threshold}.</summary>
        [JsiiProperty(name: "imageGcLowThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ImageGcLowThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_max_pid KubernetesCluster#pod_max_pid}.</summary>
        [JsiiProperty(name: "podMaxPid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PodMaxPid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#topology_manager_policy KubernetesCluster#topology_manager_policy}.</summary>
        [JsiiProperty(name: "topologyManagerPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TopologyManagerPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterDefaultNodePoolKubeletConfig), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#allowed_unsafe_sysctls KubernetesCluster#allowed_unsafe_sysctls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedUnsafeSysctls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedUnsafeSysctls
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#container_log_max_line KubernetesCluster#container_log_max_line}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerLogMaxLine", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ContainerLogMaxLine
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#container_log_max_size_mb KubernetesCluster#container_log_max_size_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerLogMaxSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ContainerLogMaxSizeMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cpu_cfs_quota_enabled KubernetesCluster#cpu_cfs_quota_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuCfsQuotaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CpuCfsQuotaEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cpu_cfs_quota_period KubernetesCluster#cpu_cfs_quota_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuCfsQuotaPeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpuCfsQuotaPeriod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cpu_manager_policy KubernetesCluster#cpu_manager_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuManagerPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpuManagerPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_gc_high_threshold KubernetesCluster#image_gc_high_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageGcHighThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ImageGcHighThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_gc_low_threshold KubernetesCluster#image_gc_low_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageGcLowThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ImageGcLowThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_max_pid KubernetesCluster#pod_max_pid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "podMaxPid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PodMaxPid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#topology_manager_policy KubernetesCluster#topology_manager_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "topologyManagerPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TopologyManagerPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
