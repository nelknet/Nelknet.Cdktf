using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruNotificationChannel
{
    [JsiiByValue(fqn: "aws.devopsguruNotificationChannel.DevopsguruNotificationChannelFilters")]
    public class DevopsguruNotificationChannelFilters : aws.DevopsguruNotificationChannel.IDevopsguruNotificationChannelFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#message_types DevopsguruNotificationChannel#message_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MessageTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#severities DevopsguruNotificationChannel#severities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "severities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Severities
        {
            get;
            set;
        }
    }
}
