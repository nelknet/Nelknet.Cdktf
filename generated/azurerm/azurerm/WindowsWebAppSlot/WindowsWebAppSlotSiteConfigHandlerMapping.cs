using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigHandlerMapping")]
    public class WindowsWebAppSlotSiteConfigHandlerMapping : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigHandlerMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#extension WindowsWebAppSlot#extension}.</summary>
        [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
        public string Extension
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#script_processor_path WindowsWebAppSlot#script_processor_path}.</summary>
        [JsiiProperty(name: "scriptProcessorPath", typeJson: "{\"primitive\":\"string\"}")]
        public string ScriptProcessorPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#arguments WindowsWebAppSlot#arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arguments
        {
            get;
            set;
        }
    }
}
