using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineAdditionalUnattendContent), fullyQualifiedName: "azurerm.windowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContent")]
    public interface IWindowsVirtualMachineAdditionalUnattendContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#content WindowsVirtualMachine#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#setting WindowsVirtualMachine#setting}.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
        string Setting
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineAdditionalUnattendContent), fullyQualifiedName: "azurerm.windowsVirtualMachine.WindowsVirtualMachineAdditionalUnattendContent")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsVirtualMachine.IWindowsVirtualMachineAdditionalUnattendContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#content WindowsVirtualMachine#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#setting WindowsVirtualMachine#setting}.</summary>
            [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
            public string Setting
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
