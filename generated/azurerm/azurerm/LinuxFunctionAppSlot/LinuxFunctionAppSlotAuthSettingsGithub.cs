using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGithub")]
    public class LinuxFunctionAppSlotAuthSettingsGithub : azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGithub
    {
        /// <summary>The ID of the GitHub app used for login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#client_id LinuxFunctionAppSlot#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#client_secret LinuxFunctionAppSlot#client_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }

        /// <summary>The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#client_secret_setting_name LinuxFunctionAppSlot#client_secret_setting_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecretSettingName
        {
            get;
            set;
        }

        /// <summary>Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#oauth_scopes LinuxFunctionAppSlot#oauth_scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OauthScopes
        {
            get;
            set;
        }
    }
}
