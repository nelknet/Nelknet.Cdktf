using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppAuthSettings")]
    public class WindowsWebAppAuthSettings : azurerm.WindowsWebApp.IWindowsWebAppAuthSettings
    {
        private object _enabled;

        /// <summary>Should the Authentication / Authorization feature be enabled?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#enabled WindowsWebApp#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#active_directory WindowsWebApp#active_directory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsActiveDirectory\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsActiveDirectory? ActiveDirectory
        {
            get;
            set;
        }

        /// <summary>Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#additional_login_parameters WindowsWebApp#additional_login_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalLoginParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParameters
        {
            get;
            set;
        }

        /// <summary>Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#allowed_external_redirect_urls WindowsWebApp#allowed_external_redirect_urls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedExternalRedirectUrls
        {
            get;
            set;
        }

        /// <summary>The default authentication provider to use when multiple providers are configured.</summary>
        /// <remarks>
        /// Possible values include: <c>AzureActiveDirectory</c>, <c>Facebook</c>, <c>Google</c>, <c>MicrosoftAccount</c>, <c>Twitter</c>, <c>Github</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#default_provider WindowsWebApp#default_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultProvider
        {
            get;
            set;
        }

        /// <summary>facebook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#facebook WindowsWebApp#facebook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsFacebook\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsFacebook? Facebook
        {
            get;
            set;
        }

        /// <summary>github block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#github WindowsWebApp#github}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsGithub\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsGithub? Github
        {
            get;
            set;
        }

        /// <summary>google block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#google WindowsWebApp#google}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsGoogle\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsGoogle? Google
        {
            get;
            set;
        }

        /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#issuer WindowsWebApp#issuer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Issuer
        {
            get;
            set;
        }

        /// <summary>microsoft block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#microsoft WindowsWebApp#microsoft}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsMicrosoft\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsMicrosoft? Microsoft
        {
            get;
            set;
        }

        /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#runtime_version WindowsWebApp#runtime_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RuntimeVersion
        {
            get;
            set;
        }

        /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API.</summary>
        /// <remarks>
        /// Defaults to <c>72</c> hours.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#token_refresh_extension_hours WindowsWebApp#token_refresh_extension_hours}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TokenRefreshExtensionHours
        {
            get;
            set;
        }

        private object? _tokenStoreEnabled;

        /// <summary>Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#token_store_enabled WindowsWebApp#token_store_enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TokenStoreEnabled
        {
            get => _tokenStoreEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tokenStoreEnabled = value;
            }
        }

        /// <summary>twitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#twitter WindowsWebApp#twitter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsTwitter\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsTwitter? Twitter
        {
            get;
            set;
        }

        /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#unauthenticated_client_action WindowsWebApp#unauthenticated_client_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UnauthenticatedClientAction
        {
            get;
            set;
        }
    }
}
