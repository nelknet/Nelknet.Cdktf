using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsV2FacebookV2")]
    public class LinuxFunctionAppAuthSettingsV2FacebookV2 : azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsV2FacebookV2
    {
        /// <summary>The App ID of the Facebook app used for login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_id LinuxFunctionApp#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        public string AppId
        {
            get;
            set;
        }

        /// <summary>The app setting name that contains the `app_secret` value used for Facebook Login.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_secret_setting_name LinuxFunctionApp#app_secret_setting_name}
        /// </remarks>
        [JsiiProperty(name: "appSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        public string AppSecretSettingName
        {
            get;
            set;
        }

        /// <summary>The version of the Facebook API to be used while logging in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#graph_api_version LinuxFunctionApp#graph_api_version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "graphApiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GraphApiVersion
        {
            get;
            set;
        }

        /// <summary>Specifies a list of scopes to be requested as part of Facebook Login authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#login_scopes LinuxFunctionApp#login_scopes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loginScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LoginScopes
        {
            get;
            set;
        }
    }
}
