using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppAuthSettingsFacebook), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppAuthSettingsFacebook")]
    public interface ILinuxWebAppAuthSettingsFacebook
    {
        /// <summary>The App ID of the Facebook app used for login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#app_id LinuxWebApp#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        string AppId
        {
            get;
        }

        /// <summary>The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#app_secret LinuxWebApp#app_secret}
        /// </remarks>
        [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#app_secret_setting_name LinuxWebApp#app_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "appSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppSecretSettingName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#oauth_scopes LinuxWebApp#oauth_scopes}
        /// </remarks>
        [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OauthScopes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppAuthSettingsFacebook), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppAuthSettingsFacebook")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsFacebook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The App ID of the Facebook app used for login.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#app_id LinuxWebApp#app_id}
            /// </remarks>
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#app_secret LinuxWebApp#app_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#app_secret_setting_name LinuxWebApp#app_secret_setting_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppSecretSettingName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#oauth_scopes LinuxWebApp#oauth_scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OauthScopes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
