using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PinpointApp
{
    [JsiiByValue(fqn: "aws.pinpointApp.PinpointAppLimits")]
    public class PinpointAppLimits : aws.PinpointApp.IPinpointAppLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#daily PinpointApp#daily}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daily", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Daily
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#maximum_duration PinpointApp#maximum_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#messages_per_second PinpointApp#messages_per_second}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messagesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MessagesPerSecond
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_app#total PinpointApp#total}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Total
        {
            get;
            set;
        }
    }
}
