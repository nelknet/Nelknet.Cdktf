using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappSnapshotPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyDailySchedule")]
    public class NetappSnapshotPolicyDailySchedule : azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyDailySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#hour NetappSnapshotPolicy#hour}.</summary>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}")]
        public double Hour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#minute NetappSnapshotPolicy#minute}.</summary>
        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
        public double Minute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#snapshots_to_keep NetappSnapshotPolicy#snapshots_to_keep}.</summary>
        [JsiiProperty(name: "snapshotsToKeep", typeJson: "{\"primitive\":\"number\"}")]
        public double SnapshotsToKeep
        {
            get;
            set;
        }
    }
}
