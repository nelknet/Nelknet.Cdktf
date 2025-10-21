using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    [JsiiInterface(nativeType: typeof(ISsmincidentsResponsePlanIncidentTemplateNotificationTarget), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTarget")]
    public interface ISsmincidentsResponsePlanIncidentTemplateNotificationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#sns_topic_arn SsmincidentsResponsePlan#sns_topic_arn}.</summary>
        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        string SnsTopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmincidentsResponsePlanIncidentTemplateNotificationTarget), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTarget")]
        internal sealed class _Proxy : DeputyBase, aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplateNotificationTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#sns_topic_arn SsmincidentsResponsePlan#sns_topic_arn}.</summary>
            [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SnsTopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
