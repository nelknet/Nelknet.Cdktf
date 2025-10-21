using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementApi.ApiManagementApiImport")]
    public class ApiManagementApiImport : azurerm.ApiManagementApi.IApiManagementApiImport
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#content_format ApiManagementApi#content_format}.</summary>
        [JsiiProperty(name: "contentFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#content_value ApiManagementApi#content_value}.</summary>
        [JsiiProperty(name: "contentValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentValue
        {
            get;
            set;
        }

        /// <summary>wsdl_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#wsdl_selector ApiManagementApi#wsdl_selector}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wsdlSelector", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImportWsdlSelector\"}", isOptional: true)]
        public azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector? WsdlSelector
        {
            get;
            set;
        }
    }
}
