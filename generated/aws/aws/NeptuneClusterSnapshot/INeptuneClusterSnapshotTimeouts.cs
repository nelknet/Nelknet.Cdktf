using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NeptuneClusterSnapshot
{
    [JsiiInterface(nativeType: typeof(INeptuneClusterSnapshotTimeouts), fullyQualifiedName: "aws.neptuneClusterSnapshot.NeptuneClusterSnapshotTimeouts")]
    public interface INeptuneClusterSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_snapshot#create NeptuneClusterSnapshot#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INeptuneClusterSnapshotTimeouts), fullyQualifiedName: "aws.neptuneClusterSnapshot.NeptuneClusterSnapshotTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.NeptuneClusterSnapshot.INeptuneClusterSnapshotTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_snapshot#create NeptuneClusterSnapshot#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
