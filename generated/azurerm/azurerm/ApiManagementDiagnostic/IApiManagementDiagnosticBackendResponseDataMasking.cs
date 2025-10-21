using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    [JsiiInterface(nativeType: typeof(IApiManagementDiagnosticBackendResponseDataMasking), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMasking")]
    public interface IApiManagementDiagnosticBackendResponseDataMasking
    {
        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#headers ApiManagementDiagnostic#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Headers
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#query_params ApiManagementDiagnostic#query_params}
        /// </remarks>
        [JsiiProperty(name: "queryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryParams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementDiagnosticBackendResponseDataMasking), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMasking")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponseDataMasking
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#headers ApiManagementDiagnostic#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMaskingHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_params block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#query_params ApiManagementDiagnostic#query_params}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMaskingQueryParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryParams
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
