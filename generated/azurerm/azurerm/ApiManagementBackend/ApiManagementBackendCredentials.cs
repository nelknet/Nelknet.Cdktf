using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendCredentials")]
    public class ApiManagementBackendCredentials : azurerm.ApiManagementBackend.IApiManagementBackendCredentials
    {
        /// <summary>authorization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#authorization ApiManagementBackend#authorization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendCredentialsAuthorization\"}", isOptional: true)]
        public azurerm.ApiManagementBackend.IApiManagementBackendCredentialsAuthorization? Authorization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#certificate ApiManagementBackend#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#header ApiManagementBackend#header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Header
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#query ApiManagementBackend#query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "query", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Query
        {
            get;
            set;
        }
    }
}
