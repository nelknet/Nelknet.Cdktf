using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappSnapshotPolicy
{
    [JsiiInterface(nativeType: typeof(INetappSnapshotPolicyHourlySchedule), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlySchedule")]
    public interface INetappSnapshotPolicyHourlySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#minute NetappSnapshotPolicy#minute}.</summary>
        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
        double Minute
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#snapshots_to_keep NetappSnapshotPolicy#snapshots_to_keep}.</summary>
        [JsiiProperty(name: "snapshotsToKeep", typeJson: "{\"primitive\":\"number\"}")]
        double SnapshotsToKeep
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappSnapshotPolicyHourlySchedule), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlySchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#minute NetappSnapshotPolicy#minute}.</summary>
            [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
            public double Minute
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#snapshots_to_keep NetappSnapshotPolicy#snapshots_to_keep}.</summary>
            [JsiiProperty(name: "snapshotsToKeep", typeJson: "{\"primitive\":\"number\"}")]
            public double SnapshotsToKeep
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
