using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotSiteConfigHandlerMapping), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigHandlerMapping")]
    public interface IWindowsWebAppSlotSiteConfigHandlerMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#extension WindowsWebAppSlot#extension}.</summary>
        [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
        string Extension
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#script_processor_path WindowsWebAppSlot#script_processor_path}.</summary>
        [JsiiProperty(name: "scriptProcessorPath", typeJson: "{\"primitive\":\"string\"}")]
        string ScriptProcessorPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#arguments WindowsWebAppSlot#arguments}.</summary>
        [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Arguments
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotSiteConfigHandlerMapping), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigHandlerMapping")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigHandlerMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#extension WindowsWebAppSlot#extension}.</summary>
            [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
            public string Extension
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#script_processor_path WindowsWebAppSlot#script_processor_path}.</summary>
            [JsiiProperty(name: "scriptProcessorPath", typeJson: "{\"primitive\":\"string\"}")]
            public string ScriptProcessorPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#arguments WindowsWebAppSlot#arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Arguments
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
