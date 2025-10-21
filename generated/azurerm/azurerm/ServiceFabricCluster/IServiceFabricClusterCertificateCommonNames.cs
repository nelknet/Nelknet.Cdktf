using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterCertificateCommonNames), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNames")]
    public interface IServiceFabricClusterCertificateCommonNames
    {
        /// <summary>common_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#common_names ServiceFabricCluster#common_names}
        /// </remarks>
        [JsiiProperty(name: "commonNames", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNames\"},\"kind\":\"array\"}}]}}")]
        object CommonNames
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#x509_store_name ServiceFabricCluster#x509_store_name}.</summary>
        [JsiiProperty(name: "x509StoreName", typeJson: "{\"primitive\":\"string\"}")]
        string X509StoreName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterCertificateCommonNames), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNames")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>common_names block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#common_names ServiceFabricCluster#common_names}
            /// </remarks>
            [JsiiProperty(name: "commonNames", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNames\"},\"kind\":\"array\"}}]}}")]
            public object CommonNames
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#x509_store_name ServiceFabricCluster#x509_store_name}.</summary>
            [JsiiProperty(name: "x509StoreName", typeJson: "{\"primitive\":\"string\"}")]
            public string X509StoreName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
