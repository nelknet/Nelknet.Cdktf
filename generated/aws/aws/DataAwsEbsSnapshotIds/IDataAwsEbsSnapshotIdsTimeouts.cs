using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsSnapshotIds
{
    [JsiiInterface(nativeType: typeof(IDataAwsEbsSnapshotIdsTimeouts), fullyQualifiedName: "aws.dataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsTimeouts")]
    public interface IDataAwsEbsSnapshotIdsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#read DataAwsEbsSnapshotIds#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEbsSnapshotIdsTimeouts), fullyQualifiedName: "aws.dataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEbsSnapshotIds.IDataAwsEbsSnapshotIdsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#read DataAwsEbsSnapshotIds#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
