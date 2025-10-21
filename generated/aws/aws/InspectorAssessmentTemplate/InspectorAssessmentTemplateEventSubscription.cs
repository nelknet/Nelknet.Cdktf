using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InspectorAssessmentTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.inspectorAssessmentTemplate.InspectorAssessmentTemplateEventSubscription")]
    public class InspectorAssessmentTemplateEventSubscription : aws.InspectorAssessmentTemplate.IInspectorAssessmentTemplateEventSubscription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#event InspectorAssessmentTemplate#event}.</summary>
        [JsiiProperty(name: "event", typeJson: "{\"primitive\":\"string\"}")]
        public string Event
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#topic_arn InspectorAssessmentTemplate#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicArn
        {
            get;
            set;
        }
    }
}
