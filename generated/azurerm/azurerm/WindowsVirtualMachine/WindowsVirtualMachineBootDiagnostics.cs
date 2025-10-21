using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsVirtualMachine
{
    [JsiiByValue(fqn: "azurerm.windowsVirtualMachine.WindowsVirtualMachineBootDiagnostics")]
    public class WindowsVirtualMachineBootDiagnostics : azurerm.WindowsVirtualMachine.IWindowsVirtualMachineBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_virtual_machine#storage_account_uri WindowsVirtualMachine#storage_account_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountUri
        {
            get;
            set;
        }
    }
}
