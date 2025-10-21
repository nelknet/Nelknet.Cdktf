using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiInterface(nativeType: typeof(IAppServiceSlotAuthSettings), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotAuthSettings")]
    public interface IAppServiceSlotAuthSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#enabled AppServiceSlot#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#active_directory AppServiceSlot#active_directory}
        /// </remarks>
        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsActiveDirectory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsActiveDirectory? ActiveDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#additional_login_params AppServiceSlot#additional_login_params}.</summary>
        [JsiiProperty(name: "additionalLoginParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParams
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#allowed_external_redirect_urls AppServiceSlot#allowed_external_redirect_urls}.</summary>
        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedExternalRedirectUrls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#default_provider AppServiceSlot#default_provider}.</summary>
        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>facebook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#facebook AppServiceSlot#facebook}
        /// </remarks>
        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsFacebook\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsFacebook? Facebook
        {
            get
            {
                return null;
            }
        }

        /// <summary>google block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#google AppServiceSlot#google}
        /// </remarks>
        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsGoogle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsGoogle? Google
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#issuer AppServiceSlot#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Issuer
        {
            get
            {
                return null;
            }
        }

        /// <summary>microsoft block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#microsoft AppServiceSlot#microsoft}
        /// </remarks>
        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsMicrosoft\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsMicrosoft? Microsoft
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#runtime_version AppServiceSlot#runtime_version}.</summary>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuntimeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#token_refresh_extension_hours AppServiceSlot#token_refresh_extension_hours}.</summary>
        [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TokenRefreshExtensionHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#token_store_enabled AppServiceSlot#token_store_enabled}.</summary>
        [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TokenStoreEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>twitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#twitter AppServiceSlot#twitter}
        /// </remarks>
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsTwitter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsTwitter? Twitter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#unauthenticated_client_action AppServiceSlot#unauthenticated_client_action}.</summary>
        [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnauthenticatedClientAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceSlotAuthSettings), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotAuthSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceSlot.IAppServiceSlotAuthSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#enabled AppServiceSlot#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>active_directory block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#active_directory AppServiceSlot#active_directory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsActiveDirectory\"}", isOptional: true)]
            public azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsActiveDirectory? ActiveDirectory
            {
                get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsActiveDirectory?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#additional_login_params AppServiceSlot#additional_login_params}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalLoginParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParams
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#allowed_external_redirect_urls AppServiceSlot#allowed_external_redirect_urls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedExternalRedirectUrls
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#default_provider AppServiceSlot#default_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>facebook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#facebook AppServiceSlot#facebook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsFacebook\"}", isOptional: true)]
            public azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsFacebook? Facebook
            {
                get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsFacebook?>();
            }

            /// <summary>google block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#google AppServiceSlot#google}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsGoogle\"}", isOptional: true)]
            public azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsGoogle? Google
            {
                get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsGoogle?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#issuer AppServiceSlot#issuer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Issuer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>microsoft block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#microsoft AppServiceSlot#microsoft}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsMicrosoft\"}", isOptional: true)]
            public azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsMicrosoft? Microsoft
            {
                get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsMicrosoft?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#runtime_version AppServiceSlot#runtime_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuntimeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#token_refresh_extension_hours AppServiceSlot#token_refresh_extension_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TokenRefreshExtensionHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#token_store_enabled AppServiceSlot#token_store_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TokenStoreEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>twitter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#twitter AppServiceSlot#twitter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotAuthSettingsTwitter\"}", isOptional: true)]
            public azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsTwitter? Twitter
            {
                get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotAuthSettingsTwitter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_slot#unauthenticated_client_action AppServiceSlot#unauthenticated_client_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnauthenticatedClientAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
