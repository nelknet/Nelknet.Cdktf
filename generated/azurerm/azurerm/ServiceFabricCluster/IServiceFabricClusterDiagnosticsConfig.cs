using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterDiagnosticsConfig), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfig")]
    public interface IServiceFabricClusterDiagnosticsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#blob_endpoint ServiceFabricCluster#blob_endpoint}.</summary>
        [JsiiProperty(name: "blobEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string BlobEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#protected_account_key_name ServiceFabricCluster#protected_account_key_name}.</summary>
        [JsiiProperty(name: "protectedAccountKeyName", typeJson: "{\"primitive\":\"string\"}")]
        string ProtectedAccountKeyName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#queue_endpoint ServiceFabricCluster#queue_endpoint}.</summary>
        [JsiiProperty(name: "queueEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string QueueEndpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#storage_account_name ServiceFabricCluster#storage_account_name}.</summary>
        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
        string StorageAccountName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#table_endpoint ServiceFabricCluster#table_endpoint}.</summary>
        [JsiiProperty(name: "tableEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        string TableEndpoint
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterDiagnosticsConfig), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#blob_endpoint ServiceFabricCluster#blob_endpoint}.</summary>
            [JsiiProperty(name: "blobEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string BlobEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#protected_account_key_name ServiceFabricCluster#protected_account_key_name}.</summary>
            [JsiiProperty(name: "protectedAccountKeyName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProtectedAccountKeyName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#queue_endpoint ServiceFabricCluster#queue_endpoint}.</summary>
            [JsiiProperty(name: "queueEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#storage_account_name ServiceFabricCluster#storage_account_name}.</summary>
            [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageAccountName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#table_endpoint ServiceFabricCluster#table_endpoint}.</summary>
            [JsiiProperty(name: "tableEndpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string TableEndpoint
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
