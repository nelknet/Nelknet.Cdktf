using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDiskAccess
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDiskAccessTimeouts), fullyQualifiedName: "azurerm.dataAzurermDiskAccess.DataAzurermDiskAccessTimeouts")]
    public interface IDataAzurermDiskAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_access#read DataAzurermDiskAccess#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDiskAccessTimeouts), fullyQualifiedName: "azurerm.dataAzurermDiskAccess.DataAzurermDiskAccessTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDiskAccess.IDataAzurermDiskAccessTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/disk_access#read DataAzurermDiskAccess#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
