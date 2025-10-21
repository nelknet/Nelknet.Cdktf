using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxOpenzfsVolume.FsxOpenzfsVolumeOriginSnapshot")]
    public class FsxOpenzfsVolumeOriginSnapshot : aws.FsxOpenzfsVolume.IFsxOpenzfsVolumeOriginSnapshot
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#copy_strategy FsxOpenzfsVolume#copy_strategy}.</summary>
        [JsiiProperty(name: "copyStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string CopyStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_openzfs_volume#snapshot_arn FsxOpenzfsVolume#snapshot_arn}.</summary>
        [JsiiProperty(name: "snapshotArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SnapshotArn
        {
            get;
            set;
        }
    }
}
