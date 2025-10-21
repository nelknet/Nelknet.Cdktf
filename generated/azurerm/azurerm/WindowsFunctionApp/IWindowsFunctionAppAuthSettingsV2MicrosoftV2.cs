using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionApp
{
    [JsiiInterface(nativeType: typeof(IWindowsFunctionAppAuthSettingsV2MicrosoftV2), fullyQualifiedName: "azurerm.windowsFunctionApp.WindowsFunctionAppAuthSettingsV2MicrosoftV2")]
    public interface IWindowsFunctionAppAuthSettingsV2MicrosoftV2
    {
        /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_id WindowsFunctionApp#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_secret_setting_name WindowsFunctionApp#client_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        string ClientSecretSettingName
        {
            get;
        }

        /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#allowed_audiences WindowsFunctionApp#allowed_audiences}
        /// </remarks>
        [JsiiProperty(name: "allowedAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAudiences
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of Login scopes that will be requested as part of Microsoft Account authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#login_scopes WindowsFunctionApp#login_scopes}
        /// </remarks>
        [JsiiProperty(name: "loginScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LoginScopes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsFunctionAppAuthSettingsV2MicrosoftV2), fullyQualifiedName: "azurerm.windowsFunctionApp.WindowsFunctionAppAuthSettingsV2MicrosoftV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsFunctionApp.IWindowsFunctionAppAuthSettingsV2MicrosoftV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The OAuth 2.0 client ID that was created for the app used for authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_id WindowsFunctionApp#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_secret_setting_name WindowsFunctionApp#client_secret_setting_name}
            /// </remarks>
            [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientSecretSettingName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#allowed_audiences WindowsFunctionApp#allowed_audiences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAudiences
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The list of Login scopes that will be requested as part of Microsoft Account authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#login_scopes WindowsFunctionApp#login_scopes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loginScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LoginScopes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
