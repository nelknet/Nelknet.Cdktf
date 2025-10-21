using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppAuthSettingsTwitter")]
    public class WindowsWebAppAuthSettingsTwitter : azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsTwitter
    {
        /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#consumer_key WindowsWebApp#consumer_key}
        /// </remarks>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ConsumerKey
        {
            get;
            set;
        }

        /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#consumer_secret WindowsWebApp#consumer_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConsumerSecret
        {
            get;
            set;
        }

        /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#consumer_secret_setting_name WindowsWebApp#consumer_secret_setting_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "consumerSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConsumerSecretSettingName
        {
            get;
            set;
        }
    }
}
