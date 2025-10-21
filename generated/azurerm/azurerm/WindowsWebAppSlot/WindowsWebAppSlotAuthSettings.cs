using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettings")]
    public class WindowsWebAppSlotAuthSettings : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettings
    {
        private object _enabled;

        /// <summary>Should the Authentication / Authorization feature be enabled?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#enabled WindowsWebAppSlot#enabled}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#active_directory WindowsWebAppSlot#active_directory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsActiveDirectory\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsActiveDirectory? ActiveDirectory
        {
            get;
            set;
        }

        /// <summary>Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#additional_login_parameters WindowsWebAppSlot#additional_login_parameters}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#allowed_external_redirect_urls WindowsWebAppSlot#allowed_external_redirect_urls}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#default_provider WindowsWebAppSlot#default_provider}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#facebook WindowsWebAppSlot#facebook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsFacebook\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsFacebook? Facebook
        {
            get;
            set;
        }

        /// <summary>github block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#github WindowsWebAppSlot#github}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsGithub\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGithub? Github
        {
            get;
            set;
        }

        /// <summary>google block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#google WindowsWebAppSlot#google}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsGoogle\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGoogle? Google
        {
            get;
            set;
        }

        /// <summary>The OpenID Connect Issuer URI that represents the entity which issues access tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#issuer WindowsWebAppSlot#issuer}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#microsoft WindowsWebAppSlot#microsoft}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsMicrosoft\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsMicrosoft? Microsoft
        {
            get;
            set;
        }

        /// <summary>The RuntimeVersion of the Authentication / Authorization feature in use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#runtime_version WindowsWebAppSlot#runtime_version}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#token_refresh_extension_hours WindowsWebAppSlot#token_refresh_extension_hours}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#token_store_enabled WindowsWebAppSlot#token_store_enabled}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#twitter WindowsWebAppSlot#twitter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsTwitter\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsTwitter? Twitter
        {
            get;
            set;
        }

        /// <summary>The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#unauthenticated_client_action WindowsWebAppSlot#unauthenticated_client_action}
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
