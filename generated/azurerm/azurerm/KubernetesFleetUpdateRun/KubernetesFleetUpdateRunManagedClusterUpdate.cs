using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdate")]
    public class KubernetesFleetUpdateRunManagedClusterUpdate : azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate
    {
        /// <summary>upgrade block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#upgrade KubernetesFleetUpdateRun#upgrade}
        /// </remarks>
        [JsiiProperty(name: "upgrade", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateUpgrade\"}")]
        public azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateUpgrade Upgrade
        {
            get;
            set;
        }

        /// <summary>node_image_selection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#node_image_selection KubernetesFleetUpdateRun#node_image_selection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeImageSelection", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelection\"}", isOptional: true)]
        public azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdateNodeImageSelection? NodeImageSelection
        {
            get;
            set;
        }
    }
}
