using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruNotificationChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.devopsguruNotificationChannel.DevopsguruNotificationChannelSns")]
    public class DevopsguruNotificationChannelSns : aws.DevopsguruNotificationChannel.IDevopsguruNotificationChannelSns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#topic_arn DevopsguruNotificationChannel#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicArn
        {
            get;
            set;
        }
    }
}
