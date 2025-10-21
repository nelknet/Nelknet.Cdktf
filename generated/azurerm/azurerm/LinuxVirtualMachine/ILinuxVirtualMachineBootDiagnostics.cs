using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachine
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineBootDiagnostics), fullyQualifiedName: "azurerm.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics")]
    public interface ILinuxVirtualMachineBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#storage_account_uri LinuxVirtualMachine#storage_account_uri}.</summary>
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineBootDiagnostics), fullyQualifiedName: "azurerm.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#storage_account_uri LinuxVirtualMachine#storage_account_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountUri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
