using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsSnapshotIds
{
    [JsiiInterface(nativeType: typeof(IDataAwsEbsSnapshotIdsFilter), fullyQualifiedName: "aws.dataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsFilter")]
    public interface IDataAwsEbsSnapshotIdsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#name DataAwsEbsSnapshotIds#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#values DataAwsEbsSnapshotIds#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEbsSnapshotIdsFilter), fullyQualifiedName: "aws.dataAwsEbsSnapshotIds.DataAwsEbsSnapshotIdsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEbsSnapshotIds.IDataAwsEbsSnapshotIdsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#name DataAwsEbsSnapshotIds#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot_ids#values DataAwsEbsSnapshotIds#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
