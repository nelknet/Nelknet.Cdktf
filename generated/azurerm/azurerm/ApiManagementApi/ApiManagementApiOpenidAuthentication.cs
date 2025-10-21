using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementApi.ApiManagementApiOpenidAuthentication")]
    public class ApiManagementApiOpenidAuthentication : azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#openid_provider_name ApiManagementApi#openid_provider_name}.</summary>
        [JsiiProperty(name: "openidProviderName", typeJson: "{\"primitive\":\"string\"}")]
        public string OpenidProviderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#bearer_token_sending_methods ApiManagementApi#bearer_token_sending_methods}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bearerTokenSendingMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BearerTokenSendingMethods
        {
            get;
            set;
        }
    }
}
