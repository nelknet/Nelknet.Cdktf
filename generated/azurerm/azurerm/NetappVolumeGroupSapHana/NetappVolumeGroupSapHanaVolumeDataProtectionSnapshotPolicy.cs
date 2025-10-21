using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupSapHana
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeGroupSapHana.NetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy")]
    public class NetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy : azurerm.NetappVolumeGroupSapHana.INetappVolumeGroupSapHanaVolumeDataProtectionSnapshotPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume_group_sap_hana#snapshot_policy_id NetappVolumeGroupSapHana#snapshot_policy_id}.</summary>
        [JsiiProperty(name: "snapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public string SnapshotPolicyId
        {
            get;
            set;
        }
    }
}
