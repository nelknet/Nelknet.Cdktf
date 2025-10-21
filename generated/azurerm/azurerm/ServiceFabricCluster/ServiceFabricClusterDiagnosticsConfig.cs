using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfig")]
    public class ServiceFabricClusterDiagnosticsConfig : azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#blob_endpoint ServiceFabricCluster#blob_endpoint}.</summary>
        [JsiiProperty(name: "blobEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string BlobEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#protected_account_key_name ServiceFabricCluster#protected_account_key_name}.</summary>
        [JsiiProperty(name: "protectedAccountKeyName", typeJson: "{\"primitive\":\"string\"}")]
        public string ProtectedAccountKeyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#queue_endpoint ServiceFabricCluster#queue_endpoint}.</summary>
        [JsiiProperty(name: "queueEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string QueueEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#storage_account_name ServiceFabricCluster#storage_account_name}.</summary>
        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#table_endpoint ServiceFabricCluster#table_endpoint}.</summary>
        [JsiiProperty(name: "tableEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string TableEndpoint
        {
            get;
            set;
        }
    }
}
