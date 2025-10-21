using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentActionGroup
{
    [JsiiByValue(fqn: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupApiSchemaS3")]
    public class BedrockagentAgentActionGroupApiSchemaS3 : aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupApiSchemaS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#s3_bucket_name BedrockagentAgentActionGroup#s3_bucket_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#s3_object_key BedrockagentAgentActionGroup#s3_object_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3ObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3ObjectKey
        {
            get;
            set;
        }
    }
}
