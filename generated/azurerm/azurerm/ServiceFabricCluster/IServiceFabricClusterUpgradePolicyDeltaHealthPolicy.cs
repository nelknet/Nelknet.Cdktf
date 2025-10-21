using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterUpgradePolicyDeltaHealthPolicy), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy")]
    public interface IServiceFabricClusterUpgradePolicyDeltaHealthPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_delta_unhealthy_applications_percent ServiceFabricCluster#max_delta_unhealthy_applications_percent}.</summary>
        [JsiiProperty(name: "maxDeltaUnhealthyApplicationsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxDeltaUnhealthyApplicationsPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_delta_unhealthy_nodes_percent ServiceFabricCluster#max_delta_unhealthy_nodes_percent}.</summary>
        [JsiiProperty(name: "maxDeltaUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxDeltaUnhealthyNodesPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_upgrade_domain_delta_unhealthy_nodes_percent ServiceFabricCluster#max_upgrade_domain_delta_unhealthy_nodes_percent}.</summary>
        [JsiiProperty(name: "maxUpgradeDomainDeltaUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUpgradeDomainDeltaUnhealthyNodesPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterUpgradePolicyDeltaHealthPolicy), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyDeltaHealthPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyDeltaHealthPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_delta_unhealthy_applications_percent ServiceFabricCluster#max_delta_unhealthy_applications_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDeltaUnhealthyApplicationsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDeltaUnhealthyApplicationsPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_delta_unhealthy_nodes_percent ServiceFabricCluster#max_delta_unhealthy_nodes_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDeltaUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDeltaUnhealthyNodesPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_upgrade_domain_delta_unhealthy_nodes_percent ServiceFabricCluster#max_upgrade_domain_delta_unhealthy_nodes_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUpgradeDomainDeltaUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUpgradeDomainDeltaUnhealthyNodesPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
