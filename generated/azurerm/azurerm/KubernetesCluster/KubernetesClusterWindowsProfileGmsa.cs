using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterWindowsProfileGmsa")]
    public class KubernetesClusterWindowsProfileGmsa : azurerm.KubernetesCluster.IKubernetesClusterWindowsProfileGmsa
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_server KubernetesCluster#dns_server}.</summary>
        [JsiiProperty(name: "dnsServer", typeJson: "{\"primitive\":\"string\"}")]
        public string DnsServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#root_domain KubernetesCluster#root_domain}.</summary>
        [JsiiProperty(name: "rootDomain", typeJson: "{\"primitive\":\"string\"}")]
        public string RootDomain
        {
            get;
            set;
        }
    }
}
