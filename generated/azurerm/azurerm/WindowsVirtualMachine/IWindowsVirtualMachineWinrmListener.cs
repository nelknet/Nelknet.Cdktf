using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineWinrmListener), fullyQualifiedName: "azurerm.windowsVirtualMachine.WindowsVirtualMachineWinrmListener")]
    public interface IWindowsVirtualMachineWinrmListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#protocol WindowsVirtualMachine#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#certificate_url WindowsVirtualMachine#certificate_url}.</summary>
        [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineWinrmListener), fullyQualifiedName: "azurerm.windowsVirtualMachine.WindowsVirtualMachineWinrmListener")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsVirtualMachine.IWindowsVirtualMachineWinrmListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#protocol WindowsVirtualMachine#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#certificate_url WindowsVirtualMachine#certificate_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
