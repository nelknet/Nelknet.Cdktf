using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsSnapshot
{
    [JsiiInterface(nativeType: typeof(IDataAwsEbsSnapshotTimeouts), fullyQualifiedName: "aws.dataAwsEbsSnapshot.DataAwsEbsSnapshotTimeouts")]
    public interface IDataAwsEbsSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#read DataAwsEbsSnapshot#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEbsSnapshotTimeouts), fullyQualifiedName: "aws.dataAwsEbsSnapshot.DataAwsEbsSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEbsSnapshot.IDataAwsEbsSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_snapshot#read DataAwsEbsSnapshot#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
