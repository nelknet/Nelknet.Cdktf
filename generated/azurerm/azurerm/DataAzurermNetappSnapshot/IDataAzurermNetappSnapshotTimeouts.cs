using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappSnapshot
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappSnapshotTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappSnapshot.DataAzurermNetappSnapshotTimeouts")]
    public interface IDataAzurermNetappSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#read DataAzurermNetappSnapshot#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappSnapshotTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappSnapshot.DataAzurermNetappSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappSnapshot.IDataAzurermNetappSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#read DataAzurermNetappSnapshot#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
