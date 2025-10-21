using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineOsProfileLinuxConfigSshKeys), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfigSshKeys")]
    public interface IVirtualMachineOsProfileLinuxConfigSshKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#key_data VirtualMachine#key_data}.</summary>
        [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}")]
        string KeyData
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#path VirtualMachine#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineOsProfileLinuxConfigSshKeys), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfigSshKeys")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachine.IVirtualMachineOsProfileLinuxConfigSshKeys
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#key_data VirtualMachine#key_data}.</summary>
            [JsiiProperty(name: "keyData", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyData
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#path VirtualMachine#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
