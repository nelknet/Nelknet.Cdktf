using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHumanTaskUi
{
    [JsiiByValue(fqn: "aws.sagemakerHumanTaskUi.SagemakerHumanTaskUiUiTemplate")]
    public class SagemakerHumanTaskUiUiTemplate : aws.SagemakerHumanTaskUi.ISagemakerHumanTaskUiUiTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui#content SagemakerHumanTaskUi#content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Content
        {
            get;
            set;
        }
    }
}
