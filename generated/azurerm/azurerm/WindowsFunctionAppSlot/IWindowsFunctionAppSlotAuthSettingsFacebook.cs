using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsFunctionAppSlotAuthSettingsFacebook), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsFacebook")]
    public interface IWindowsFunctionAppSlotAuthSettingsFacebook
    {
        /// <summary>The App ID of the Facebook app used for login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_id WindowsFunctionAppSlot#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        string AppId
        {
            get;
        }

        /// <summary>The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_secret WindowsFunctionAppSlot#app_secret}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_secret_setting_name WindowsFunctionAppSlot#app_secret_setting_name}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#oauth_scopes WindowsFunctionAppSlot#oauth_scopes}
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

        [JsiiTypeProxy(nativeType: typeof(IWindowsFunctionAppSlotAuthSettingsFacebook), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsFacebook")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettingsFacebook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The App ID of the Facebook app used for login.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_id WindowsFunctionAppSlot#app_id}
            /// </remarks>
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_secret WindowsFunctionAppSlot#app_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#app_secret_setting_name WindowsFunctionAppSlot#app_secret_setting_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppSecretSettingName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app_slot#oauth_scopes WindowsFunctionAppSlot#oauth_scopes}
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
