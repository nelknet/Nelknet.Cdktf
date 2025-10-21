using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruNotificationChannel
{
    [JsiiInterface(nativeType: typeof(IDevopsguruNotificationChannelFilters), fullyQualifiedName: "aws.devopsguruNotificationChannel.DevopsguruNotificationChannelFilters")]
    public interface IDevopsguruNotificationChannelFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#message_types DevopsguruNotificationChannel#message_types}.</summary>
        [JsiiProperty(name: "messageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MessageTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#severities DevopsguruNotificationChannel#severities}.</summary>
        [JsiiProperty(name: "severities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Severities
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruNotificationChannelFilters), fullyQualifiedName: "aws.devopsguruNotificationChannel.DevopsguruNotificationChannelFilters")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruNotificationChannel.IDevopsguruNotificationChannelFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#message_types DevopsguruNotificationChannel#message_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MessageTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#severities DevopsguruNotificationChannel#severities}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "severities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Severities
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
