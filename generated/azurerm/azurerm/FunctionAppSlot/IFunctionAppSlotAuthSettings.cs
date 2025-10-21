using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(IFunctionAppSlotAuthSettings), fullyQualifiedName: "azurerm.functionAppSlot.FunctionAppSlotAuthSettings")]
    public interface IFunctionAppSlotAuthSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#enabled FunctionAppSlot#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#active_directory FunctionAppSlot#active_directory}
        /// </remarks>
        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsActiveDirectory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsActiveDirectory? ActiveDirectory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#additional_login_params FunctionAppSlot#additional_login_params}.</summary>
        [JsiiProperty(name: "additionalLoginParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParams
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#allowed_external_redirect_urls FunctionAppSlot#allowed_external_redirect_urls}.</summary>
        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedExternalRedirectUrls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#default_provider FunctionAppSlot#default_provider}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#facebook FunctionAppSlot#facebook}
        /// </remarks>
        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsFacebook\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsFacebook? Facebook
        {
            get
            {
                return null;
            }
        }

        /// <summary>google block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#google FunctionAppSlot#google}
        /// </remarks>
        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsGoogle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsGoogle? Google
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#issuer FunctionAppSlot#issuer}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#microsoft FunctionAppSlot#microsoft}
        /// </remarks>
        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsMicrosoft\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsMicrosoft? Microsoft
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#runtime_version FunctionAppSlot#runtime_version}.</summary>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuntimeVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#token_refresh_extension_hours FunctionAppSlot#token_refresh_extension_hours}.</summary>
        [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TokenRefreshExtensionHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#token_store_enabled FunctionAppSlot#token_store_enabled}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#twitter FunctionAppSlot#twitter}
        /// </remarks>
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsTwitter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsTwitter? Twitter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#unauthenticated_client_action FunctionAppSlot#unauthenticated_client_action}.</summary>
        [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnauthenticatedClientAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionAppSlotAuthSettings), fullyQualifiedName: "azurerm.functionAppSlot.FunctionAppSlotAuthSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#enabled FunctionAppSlot#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>active_directory block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#active_directory FunctionAppSlot#active_directory}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsActiveDirectory\"}", isOptional: true)]
            public azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsActiveDirectory? ActiveDirectory
            {
                get => GetInstanceProperty<azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsActiveDirectory?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#additional_login_params FunctionAppSlot#additional_login_params}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalLoginParams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParams
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#allowed_external_redirect_urls FunctionAppSlot#allowed_external_redirect_urls}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedExternalRedirectUrls
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#default_provider FunctionAppSlot#default_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>facebook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#facebook FunctionAppSlot#facebook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsFacebook\"}", isOptional: true)]
            public azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsFacebook? Facebook
            {
                get => GetInstanceProperty<azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsFacebook?>();
            }

            /// <summary>google block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#google FunctionAppSlot#google}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsGoogle\"}", isOptional: true)]
            public azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsGoogle? Google
            {
                get => GetInstanceProperty<azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsGoogle?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#issuer FunctionAppSlot#issuer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Issuer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>microsoft block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#microsoft FunctionAppSlot#microsoft}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsMicrosoft\"}", isOptional: true)]
            public azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsMicrosoft? Microsoft
            {
                get => GetInstanceProperty<azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsMicrosoft?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#runtime_version FunctionAppSlot#runtime_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuntimeVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#token_refresh_extension_hours FunctionAppSlot#token_refresh_extension_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TokenRefreshExtensionHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#token_store_enabled FunctionAppSlot#token_store_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TokenStoreEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>twitter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#twitter FunctionAppSlot#twitter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsTwitter\"}", isOptional: true)]
            public azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsTwitter? Twitter
            {
                get => GetInstanceProperty<azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsTwitter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/function_app_slot#unauthenticated_client_action FunctionAppSlot#unauthenticated_client_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnauthenticatedClientAction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
