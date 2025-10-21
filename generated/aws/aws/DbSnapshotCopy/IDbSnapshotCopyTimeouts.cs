using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbSnapshotCopy
{
    [JsiiInterface(nativeType: typeof(IDbSnapshotCopyTimeouts), fullyQualifiedName: "aws.dbSnapshotCopy.DbSnapshotCopyTimeouts")]
    public interface IDbSnapshotCopyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#create DbSnapshotCopy#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbSnapshotCopyTimeouts), fullyQualifiedName: "aws.dbSnapshotCopy.DbSnapshotCopyTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DbSnapshotCopy.IDbSnapshotCopyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#create DbSnapshotCopy#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
