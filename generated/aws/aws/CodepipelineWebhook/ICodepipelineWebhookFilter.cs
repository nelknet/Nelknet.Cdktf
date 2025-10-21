using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineWebhook
{
    [JsiiInterface(nativeType: typeof(ICodepipelineWebhookFilter), fullyQualifiedName: "aws.codepipelineWebhook.CodepipelineWebhookFilter")]
    public interface ICodepipelineWebhookFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#json_path CodepipelineWebhook#json_path}.</summary>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        string JsonPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#match_equals CodepipelineWebhook#match_equals}.</summary>
        [JsiiProperty(name: "matchEquals", typeJson: "{\"primitive\":\"string\"}")]
        string MatchEquals
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineWebhookFilter), fullyQualifiedName: "aws.codepipelineWebhook.CodepipelineWebhookFilter")]
        internal sealed class _Proxy : DeputyBase, aws.CodepipelineWebhook.ICodepipelineWebhookFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#json_path CodepipelineWebhook#json_path}.</summary>
            [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
            public string JsonPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#match_equals CodepipelineWebhook#match_equals}.</summary>
            [JsiiProperty(name: "matchEquals", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchEquals
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
