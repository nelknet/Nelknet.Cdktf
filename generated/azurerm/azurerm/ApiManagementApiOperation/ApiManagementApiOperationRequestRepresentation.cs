using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiOperation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestRepresentation")]
    public class ApiManagementApiOperationRequestRepresentation : azurerm.ApiManagementApiOperation.IApiManagementApiOperationRequestRepresentation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#content_type ApiManagementApiOperation#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentType
        {
            get;
            set;
        }

        private object? _example;

        /// <summary>example block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#example ApiManagementApiOperation#example}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "example", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestRepresentationExample\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Example
        {
            get => _example;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagementApiOperation.IApiManagementApiOperationRequestRepresentationExample[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagementApiOperation.IApiManagementApiOperationRequestRepresentationExample).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _example = value;
            }
        }

        private object? _formParameter;

        /// <summary>form_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#form_parameter ApiManagementApiOperation#form_parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "formParameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementApiOperation.ApiManagementApiOperationRequestRepresentationFormParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FormParameter
        {
            get => _formParameter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagementApiOperation.IApiManagementApiOperationRequestRepresentationFormParameter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagementApiOperation.IApiManagementApiOperationRequestRepresentationFormParameter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _formParameter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#schema_id ApiManagementApiOperation#schema_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchemaId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api_operation#type_name ApiManagementApiOperation#type_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TypeName
        {
            get;
            set;
        }
    }
}
