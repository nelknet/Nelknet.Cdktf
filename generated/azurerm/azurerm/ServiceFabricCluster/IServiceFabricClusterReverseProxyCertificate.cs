using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterReverseProxyCertificate), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificate")]
    public interface IServiceFabricClusterReverseProxyCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#thumbprint ServiceFabricCluster#thumbprint}.</summary>
        [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        string Thumbprint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#x509_store_name ServiceFabricCluster#x509_store_name}.</summary>
        [JsiiProperty(name: "x509StoreName", typeJson: "{\"primitive\":\"string\"}")]
        string X509StoreName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#thumbprint_secondary ServiceFabricCluster#thumbprint_secondary}.</summary>
        [JsiiProperty(name: "thumbprintSecondary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThumbprintSecondary
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterReverseProxyCertificate), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#thumbprint ServiceFabricCluster#thumbprint}.</summary>
            [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
            public string Thumbprint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#x509_store_name ServiceFabricCluster#x509_store_name}.</summary>
            [JsiiProperty(name: "x509StoreName", typeJson: "{\"primitive\":\"string\"}")]
            public string X509StoreName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#thumbprint_secondary ServiceFabricCluster#thumbprint_secondary}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thumbprintSecondary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThumbprintSecondary
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
