using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SnapshotCreateVolumePermission
{
    [JsiiInterface(nativeType: typeof(ISnapshotCreateVolumePermissionTimeouts), fullyQualifiedName: "aws.snapshotCreateVolumePermission.SnapshotCreateVolumePermissionTimeouts")]
    public interface ISnapshotCreateVolumePermissionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#create SnapshotCreateVolumePermission#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#delete SnapshotCreateVolumePermission#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISnapshotCreateVolumePermissionTimeouts), fullyQualifiedName: "aws.snapshotCreateVolumePermission.SnapshotCreateVolumePermissionTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.SnapshotCreateVolumePermission.ISnapshotCreateVolumePermissionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#create SnapshotCreateVolumePermission#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#delete SnapshotCreateVolumePermission#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
