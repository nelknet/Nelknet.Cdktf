using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsFunctionApp.WindowsFunctionAppAuthSettingsV2CustomOidcV2")]
    public class WindowsFunctionAppAuthSettingsV2CustomOidcV2 : azurerm.WindowsFunctionApp.IWindowsFunctionAppAuthSettingsV2CustomOidcV2
    {
        /// <summary>The ID of the Client to use to authenticate with this Custom OIDC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_id WindowsFunctionApp#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>The name of the Custom OIDC Authentication Provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#name WindowsFunctionApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The endpoint that contains all the configuration endpoints for this Custom OIDC provider.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#openid_configuration_endpoint WindowsFunctionApp#openid_configuration_endpoint}
        /// </remarks>
        [JsiiProperty(name: "openidConfigurationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string OpenidConfigurationEndpoint
        {
            get;
            set;
        }

        /// <summary>The name of the claim that contains the users name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#name_claim_type WindowsFunctionApp#name_claim_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameClaimType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameClaimType
        {
            get;
            set;
        }

        /// <summary>The list of the scopes that should be requested while authenticating.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#scopes WindowsFunctionApp#scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Scopes
        {
            get;
            set;
        }
    }
}
