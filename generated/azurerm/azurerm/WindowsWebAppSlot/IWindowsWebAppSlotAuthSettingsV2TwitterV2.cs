using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotAuthSettingsV2TwitterV2), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2TwitterV2")]
    public interface IWindowsWebAppSlotAuthSettingsV2TwitterV2
    {
        /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#consumer_key WindowsWebAppSlot#consumer_key}
        /// </remarks>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        string ConsumerKey
        {
            get;
        }

        /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#consumer_secret_setting_name WindowsWebAppSlot#consumer_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "consumerSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        string ConsumerSecretSettingName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotAuthSettingsV2TwitterV2), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsV2TwitterV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsV2TwitterV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#consumer_key WindowsWebAppSlot#consumer_key}
            /// </remarks>
            [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsumerKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#consumer_secret_setting_name WindowsWebAppSlot#consumer_secret_setting_name}
            /// </remarks>
            [JsiiProperty(name: "consumerSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsumerSecretSettingName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
