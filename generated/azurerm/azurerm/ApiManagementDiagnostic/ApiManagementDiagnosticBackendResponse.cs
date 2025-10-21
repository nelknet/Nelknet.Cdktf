using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    [JsiiByValue(fqn: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponse")]
    public class ApiManagementDiagnosticBackendResponse : azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#body_bytes ApiManagementDiagnostic#body_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bodyBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BodyBytes
        {
            get;
            set;
        }

        /// <summary>data_masking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#data_masking ApiManagementDiagnostic#data_masking}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMasking\"}", isOptional: true)]
        public azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponseDataMasking? DataMasking
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#headers_to_log ApiManagementDiagnostic#headers_to_log}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headersToLog", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HeadersToLog
        {
            get;
            set;
        }
    }
}
