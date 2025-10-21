using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachinePacketCapture
{
    [JsiiByValue(fqn: "azurerm.virtualMachinePacketCapture.VirtualMachinePacketCaptureStorageLocation")]
    public class VirtualMachinePacketCaptureStorageLocation : azurerm.VirtualMachinePacketCapture.IVirtualMachinePacketCaptureStorageLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#file_path VirtualMachinePacketCapture#file_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_packet_capture#storage_account_id VirtualMachinePacketCapture#storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountId
        {
            get;
            set;
        }
    }
}
