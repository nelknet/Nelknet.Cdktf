using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateStrategy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesFleetUpdateStrategy.KubernetesFleetUpdateStrategyStageGroup")]
    public class KubernetesFleetUpdateStrategyStageGroup : azurerm.KubernetesFleetUpdateStrategy.IKubernetesFleetUpdateStrategyStageGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_strategy#name KubernetesFleetUpdateStrategy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
