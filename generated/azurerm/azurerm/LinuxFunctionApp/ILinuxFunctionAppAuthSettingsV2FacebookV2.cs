using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppAuthSettingsV2FacebookV2), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsV2FacebookV2")]
    public interface ILinuxFunctionAppAuthSettingsV2FacebookV2
    {
        /// <summary>The App ID of the Facebook app used for login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_id LinuxFunctionApp#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        string AppId
        {
            get;
        }

        /// <summary>The app setting name that contains the `app_secret` value used for Facebook Login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_secret_setting_name LinuxFunctionApp#app_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "appSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        string AppSecretSettingName
        {
            get;
        }

        /// <summary>The version of the Facebook API to be used while logging in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#graph_api_version LinuxFunctionApp#graph_api_version}
        /// </remarks>
        [JsiiProperty(name: "graphApiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GraphApiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies a list of scopes to be requested as part of Facebook Login authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#login_scopes LinuxFunctionApp#login_scopes}
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

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppAuthSettingsV2FacebookV2), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsV2FacebookV2")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsV2FacebookV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The App ID of the Facebook app used for login.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_id LinuxFunctionApp#app_id}
            /// </remarks>
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The app setting name that contains the `app_secret` value used for Facebook Login.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_secret_setting_name LinuxFunctionApp#app_secret_setting_name}
            /// </remarks>
            [JsiiProperty(name: "appSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
            public string AppSecretSettingName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The version of the Facebook API to be used while logging in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#graph_api_version LinuxFunctionApp#graph_api_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "graphApiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GraphApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies a list of scopes to be requested as part of Facebook Login authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#login_scopes LinuxFunctionApp#login_scopes}
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
