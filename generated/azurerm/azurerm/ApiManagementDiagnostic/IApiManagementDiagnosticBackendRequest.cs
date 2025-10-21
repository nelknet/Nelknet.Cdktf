using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    [JsiiInterface(nativeType: typeof(IApiManagementDiagnosticBackendRequest), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendRequest")]
    public interface IApiManagementDiagnosticBackendRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#body_bytes ApiManagementDiagnostic#body_bytes}.</summary>
        [JsiiProperty(name: "bodyBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BodyBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_masking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#data_masking ApiManagementDiagnostic#data_masking}
        /// </remarks>
        [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendRequestDataMasking\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendRequestDataMasking? DataMasking
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#headers_to_log ApiManagementDiagnostic#headers_to_log}.</summary>
        [JsiiProperty(name: "headersToLog", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HeadersToLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementDiagnosticBackendRequest), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendRequest")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#body_bytes ApiManagementDiagnostic#body_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bodyBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BodyBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>data_masking block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#data_masking ApiManagementDiagnostic#data_masking}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendRequestDataMasking\"}", isOptional: true)]
            public azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendRequestDataMasking? DataMasking
            {
                get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendRequestDataMasking?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#headers_to_log ApiManagementDiagnostic#headers_to_log}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headersToLog", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HeadersToLog
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
