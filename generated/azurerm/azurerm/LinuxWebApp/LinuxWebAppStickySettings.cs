using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppStickySettings")]
    public class LinuxWebAppStickySettings : azurerm.LinuxWebApp.ILinuxWebAppStickySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#app_setting_names LinuxWebApp#app_setting_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appSettingNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AppSettingNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#connection_string_names LinuxWebApp#connection_string_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionStringNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ConnectionStringNames
        {
            get;
            set;
        }
    }
}
