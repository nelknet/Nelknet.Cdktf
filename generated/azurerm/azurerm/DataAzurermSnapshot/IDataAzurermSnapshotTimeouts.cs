using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSnapshot
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSnapshotTimeouts), fullyQualifiedName: "azurerm.dataAzurermSnapshot.DataAzurermSnapshotTimeouts")]
    public interface IDataAzurermSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/snapshot#read DataAzurermSnapshot#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSnapshotTimeouts), fullyQualifiedName: "azurerm.dataAzurermSnapshot.DataAzurermSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSnapshot.IDataAzurermSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/snapshot#read DataAzurermSnapshot#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
