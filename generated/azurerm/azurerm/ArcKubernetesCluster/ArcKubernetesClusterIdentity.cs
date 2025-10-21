using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.arcKubernetesCluster.ArcKubernetesClusterIdentity")]
    public class ArcKubernetesClusterIdentity : azurerm.ArcKubernetesCluster.IArcKubernetesClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#type ArcKubernetesCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
