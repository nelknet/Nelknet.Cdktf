using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppSiteConfigHandlerMapping")]
    public class WindowsWebAppSiteConfigHandlerMapping : azurerm.WindowsWebApp.IWindowsWebAppSiteConfigHandlerMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#extension WindowsWebApp#extension}.</summary>
        [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
        public string Extension
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#script_processor_path WindowsWebApp#script_processor_path}.</summary>
        [JsiiProperty(name: "scriptProcessorPath", typeJson: "{\"primitive\":\"string\"}")]
        public string ScriptProcessorPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#arguments WindowsWebApp#arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arguments
        {
            get;
            set;
        }
    }
}
