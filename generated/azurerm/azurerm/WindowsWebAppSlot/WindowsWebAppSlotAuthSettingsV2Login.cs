using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2Login")]
    public class WindowsWebAppSlotAuthSettingsV2Login : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsV2Login
    {
        /// <summary>External URLs that can be redirected to as part of logging in or logging out of the app.</summary>
        /// <remarks>
        /// This is an advanced setting typically only needed by Windows Store application backends. <strong>Note:</strong> URLs within the current domain are always implicitly allowed.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#allowed_external_redirect_urls WindowsWebAppSlot#allowed_external_redirect_urls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedExternalRedirectUrls
        {
            get;
            set;
        }

        /// <summary>The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#cookie_expiration_convention WindowsWebAppSlot#cookie_expiration_convention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookieExpirationConvention", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CookieExpirationConvention
        {
            get;
            set;
        }

        /// <summary>The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#cookie_expiration_time WindowsWebAppSlot#cookie_expiration_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookieExpirationTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CookieExpirationTime
        {
            get;
            set;
        }

        /// <summary>The endpoint to which logout requests should be made.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#logout_endpoint WindowsWebAppSlot#logout_endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logoutEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogoutEndpoint
        {
            get;
            set;
        }

        /// <summary>The time after the request is made when the nonce should expire. Defaults to `00:05:00`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#nonce_expiration_time WindowsWebAppSlot#nonce_expiration_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nonceExpirationTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NonceExpirationTime
        {
            get;
            set;
        }

        private object? _preserveUrlFragmentsForLogins;

        /// <summary>Should the fragments from the request be preserved after the login request is made. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#preserve_url_fragments_for_logins WindowsWebAppSlot#preserve_url_fragments_for_logins}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preserveUrlFragmentsForLogins", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PreserveUrlFragmentsForLogins
        {
            get => _preserveUrlFragmentsForLogins;
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
                _preserveUrlFragmentsForLogins = value;
            }
        }

        /// <summary>The number of hours after session token expiration that a session token can be used to call the token refresh API.</summary>
        /// <remarks>
        /// Defaults to <c>72</c> hours.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#token_refresh_extension_time WindowsWebAppSlot#token_refresh_extension_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenRefreshExtensionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TokenRefreshExtensionTime
        {
            get;
            set;
        }

        private object? _tokenStoreEnabled;

        /// <summary>Should the Token Store configuration Enabled. Defaults to `false`.</summary>
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

        /// <summary>The directory path in the App Filesystem in which the tokens will be stored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#token_store_path WindowsWebAppSlot#token_store_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenStorePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenStorePath
        {
            get;
            set;
        }

        /// <summary>The name of the app setting which contains the SAS URL of the blob storage containing the tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#token_store_sas_setting_name WindowsWebAppSlot#token_store_sas_setting_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenStoreSasSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenStoreSasSettingName
        {
            get;
            set;
        }

        private object? _validateNonce;

        /// <summary>Should the nonce be validated while completing the login flow. Defaults to `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#validate_nonce WindowsWebAppSlot#validate_nonce}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validateNonce", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ValidateNonce
        {
            get => _validateNonce;
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
                _validateNonce = value;
            }
        }
    }
}
