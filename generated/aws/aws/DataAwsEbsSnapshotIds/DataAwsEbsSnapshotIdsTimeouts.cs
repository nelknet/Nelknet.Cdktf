using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsSnapshotIds
{
    [JsiiByValue(fqn: "aws.dataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsTimeouts")]
    public class DataAwsEbsSnapshotIdsTimeouts : aws.DataAwsEbsSnapshotIds.IDataAwsEbsSnapshotIdsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#read DataAwsEbsSnapshotIds#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
