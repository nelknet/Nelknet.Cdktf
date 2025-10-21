using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbClusterSnapshot
{
    [JsiiInterface(nativeType: typeof(IDbClusterSnapshotTimeouts), fullyQualifiedName: "aws.dbClusterSnapshot.DbClusterSnapshotTimeouts")]
    public interface IDbClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#create DbClusterSnapshot#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbClusterSnapshotTimeouts), fullyQualifiedName: "aws.dbClusterSnapshot.DbClusterSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DbClusterSnapshot.IDbClusterSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_cluster_snapshot#create DbClusterSnapshot#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
