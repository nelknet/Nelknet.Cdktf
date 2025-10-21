using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineWebhook
{
    [JsiiByValue(fqn: "aws.codepipelineWebhook.CodepipelineWebhookAuthenticationConfiguration")]
    public class CodepipelineWebhookAuthenticationConfiguration : aws.CodepipelineWebhook.ICodepipelineWebhookAuthenticationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#allowed_ip_range CodepipelineWebhook#allowed_ip_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllowedIpRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#secret_token CodepipelineWebhook#secret_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretToken
        {
            get;
            set;
        }
    }
}
