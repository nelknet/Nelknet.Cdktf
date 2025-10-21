using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruNotificationChannel
{
    [JsiiInterface(nativeType: typeof(IDevopsguruNotificationChannelSns), fullyQualifiedName: "aws.devopsguruNotificationChannel.DevopsguruNotificationChannelSns")]
    public interface IDevopsguruNotificationChannelSns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#topic_arn DevopsguruNotificationChannel#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruNotificationChannelSns), fullyQualifiedName: "aws.devopsguruNotificationChannel.DevopsguruNotificationChannelSns")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruNotificationChannel.IDevopsguruNotificationChannelSns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#topic_arn DevopsguruNotificationChannel#topic_arn}.</summary>
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
