using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InspectorAssessmentTemplate
{
    [JsiiInterface(nativeType: typeof(IInspectorAssessmentTemplateEventSubscription), fullyQualifiedName: "aws.inspectorAssessmentTemplate.InspectorAssessmentTemplateEventSubscription")]
    public interface IInspectorAssessmentTemplateEventSubscription
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#event InspectorAssessmentTemplate#event}.</summary>
        [JsiiProperty(name: "event", typeJson: "{\"primitive\":\"string\"}")]
        string Event
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#topic_arn InspectorAssessmentTemplate#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInspectorAssessmentTemplateEventSubscription), fullyQualifiedName: "aws.inspectorAssessmentTemplate.InspectorAssessmentTemplateEventSubscription")]
        internal sealed class _Proxy : DeputyBase, aws.InspectorAssessmentTemplate.IInspectorAssessmentTemplateEventSubscription
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#event InspectorAssessmentTemplate#event}.</summary>
            [JsiiProperty(name: "event", typeJson: "{\"primitive\":\"string\"}")]
            public string Event
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#topic_arn InspectorAssessmentTemplate#topic_arn}.</summary>
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
