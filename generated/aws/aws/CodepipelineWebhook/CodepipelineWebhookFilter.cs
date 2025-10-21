using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineWebhook
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipelineWebhook.CodepipelineWebhookFilter")]
    public class CodepipelineWebhookFilter : aws.CodepipelineWebhook.ICodepipelineWebhookFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#json_path CodepipelineWebhook#json_path}.</summary>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        public string JsonPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_webhook#match_equals CodepipelineWebhook#match_equals}.</summary>
        [JsiiProperty(name: "matchEquals", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchEquals
        {
            get;
            set;
        }
    }
}
