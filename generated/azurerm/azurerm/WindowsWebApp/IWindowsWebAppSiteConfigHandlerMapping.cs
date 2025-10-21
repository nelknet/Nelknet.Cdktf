using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSiteConfigHandlerMapping), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigHandlerMapping")]
    public interface IWindowsWebAppSiteConfigHandlerMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#extension WindowsWebApp#extension}.</summary>
        [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
        string Extension
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#script_processor_path WindowsWebApp#script_processor_path}.</summary>
        [JsiiProperty(name: "scriptProcessorPath", typeJson: "{\"primitive\":\"string\"}")]
        string ScriptProcessorPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#arguments WindowsWebApp#arguments}.</summary>
        [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Arguments
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSiteConfigHandlerMapping), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigHandlerMapping")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppSiteConfigHandlerMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#extension WindowsWebApp#extension}.</summary>
            [JsiiProperty(name: "extension", typeJson: "{\"primitive\":\"string\"}")]
            public string Extension
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#script_processor_path WindowsWebApp#script_processor_path}.</summary>
            [JsiiProperty(name: "scriptProcessorPath", typeJson: "{\"primitive\":\"string\"}")]
            public string ScriptProcessorPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#arguments WindowsWebApp#arguments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arguments", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Arguments
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
