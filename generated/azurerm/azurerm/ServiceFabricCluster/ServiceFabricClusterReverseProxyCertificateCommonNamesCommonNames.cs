using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNamesCommonNames")]
    public class ServiceFabricClusterReverseProxyCertificateCommonNamesCommonNames : azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNamesCommonNames
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate_common_name ServiceFabricCluster#certificate_common_name}.</summary>
        [JsiiProperty(name: "certificateCommonName", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateCommonName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate_issuer_thumbprint ServiceFabricCluster#certificate_issuer_thumbprint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateIssuerThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateIssuerThumbprint
        {
            get;
            set;
        }
    }
}
