using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterNodePool
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterNodePoolLinuxOsConfig), fullyQualifiedName: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfig")]
    public interface IKubernetesClusterNodePoolLinuxOsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#swap_file_size_mb KubernetesClusterNodePool#swap_file_size_mb}.</summary>
        [JsiiProperty(name: "swapFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SwapFileSizeMb
        {
            get
            {
                return null;
            }
        }

        /// <summary>sysctl_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#sysctl_config KubernetesClusterNodePool#sysctl_config}
        /// </remarks>
        [JsiiProperty(name: "sysctlConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfigSysctlConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolLinuxOsConfigSysctlConfig? SysctlConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#transparent_huge_page_defrag KubernetesClusterNodePool#transparent_huge_page_defrag}.</summary>
        [JsiiProperty(name: "transparentHugePageDefrag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransparentHugePageDefrag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#transparent_huge_page_enabled KubernetesClusterNodePool#transparent_huge_page_enabled}.</summary>
        [JsiiProperty(name: "transparentHugePageEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransparentHugePageEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterNodePoolLinuxOsConfig), fullyQualifiedName: "azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolLinuxOsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#swap_file_size_mb KubernetesClusterNodePool#swap_file_size_mb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "swapFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SwapFileSizeMb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>sysctl_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#sysctl_config KubernetesClusterNodePool#sysctl_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sysctlConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfigSysctlConfig\"}", isOptional: true)]
            public azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolLinuxOsConfigSysctlConfig? SysctlConfig
            {
                get => GetInstanceProperty<azurerm.KubernetesClusterNodePool.IKubernetesClusterNodePoolLinuxOsConfigSysctlConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#transparent_huge_page_defrag KubernetesClusterNodePool#transparent_huge_page_defrag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transparentHugePageDefrag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransparentHugePageDefrag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#transparent_huge_page_enabled KubernetesClusterNodePool#transparent_huge_page_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transparentHugePageEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransparentHugePageEnabled
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
