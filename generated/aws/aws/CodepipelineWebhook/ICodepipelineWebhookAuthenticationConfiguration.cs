using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineWebhook
{
    [JsiiInterface(nativeType: typeof(ICodepipelineWebhookAuthenticationConfiguration), fullyQualifiedName: "aws.codepipelineWebhook.CodepipelineWebhookAuthenticationConfiguration")]
    public interface ICodepipelineWebhookAuthenticationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#allowed_ip_range CodepipelineWebhook#allowed_ip_range}.</summary>
        [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowedIpRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#secret_token CodepipelineWebhook#secret_token}.</summary>
        [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineWebhookAuthenticationConfiguration), fullyQualifiedName: "aws.codepipelineWebhook.CodepipelineWebhookAuthenticationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CodepipelineWebhook.ICodepipelineWebhookAuthenticationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#allowed_ip_range CodepipelineWebhook#allowed_ip_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowedIpRange
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#secret_token CodepipelineWebhook#secret_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
