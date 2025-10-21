using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterUpgradePolicyHealthPolicy), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicy")]
    public interface IServiceFabricClusterUpgradePolicyHealthPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_unhealthy_applications_percent ServiceFabricCluster#max_unhealthy_applications_percent}.</summary>
        [JsiiProperty(name: "maxUnhealthyApplicationsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnhealthyApplicationsPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_unhealthy_nodes_percent ServiceFabricCluster#max_unhealthy_nodes_percent}.</summary>
        [JsiiProperty(name: "maxUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnhealthyNodesPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterUpgradePolicyHealthPolicy), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyHealthPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicyHealthPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_unhealthy_applications_percent ServiceFabricCluster#max_unhealthy_applications_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnhealthyApplicationsPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnhealthyApplicationsPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#max_unhealthy_nodes_percent ServiceFabricCluster#max_unhealthy_nodes_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnhealthyNodesPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnhealthyNodesPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
