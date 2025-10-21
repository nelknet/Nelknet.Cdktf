using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    [JsiiInterface(nativeType: typeof(INetappVolumeDataProtectionSnapshotPolicy), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeDataProtectionSnapshotPolicy")]
    public interface INetappVolumeDataProtectionSnapshotPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#snapshot_policy_id NetappVolume#snapshot_policy_id}.</summary>
        [JsiiProperty(name: "snapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string SnapshotPolicyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeDataProtectionSnapshotPolicy), fullyQualifiedName: "azurerm.netappVolume.NetappVolumeDataProtectionSnapshotPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolume.INetappVolumeDataProtectionSnapshotPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#snapshot_policy_id NetappVolume#snapshot_policy_id}.</summary>
            [JsiiProperty(name: "snapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string SnapshotPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
