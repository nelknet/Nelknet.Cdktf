using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagement.ApiManagementCertificate")]
    public class ApiManagementCertificate : azurerm.ApiManagement.IApiManagementCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#encoded_certificate ApiManagement#encoded_certificate}.</summary>
        [JsiiProperty(name: "encodedCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public string EncodedCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#store_name ApiManagement#store_name}.</summary>
        [JsiiProperty(name: "storeName", typeJson: "{\"primitive\":\"string\"}")]
        public string StoreName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificatePassword
        {
            get;
            set;
        }
    }
}
