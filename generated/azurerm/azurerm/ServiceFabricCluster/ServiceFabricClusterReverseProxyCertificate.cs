using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificate")]
    public class ServiceFabricClusterReverseProxyCertificate : azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#thumbprint ServiceFabricCluster#thumbprint}.</summary>
        [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public string Thumbprint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#x509_store_name ServiceFabricCluster#x509_store_name}.</summary>
        [JsiiProperty(name: "x509StoreName", typeJson: "{\"primitive\":\"string\"}")]
        public string X509StoreName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#thumbprint_secondary ServiceFabricCluster#thumbprint_secondary}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thumbprintSecondary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThumbprintSecondary
        {
            get;
            set;
        }
    }
}
