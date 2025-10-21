using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentAgentActionGroup
{
    [JsiiInterface(nativeType: typeof(IBedrockagentAgentActionGroupApiSchemaS3), fullyQualifiedName: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupApiSchemaS3")]
    public interface IBedrockagentAgentActionGroupApiSchemaS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#s3_bucket_name BedrockagentAgentActionGroup#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3BucketName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#s3_object_key BedrockagentAgentActionGroup#s3_object_key}.</summary>
        [JsiiProperty(name: "s3ObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3ObjectKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentAgentActionGroupApiSchemaS3), fullyQualifiedName: "aws.bedrockagentAgentActionGroup.BedrockagentAgentActionGroupApiSchemaS3")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentAgentActionGroup.IBedrockagentAgentActionGroupApiSchemaS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#s3_bucket_name BedrockagentAgentActionGroup#s3_bucket_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3BucketName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_agent_action_group#s3_object_key BedrockagentAgentActionGroup#s3_object_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3ObjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3ObjectKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
