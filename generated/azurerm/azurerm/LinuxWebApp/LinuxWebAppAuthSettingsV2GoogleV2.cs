using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppAuthSettingsV2GoogleV2")]
    public class LinuxWebAppAuthSettingsV2GoogleV2 : azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsV2GoogleV2
    {
        /// <summary>The OpenID Connect Client ID for the Google web application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_id LinuxWebApp#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>The app setting name that contains the `client_secret` value used for Google Login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#client_secret_setting_name LinuxWebApp#client_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientSecretSettingName
        {
            get;
            set;
        }

        /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Google Sign-In authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#allowed_audiences LinuxWebApp#allowed_audiences}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedAudiences
        {
            get;
            set;
        }

        /// <summary>Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#login_scopes LinuxWebApp#login_scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loginScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LoginScopes
        {
            get;
            set;
        }
    }
}
