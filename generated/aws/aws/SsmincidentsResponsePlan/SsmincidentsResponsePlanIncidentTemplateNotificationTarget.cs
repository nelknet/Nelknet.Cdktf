using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplateNotificationTarget")]
    public class SsmincidentsResponsePlanIncidentTemplateNotificationTarget : aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIncidentTemplateNotificationTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#sns_topic_arn SsmincidentsResponsePlan#sns_topic_arn}.</summary>
        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SnsTopicArn
        {
            get;
            set;
        }
    }
}
