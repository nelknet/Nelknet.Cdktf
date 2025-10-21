using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsSnapshot
{
    [JsiiByValue(fqn: "aws.dataAwsEbsSnapshot.DataAwsEbsSnapshotTimeouts")]
    public class DataAwsEbsSnapshotTimeouts : aws.DataAwsEbsSnapshot.IDataAwsEbsSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#read DataAwsEbsSnapshot#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
