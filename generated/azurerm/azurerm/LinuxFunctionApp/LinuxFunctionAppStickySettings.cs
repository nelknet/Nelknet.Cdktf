using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiByValue(fqn: "azurerm.linuxFunctionApp.LinuxFunctionAppStickySettings")]
    public class LinuxFunctionAppStickySettings : azurerm.LinuxFunctionApp.ILinuxFunctionAppStickySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#app_setting_names LinuxFunctionApp#app_setting_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appSettingNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AppSettingNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#connection_string_names LinuxFunctionApp#connection_string_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionStringNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ConnectionStringNames
        {
            get;
            set;
        }
    }
}
