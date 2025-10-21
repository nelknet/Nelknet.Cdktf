using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterLinuxProfile")]
    public class KubernetesClusterLinuxProfile : azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#admin_username KubernetesCluster#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminUsername
        {
            get;
            set;
        }

        /// <summary>ssh_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ssh_key KubernetesCluster#ssh_key}
        /// </remarks>
        [JsiiProperty(name: "sshKey", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKey\"}")]
        public azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey SshKey
        {
            get;
            set;
        }
    }
}
