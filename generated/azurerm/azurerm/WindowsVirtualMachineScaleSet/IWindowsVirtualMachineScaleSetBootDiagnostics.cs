using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IWindowsVirtualMachineScaleSetBootDiagnostics), fullyQualifiedName: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics")]
    public interface IWindowsVirtualMachineScaleSetBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#storage_account_uri WindowsVirtualMachineScaleSet#storage_account_uri}.</summary>
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccountUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsVirtualMachineScaleSetBootDiagnostics), fullyQualifiedName: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#storage_account_uri WindowsVirtualMachineScaleSet#storage_account_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccountUri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
