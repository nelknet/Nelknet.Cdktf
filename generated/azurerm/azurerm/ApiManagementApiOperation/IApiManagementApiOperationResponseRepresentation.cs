using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiOperation
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiOperationResponseRepresentation), fullyQualifiedName: "azurerm.apiManagementApiOperation.ApiManagementApiOperationResponseRepresentation")]
    public interface IApiManagementApiOperationResponseRepresentation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#content_type ApiManagementApiOperation#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        string ContentType
        {
            get;
        }

        /// <summary>example block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#example ApiManagementApiOperation#example}
        /// </remarks>
        [JsiiProperty(name: "example", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationResponseRepresentationExample\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Example
        {
            get
            {
                return null;
            }
        }

        /// <summary>form_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#form_parameter ApiManagementApiOperation#form_parameter}
        /// </remarks>
        [JsiiProperty(name: "formParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationResponseRepresentationFormParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FormParameter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#schema_id ApiManagementApiOperation#schema_id}.</summary>
        [JsiiProperty(name: "schemaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchemaId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#type_name ApiManagementApiOperation#type_name}.</summary>
        [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TypeName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiOperationResponseRepresentation), fullyQualifiedName: "azurerm.apiManagementApiOperation.ApiManagementApiOperationResponseRepresentation")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApiOperation.IApiManagementApiOperationResponseRepresentation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#content_type ApiManagementApiOperation#content_type}.</summary>
            [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>example block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#example ApiManagementApiOperation#example}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "example", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationResponseRepresentationExample\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Example
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>form_parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#form_parameter ApiManagementApiOperation#form_parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "formParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationResponseRepresentationFormParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FormParameter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#schema_id ApiManagementApiOperation#schema_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchemaId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#type_name ApiManagementApiOperation#type_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TypeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
