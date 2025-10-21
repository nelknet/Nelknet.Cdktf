using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkPacketCapture
{
    [JsiiByValue(fqn: "azurerm.networkPacketCapture.NetworkPacketCaptureStorageLocation")]
    public class NetworkPacketCaptureStorageLocation : azurerm.NetworkPacketCapture.INetworkPacketCaptureStorageLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#file_path NetworkPacketCapture#file_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_packet_capture#storage_account_id NetworkPacketCapture#storage_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountId
        {
            get;
            set;
        }
    }
}
