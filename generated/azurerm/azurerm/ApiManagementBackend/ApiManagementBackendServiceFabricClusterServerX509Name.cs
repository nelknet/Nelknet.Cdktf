using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendServiceFabricClusterServerX509Name")]
    public class ApiManagementBackendServiceFabricClusterServerX509Name : azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricClusterServerX509Name
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#issuer_certificate_thumbprint ApiManagementBackend#issuer_certificate_thumbprint}.</summary>
        [JsiiProperty(name: "issuerCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public string IssuerCertificateThumbprint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#name ApiManagementBackend#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
