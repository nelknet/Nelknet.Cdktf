using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfig")]
    public class KubernetesClusterDefaultNodePoolLinuxOsConfig : azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#swap_file_size_mb KubernetesCluster#swap_file_size_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "swapFileSizeMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SwapFileSizeMb
        {
            get;
            set;
        }

        /// <summary>sysctl_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#sysctl_config KubernetesCluster#sysctl_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sysctlConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfig\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfig? SysctlConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#transparent_huge_page_defrag KubernetesCluster#transparent_huge_page_defrag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transparentHugePageDefrag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransparentHugePageDefrag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#transparent_huge_page_enabled KubernetesCluster#transparent_huge_page_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transparentHugePageEnabled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransparentHugePageEnabled
        {
            get;
            set;
        }
    }
}
