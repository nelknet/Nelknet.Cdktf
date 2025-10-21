using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendCredentialsAuthorization")]
    public class ApiManagementBackendCredentialsAuthorization : azurerm.ApiManagementBackend.IApiManagementBackendCredentialsAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#parameter ApiManagementBackend#parameter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Parameter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#scheme ApiManagementBackend#scheme}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scheme
        {
            get;
            set;
        }
    }
}
