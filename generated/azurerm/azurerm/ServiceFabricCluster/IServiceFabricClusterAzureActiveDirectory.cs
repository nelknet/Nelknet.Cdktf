using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterAzureActiveDirectory), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterAzureActiveDirectory")]
    public interface IServiceFabricClusterAzureActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_application_id ServiceFabricCluster#client_application_id}.</summary>
        [JsiiProperty(name: "clientApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientApplicationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#cluster_application_id ServiceFabricCluster#cluster_application_id}.</summary>
        [JsiiProperty(name: "clusterApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterApplicationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#tenant_id ServiceFabricCluster#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        string TenantId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterAzureActiveDirectory), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterAzureActiveDirectory")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterAzureActiveDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_application_id ServiceFabricCluster#client_application_id}.</summary>
            [JsiiProperty(name: "clientApplicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#cluster_application_id ServiceFabricCluster#cluster_application_id}.</summary>
            [JsiiProperty(name: "clusterApplicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#tenant_id ServiceFabricCluster#tenant_id}.</summary>
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
