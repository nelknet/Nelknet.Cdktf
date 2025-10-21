using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachineScaleSet
{
    [JsiiByValue(fqn: "azurerm.windowsVirtualMachineScaleSet.WindowsVirtualMachineScaleSetBootDiagnostics")]
    public class WindowsVirtualMachineScaleSetBootDiagnostics : azurerm.WindowsVirtualMachineScaleSet.IWindowsVirtualMachineScaleSetBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine_scale_set#storage_account_uri WindowsVirtualMachineScaleSet#storage_account_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountUri
        {
            get;
            set;
        }
    }
}
