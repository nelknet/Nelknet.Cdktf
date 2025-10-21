using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetManager
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesFleetManager.KubernetesFleetManagerHubProfile")]
    public class KubernetesFleetManagerHubProfile : azurerm.KubernetesFleetManager.IKubernetesFleetManagerHubProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#dns_prefix KubernetesFleetManager#dns_prefix}.</summary>
        [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string DnsPrefix
        {
            get;
            set;
        }
    }
}
