using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    [JsiiByValue(fqn: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequest")]
    public class ApiManagementApiDiagnosticBackendRequest : azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#body_bytes ApiManagementApiDiagnostic#body_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bodyBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BodyBytes
        {
            get;
            set;
        }

        /// <summary>data_masking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#data_masking ApiManagementApiDiagnostic#data_masking}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequestDataMasking\"}", isOptional: true)]
        public azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequestDataMasking? DataMasking
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_diagnostic#headers_to_log ApiManagementApiDiagnostic#headers_to_log}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headersToLog", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HeadersToLog
        {
            get;
            set;
        }
    }
}
