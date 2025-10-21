using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachine
{
    [JsiiByValue(fqn: "azurerm.linuxVirtualMachine.LinuxVirtualMachineBootDiagnostics")]
    public class LinuxVirtualMachineBootDiagnostics : azurerm.LinuxVirtualMachine.ILinuxVirtualMachineBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#storage_account_uri LinuxVirtualMachine#storage_account_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountUri
        {
            get;
            set;
        }
    }
}
