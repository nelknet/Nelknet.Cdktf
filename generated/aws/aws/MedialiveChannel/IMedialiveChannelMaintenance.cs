using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelMaintenance), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelMaintenance")]
    public interface IMedialiveChannelMaintenance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maintenance_day MedialiveChannel#maintenance_day}.</summary>
        [JsiiProperty(name: "maintenanceDay", typeJson: "{\"primitive\":\"string\"}")]
        string MaintenanceDay
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maintenance_start_time MedialiveChannel#maintenance_start_time}.</summary>
        [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}")]
        string MaintenanceStartTime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelMaintenance), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelMaintenance")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelMaintenance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maintenance_day MedialiveChannel#maintenance_day}.</summary>
            [JsiiProperty(name: "maintenanceDay", typeJson: "{\"primitive\":\"string\"}")]
            public string MaintenanceDay
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#maintenance_start_time MedialiveChannel#maintenance_start_time}.</summary>
            [JsiiProperty(name: "maintenanceStartTime", typeJson: "{\"primitive\":\"string\"}")]
            public string MaintenanceStartTime
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
