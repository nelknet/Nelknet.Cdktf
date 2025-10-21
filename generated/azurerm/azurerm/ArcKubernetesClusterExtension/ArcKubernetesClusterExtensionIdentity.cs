using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesClusterExtension
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.arcKubernetesClusterExtension.ArcKubernetesClusterExtensionIdentity")]
    public class ArcKubernetesClusterExtensionIdentity : azurerm.ArcKubernetesClusterExtension.IArcKubernetesClusterExtensionIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#type ArcKubernetesClusterExtension#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
