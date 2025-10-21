using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionApp
{
    [JsiiInterface(nativeType: typeof(IWindowsFunctionAppAuthSettingsV2AppleV2), fullyQualifiedName: "azurerm.windowsFunctionApp.WindowsFunctionAppAuthSettingsV2AppleV2")]
    public interface IWindowsFunctionAppAuthSettingsV2AppleV2
    {
        /// <summary>The OpenID Connect Client ID for the Apple web application.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_id WindowsFunctionApp#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>The app setting name that contains the `client_secret` value used for Apple Login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_secret_setting_name WindowsFunctionApp#client_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        string ClientSecretSettingName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsFunctionAppAuthSettingsV2AppleV2), fullyQualifiedName: "azurerm.windowsFunctionApp.WindowsFunctionAppAuthSettingsV2AppleV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsFunctionApp.IWindowsFunctionAppAuthSettingsV2AppleV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The OpenID Connect Client ID for the Apple web application.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_id WindowsFunctionApp#client_id}
            /// </remarks>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The app setting name that contains the `client_secret` value used for Apple Login.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_secret_setting_name WindowsFunctionApp#client_secret_setting_name}
            /// </remarks>
            [JsiiProperty(name: "clientSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientSecretSettingName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
