using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricManagedCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationActiveDirectory")]
    public class ServiceFabricManagedClusterAuthenticationActiveDirectory : azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#client_application_id ServiceFabricManagedCluster#client_application_id}.</summary>
        [JsiiProperty(name: "clientApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientApplicationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#cluster_application_id ServiceFabricManagedCluster#cluster_application_id}.</summary>
        [JsiiProperty(name: "clusterApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterApplicationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#tenant_id ServiceFabricManagedCluster#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantId
        {
            get;
            set;
        }
    }
}
