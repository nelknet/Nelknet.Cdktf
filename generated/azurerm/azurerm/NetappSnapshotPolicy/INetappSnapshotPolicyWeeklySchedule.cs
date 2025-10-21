using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappSnapshotPolicy
{
    [JsiiInterface(nativeType: typeof(INetappSnapshotPolicyWeeklySchedule), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyWeeklySchedule")]
    public interface INetappSnapshotPolicyWeeklySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#days_of_week NetappSnapshotPolicy#days_of_week}.</summary>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DaysOfWeek
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#hour NetappSnapshotPolicy#hour}.</summary>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}")]
        double Hour
        {
            get;
        }

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

        [JsiiTypeProxy(nativeType: typeof(INetappSnapshotPolicyWeeklySchedule), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyWeeklySchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyWeeklySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#days_of_week NetappSnapshotPolicy#days_of_week}.</summary>
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DaysOfWeek
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#hour NetappSnapshotPolicy#hour}.</summary>
            [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}")]
            public double Hour
            {
                get => GetInstanceProperty<double>()!;
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
