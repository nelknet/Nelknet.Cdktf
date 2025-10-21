using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupSapHana
{
    [JsiiInterface(nativeType: typeof(INetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy), fullyQualifiedName: "azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy")]
    public interface INetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#snapshot_policy_id NetappVolumeGroupSapHana#snapshot_policy_id}.</summary>
        [JsiiProperty(name: "snapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string SnapshotPolicyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy), fullyQualifiedName: "azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#snapshot_policy_id NetappVolumeGroupSapHana#snapshot_policy_id}.</summary>
            [JsiiProperty(name: "snapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string SnapshotPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
