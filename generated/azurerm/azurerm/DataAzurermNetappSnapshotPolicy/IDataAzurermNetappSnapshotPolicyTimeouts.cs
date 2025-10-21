using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappSnapshotPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNetappSnapshotPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicyTimeouts")]
    public interface IDataAzurermNetappSnapshotPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot_policy#read DataAzurermNetappSnapshotPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNetappSnapshotPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermNetappSnapshotPolicy.DataAzurermNetappSnapshotPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNetappSnapshotPolicy.IDataAzurermNetappSnapshotPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot_policy#read DataAzurermNetappSnapshotPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
