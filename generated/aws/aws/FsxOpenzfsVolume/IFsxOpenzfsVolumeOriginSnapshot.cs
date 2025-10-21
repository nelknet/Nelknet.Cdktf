using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsVolume
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsVolumeOriginSnapshot), fullyQualifiedName: "aws.fsxOpenzfsVolume.FsxOpenzfsVolumeOriginSnapshot")]
    public interface IFsxOpenzfsVolumeOriginSnapshot
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#copy_strategy FsxOpenzfsVolume#copy_strategy}.</summary>
        [JsiiProperty(name: "copyStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string CopyStrategy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#snapshot_arn FsxOpenzfsVolume#snapshot_arn}.</summary>
        [JsiiProperty(name: "snapshotArn", typeJson: "{\"primitive\":\"string\"}")]
        string SnapshotArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsVolumeOriginSnapshot), fullyQualifiedName: "aws.fsxOpenzfsVolume.FsxOpenzfsVolumeOriginSnapshot")]
        internal sealed class _Proxy : DeputyBase, aws.FsxOpenzfsVolume.IFsxOpenzfsVolumeOriginSnapshot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#copy_strategy FsxOpenzfsVolume#copy_strategy}.</summary>
            [JsiiProperty(name: "copyStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string CopyStrategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#snapshot_arn FsxOpenzfsVolume#snapshot_arn}.</summary>
            [JsiiProperty(name: "snapshotArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SnapshotArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
