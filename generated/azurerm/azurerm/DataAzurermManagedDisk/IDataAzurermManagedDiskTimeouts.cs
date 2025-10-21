using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedDisk
{
    [JsiiInterface(nativeType: typeof(IDataAzurermManagedDiskTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagedDisk.DataAzurermManagedDiskTimeouts")]
    public interface IDataAzurermManagedDiskTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_disk#read DataAzurermManagedDisk#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermManagedDiskTimeouts), fullyQualifiedName: "azurerm.dataAzurermManagedDisk.DataAzurermManagedDiskTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermManagedDisk.IDataAzurermManagedDiskTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/managed_disk#read DataAzurermManagedDisk#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
