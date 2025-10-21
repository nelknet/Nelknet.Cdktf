using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateUpgrade")]
    public class KubernetesFleetUpdateRunManagedClusterUpdateUpgrade : azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateUpgrade
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#type KubernetesFleetUpdateRun#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#kubernetes_version KubernetesFleetUpdateRun#kubernetes_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KubernetesVersion
        {
            get;
            set;
        }
    }
}
