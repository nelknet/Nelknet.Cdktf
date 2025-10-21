using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkteam
{
    [JsiiByValue(fqn: "aws.sagemakerWorkteam.SagemakerWorkteamNotificationConfiguration")]
    public class SagemakerWorkteamNotificationConfiguration : aws.SagemakerWorkteam.ISagemakerWorkteamNotificationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workteam#notification_topic_arn SagemakerWorkteam#notification_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotificationTopicArn
        {
            get;
            set;
        }
    }
}
