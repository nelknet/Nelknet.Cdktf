using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux")]
    public class KubernetesClusterAciConnectorLinux : azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#subnet_name KubernetesCluster#subnet_name}.</summary>
        [JsiiProperty(name: "subnetName", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetName
        {
            get;
            set;
        }
    }
}
