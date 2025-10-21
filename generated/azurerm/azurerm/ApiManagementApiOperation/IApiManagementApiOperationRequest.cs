using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiOperation
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiOperationRequest), fullyQualifiedName: "azurerm.apiManagementApiOperation.ApiManagementApiOperationRequest")]
    public interface IApiManagementApiOperationRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#description ApiManagementApiOperation#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#header ApiManagementApiOperation#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#query_parameter ApiManagementApiOperation#query_parameter}
        /// </remarks>
        [JsiiProperty(name: "queryParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestQueryParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryParameter
        {
            get
            {
                return null;
            }
        }

        /// <summary>representation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#representation ApiManagementApiOperation#representation}
        /// </remarks>
        [JsiiProperty(name: "representation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestRepresentation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Representation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiOperationRequest), fullyQualifiedName: "azurerm.apiManagementApiOperation.ApiManagementApiOperationRequest")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApiOperation.IApiManagementApiOperationRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#description ApiManagementApiOperation#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#header ApiManagementApiOperation#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Header
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>query_parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#query_parameter ApiManagementApiOperation#query_parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestQueryParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryParameter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>representation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#representation ApiManagementApiOperation#representation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "representation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestRepresentation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Representation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
