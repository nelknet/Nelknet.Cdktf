using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolDiskEncryption), fullyQualifiedName: "azurerm.batchPool.BatchPoolDiskEncryption")]
    public interface IBatchPoolDiskEncryption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#disk_encryption_target BatchPool#disk_encryption_target}.</summary>
        [JsiiProperty(name: "diskEncryptionTarget", typeJson: "{\"primitive\":\"string\"}")]
        string DiskEncryptionTarget
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolDiskEncryption), fullyQualifiedName: "azurerm.batchPool.BatchPoolDiskEncryption")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolDiskEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#disk_encryption_target BatchPool#disk_encryption_target}.</summary>
            [JsiiProperty(name: "diskEncryptionTarget", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskEncryptionTarget
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
