using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicy")]
    public class ServiceFabricClusterUpgradePolicyHealthPolicy : azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_unhealthy_applications_percent ServiceFabricCluster#max_unhealthy_applications_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnhealthyApplicationsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnhealthyApplicationsPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_unhealthy_nodes_percent ServiceFabricCluster#max_unhealthy_nodes_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnhealthyNodesPercent
        {
            get;
            set;
        }
    }
}
