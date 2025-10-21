using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppAuthSettingsFacebook")]
    public class WindowsWebAppAuthSettingsFacebook : azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsFacebook
    {
        /// <summary>The App ID of the Facebook app used for login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#app_id WindowsWebApp#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        public string AppId
        {
            get;
            set;
        }

        /// <summary>The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#app_secret WindowsWebApp#app_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppSecret
        {
            get;
            set;
        }

        /// <summary>The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#app_secret_setting_name WindowsWebApp#app_secret_setting_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppSecretSettingName
        {
            get;
            set;
        }

        /// <summary>Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#oauth_scopes WindowsWebApp#oauth_scopes}
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
