using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorReplicationInfoListTopicReplicationStartingPosition), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPosition")]
    public interface IMskReplicatorReplicationInfoListTopicReplicationStartingPosition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#type MskReplicator#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorReplicationInfoListTopicReplicationStartingPosition), fullyQualifiedName: "aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPosition")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#type MskReplicator#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
