using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolume.NetappVolumeDataProtectionSnapshotPolicy")]
    public class NetappVolumeDataProtectionSnapshotPolicy : azurerm.NetappVolume.INetappVolumeDataProtectionSnapshotPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_volume#snapshot_policy_id NetappVolume#snapshot_policy_id}.</summary>
        [JsiiProperty(name: "snapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public string SnapshotPolicyId
        {
            get;
            set;
        }
    }
}
