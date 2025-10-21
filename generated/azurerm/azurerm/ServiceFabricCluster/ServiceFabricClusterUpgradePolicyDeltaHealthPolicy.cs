using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy")]
    public class ServiceFabricClusterUpgradePolicyDeltaHealthPolicy : azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_delta_unhealthy_applications_percent ServiceFabricCluster#max_delta_unhealthy_applications_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDeltaUnhealthyApplicationsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDeltaUnhealthyApplicationsPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_delta_unhealthy_nodes_percent ServiceFabricCluster#max_delta_unhealthy_nodes_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDeltaUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDeltaUnhealthyNodesPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_upgrade_domain_delta_unhealthy_nodes_percent ServiceFabricCluster#max_upgrade_domain_delta_unhealthy_nodes_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUpgradeDomainDeltaUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUpgradeDomainDeltaUnhealthyNodesPercent
        {
            get;
            set;
        }
    }
}
