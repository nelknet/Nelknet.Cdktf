using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SnapshotCreateVolumePermission
{
    [JsiiByValue(fqn: "aws.snapshotCreateVolumePermission.SnapshotCreateVolumePermissionTimeouts")]
    public class SnapshotCreateVolumePermissionTimeouts : aws.SnapshotCreateVolumePermission.ISnapshotCreateVolumePermissionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#create SnapshotCreateVolumePermission#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/snapshot_create_volume_permission#delete SnapshotCreateVolumePermission#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
