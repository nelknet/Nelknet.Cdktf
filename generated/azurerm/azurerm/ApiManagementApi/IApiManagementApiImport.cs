using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiImport), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiImport")]
    public interface IApiManagementApiImport
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#content_format ApiManagementApi#content_format}.</summary>
        [JsiiProperty(name: "contentFormat", typeJson: "{\"primitive\":\"string\"}")]
        string ContentFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#content_value ApiManagementApi#content_value}.</summary>
        [JsiiProperty(name: "contentValue", typeJson: "{\"primitive\":\"string\"}")]
        string ContentValue
        {
            get;
        }

        /// <summary>wsdl_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#wsdl_selector ApiManagementApi#wsdl_selector}
        /// </remarks>
        [JsiiProperty(name: "wsdlSelector", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImportWsdlSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector? WsdlSelector
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiImport), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiImport")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApi.IApiManagementApiImport
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#content_format ApiManagementApi#content_format}.</summary>
            [JsiiProperty(name: "contentFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#content_value ApiManagementApi#content_value}.</summary>
            [JsiiProperty(name: "contentValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>wsdl_selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#wsdl_selector ApiManagementApi#wsdl_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wsdlSelector", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImportWsdlSelector\"}", isOptional: true)]
            public azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector? WsdlSelector
            {
                get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector?>();
            }
        }
    }
}
