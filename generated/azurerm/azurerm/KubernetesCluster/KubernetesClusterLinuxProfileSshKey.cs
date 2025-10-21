using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKey")]
    public class KubernetesClusterLinuxProfileSshKey : azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_data KubernetesCluster#key_data}.</summary>
        [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyData
        {
            get;
            set;
        }
    }
}
