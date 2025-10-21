using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementAuthorizationServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementAuthorizationServer.ApiManagementAuthorizationServerTokenBodyParameter")]
    public class ApiManagementAuthorizationServerTokenBodyParameter : azurerm.ApiManagementAuthorizationServer.IApiManagementAuthorizationServerTokenBodyParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#name ApiManagementAuthorizationServer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_authorization_server#value ApiManagementAuthorizationServer#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
