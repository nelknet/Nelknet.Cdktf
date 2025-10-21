using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunStageGroup")]
    public class KubernetesFleetUpdateRunStageGroup : azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunStageGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#name KubernetesFleetUpdateRun#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
