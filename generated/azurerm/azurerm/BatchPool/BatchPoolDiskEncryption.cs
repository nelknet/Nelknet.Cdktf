using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolDiskEncryption")]
    public class BatchPoolDiskEncryption : azurerm.BatchPool.IBatchPoolDiskEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#disk_encryption_target BatchPool#disk_encryption_target}.</summary>
        [JsiiProperty(name: "diskEncryptionTarget", typeJson: "{\"primitive\":\"string\"}")]
        public string DiskEncryptionTarget
        {
            get;
            set;
        }
    }
}
