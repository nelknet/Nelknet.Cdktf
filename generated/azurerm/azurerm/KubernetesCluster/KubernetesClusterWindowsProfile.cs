using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterWindowsProfile")]
    public class KubernetesClusterWindowsProfile : azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#admin_password KubernetesCluster#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#admin_username KubernetesCluster#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminUsername
        {
            get;
            set;
        }

        /// <summary>gmsa block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#gmsa KubernetesCluster#gmsa}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gmsa", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfileGmsa\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterWindowsProfileGmsa? Gmsa
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#license KubernetesCluster#license}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "license", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? License
        {
            get;
            set;
        }
    }
}
