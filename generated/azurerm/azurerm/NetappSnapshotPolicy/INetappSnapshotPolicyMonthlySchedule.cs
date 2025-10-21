using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappSnapshotPolicy
{
    [JsiiInterface(nativeType: typeof(INetappSnapshotPolicyMonthlySchedule), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyMonthlySchedule")]
    public interface INetappSnapshotPolicyMonthlySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#days_of_month NetappSnapshotPolicy#days_of_month}.</summary>
        [JsiiProperty(name: "daysOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] DaysOfMonth
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

        [JsiiTypeProxy(nativeType: typeof(INetappSnapshotPolicyMonthlySchedule), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyMonthlySchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyMonthlySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#days_of_month NetappSnapshotPolicy#days_of_month}.</summary>
            [JsiiProperty(name: "daysOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] DaysOfMonth
            {
                get => GetInstanceProperty<double[]>()!;
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
