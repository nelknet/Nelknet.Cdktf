using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppSlotAuthSettingsTwitter), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsTwitter")]
    public interface ILinuxFunctionAppSlotAuthSettingsTwitter
    {
        /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#consumer_key LinuxFunctionAppSlot#consumer_key}
        /// </remarks>
        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        string ConsumerKey
        {
            get;
        }

        /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#consumer_secret LinuxFunctionAppSlot#consumer_secret}
        /// </remarks>
        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsumerSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#consumer_secret_setting_name LinuxFunctionAppSlot#consumer_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "consumerSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConsumerSecretSettingName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppSlotAuthSettingsTwitter), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsTwitter")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsTwitter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The OAuth 1.0a consumer key of the Twitter application used for sign-in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#consumer_key LinuxFunctionAppSlot#consumer_key}
            /// </remarks>
            [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ConsumerKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#consumer_secret LinuxFunctionAppSlot#consumer_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsumerSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#consumer_secret_setting_name LinuxFunctionAppSlot#consumer_secret_setting_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consumerSecretSettingName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConsumerSecretSettingName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
