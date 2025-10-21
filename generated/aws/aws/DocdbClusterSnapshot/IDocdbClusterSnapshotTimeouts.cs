using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DocdbClusterSnapshot
{
    [JsiiInterface(nativeType: typeof(IDocdbClusterSnapshotTimeouts), fullyQualifiedName: "aws.docdbClusterSnapshot.DocdbClusterSnapshotTimeouts")]
    public interface IDocdbClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_snapshot#create DocdbClusterSnapshot#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDocdbClusterSnapshotTimeouts), fullyQualifiedName: "aws.docdbClusterSnapshot.DocdbClusterSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DocdbClusterSnapshot.IDocdbClusterSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_snapshot#create DocdbClusterSnapshot#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
