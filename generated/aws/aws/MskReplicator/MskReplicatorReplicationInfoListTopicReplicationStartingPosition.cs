using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorReplicationInfoListTopicReplicationStartingPosition")]
    public class MskReplicatorReplicationInfoListTopicReplicationStartingPosition : aws.MskReplicator.IMskReplicatorReplicationInfoListTopicReplicationStartingPosition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_replicator#type MskReplicator#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
